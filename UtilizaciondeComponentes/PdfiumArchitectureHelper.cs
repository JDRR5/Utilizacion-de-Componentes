using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace UtilizaciondeComponentes
{
    public static class PdfiumArchitectureHelper
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool wow64Process);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public static void VerifyArchitecture()
        {
            try
            {
                // Determinar si estamos en un proceso de 32 o 64 bits
                bool is64BitProcess = Environment.Is64BitProcess;
                bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;

                Console.WriteLine($"Sistema operativo de 64 bits: {is64BitOperatingSystem}");
                Console.WriteLine($"Proceso de 64 bits: {is64BitProcess}");
                
                // Comprobar si estamos en WOW64 (Windows on Windows 64)
                bool isWow64 = false;
                if (is64BitOperatingSystem && !is64BitProcess)
                {
                    if (IsWow64Process(GetCurrentProcess(), out isWow64))
                    {
                        Console.WriteLine($"Proceso ejecutándose en WOW64: {isWow64}");
                    }
                }
                
                // Verificar la arquitectura del ensamblado cargado
                Assembly pdfiumAssembly = null;
                try
                {
                    pdfiumAssembly = Assembly.Load("PdfiumViewer");
                    if (pdfiumAssembly != null)
                    {
                        string location = pdfiumAssembly.Location;
                        Console.WriteLine($"PdfiumViewer cargado desde: {location}");
                        
                        // Verificar si la DLL nativa ha sido cargada
                        IntPtr pdfiumModule = GetModuleHandle("pdfium.dll");
                        Console.WriteLine($"¿Módulo pdfium.dll cargado? {(pdfiumModule != IntPtr.Zero ? "Sí" : "No")}");
                        
                        if (pdfiumModule == IntPtr.Zero)
                        {
                            // Intentar encontrar la DLL correcta basada en la arquitectura
                            string binPath = AppDomain.CurrentDomain.BaseDirectory;
                            string archFolder = is64BitProcess ? "x64" : "x86";
                            string pdfiumDllPath = Path.Combine(binPath, archFolder, "pdfium.dll");
                            
                            if (File.Exists(pdfiumDllPath))
                            {
                                Console.WriteLine($"Se encontró la DLL correspondiente en: {pdfiumDllPath}");
                            }
                            else
                            {
                                // Si no se encuentra en la carpeta específica, verificar en el directorio raíz
                                pdfiumDllPath = Path.Combine(binPath, "pdfium.dll");
                                if (File.Exists(pdfiumDllPath))
                                {
                                    Console.WriteLine($"Se encontró la DLL en el directorio raíz: {pdfiumDllPath}");
                                }
                                else
                                {
                                    Console.WriteLine("¡ADVERTENCIA! No se encontró pdfium.dll en ninguna ubicación esperada");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cargar el ensamblado PdfiumViewer: {ex.Message}");
                }
                
                // Comprobar referencias a pdfium.dll en el directorio actual
                try
                {
                    string[] dlls = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "pdfium*.dll", SearchOption.AllDirectories);
                    if (dlls.Length > 0)
                    {
                        Console.WriteLine("DLLs de pdfium encontradas:");
                        foreach (string dll in dlls)
                        {
                            // Verificar si la DLL es de 32 o 64 bits
                            string architecture = GetDllArchitecture(dll);
                            Console.WriteLine($"- {dll} ({architecture})");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron DLLs de pdfium en el directorio actual");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al buscar DLLs: {ex.Message}");
                }
                
                // Recomendaciones basadas en verificaciones
                if (is64BitProcess)
                {
                    Console.WriteLine("RECOMENDACIÓN: Asegúrate de que estás usando la versión x64 de pdfium.dll");
                }
                else
                {
                    Console.WriteLine("RECOMENDACIÓN: Asegúrate de que estás usando la versión x86 de pdfium.dll");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar arquitectura: {ex.Message}");
            }
        }
        
        private static string GetDllArchitecture(string dllPath)
        {
            try
            {
                // Leer los primeros bytes del archivo para determinar la arquitectura
                using (FileStream fs = new FileStream(dllPath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[4096]; // Leer los primeros 4KB
                    fs.Read(buffer, 0, buffer.Length);
                    
                    // Verificar el encabezado PE
                    if (buffer[0] == 'M' && buffer[1] == 'Z')
                    {
                        // Obtener el desplazamiento del encabezado PE
                        int peOffset = BitConverter.ToInt32(buffer, 60);
                        
                        // Verificar si es un encabezado PE válido
                        if (peOffset < buffer.Length - 4)
                        {
                            // Verificar la firma PE
                            if (buffer[peOffset] == 'P' && buffer[peOffset + 1] == 'E' && 
                                buffer[peOffset + 2] == 0 && buffer[peOffset + 3] == 0)
                            {
                                // Obtener la información de la máquina
                                ushort machine = BitConverter.ToUInt16(buffer, peOffset + 4);
                                
                                switch (machine)
                                {
                                    case 0x014c: // IMAGE_FILE_MACHINE_I386
                                        return "x86 (32 bits)";
                                    case 0x8664: // IMAGE_FILE_MACHINE_AMD64
                                        return "x64 (64 bits)";
                                    default:
                                        return $"Desconocido (0x{machine:X4})";
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                // Ignora errores
            }
            
            return "No se pudo determinar";
        }
    }
} 
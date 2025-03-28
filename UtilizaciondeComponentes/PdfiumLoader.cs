using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace UtilizaciondeComponentes
{
    /// <summary>
    /// Utility class for dynamically loading the correct PdfiumViewer native library
    /// based on the current process architecture.
    /// </summary>
    public static class PdfiumLoader
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string libname);

        private static bool _initialized = false;

        static PdfiumLoader()
        {
            // Set up assembly resolve event to handle native DLL loading
            AppDomain.CurrentDomain.AssemblyResolve += OnAssemblyResolve;
        }

        /// <summary>
        /// Call this method before using any PdfiumViewer functionality
        /// to ensure the correct native library is loaded.
        /// </summary>
        public static void Initialize()
        {
            if (_initialized)
                return;

            try
            {
                // Importante: Asegurar que el proceso actual sea de la misma arquitectura que la biblioteca
                string processArchitecture = Environment.Is64BitProcess ? "x64" : "x86";
                Console.WriteLine($"Proceso actual: {processArchitecture}");

                // Ruta a la carpeta bin
                string binFolder = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine($"Directorio base: {binFolder}");

                // Ruta a la DLL de pdfium para la arquitectura apropiada
                string pdfiumPath = Path.Combine(binFolder, processArchitecture, "pdfium.dll");
                Console.WriteLine($"Buscando pdfium.dll en: {pdfiumPath}");

                // Si la DLL no existe en la ruta específica de la arquitectura, buscar en el directorio raíz
                if (!File.Exists(pdfiumPath))
                {
                    Console.WriteLine($"No se encontró pdfium.dll en {pdfiumPath}");
                    pdfiumPath = Path.Combine(binFolder, "pdfium.dll");
                    Console.WriteLine($"Buscando en directorio raíz: {pdfiumPath}");

                    // Si tampoco existe en el directorio raíz, intentar copiarla desde los paquetes
                    if (!File.Exists(pdfiumPath))
                    {
                        Console.WriteLine("No se encontró pdfium.dll en el directorio raíz");
                        TryCopyPdfiumFromPackages(processArchitecture, pdfiumPath);
                    }
                }

                // Si la DLL existe, establecer el directorio y cargarla explícitamente
                if (File.Exists(pdfiumPath))
                {
                    string pdfiumFolder = Path.GetDirectoryName(pdfiumPath);
                    Console.WriteLine($"Estableciendo directorio DLL: {pdfiumFolder}");
                    
                    // Configurar el directorio de búsqueda de DLL
                    SetDllDirectory(pdfiumFolder);
                    
                    // Cargar la biblioteca explícitamente
                    Console.WriteLine($"Cargando pdfium.dll desde {pdfiumPath}");
                    IntPtr handle = LoadLibrary(pdfiumPath);
                    
                    if (handle == IntPtr.Zero)
                    {
                        int errorCode = Marshal.GetLastWin32Error();
                        Console.WriteLine($"Error al cargar biblioteca. Código: {errorCode}");
                        
                        // Intentar buscar más información sobre el error
                        string errorMessage = new System.ComponentModel.Win32Exception(errorCode).Message;
                        Console.WriteLine($"Mensaje de error: {errorMessage}");
                    }
                    else
                    {
                        Console.WriteLine("pdfium.dll cargada con éxito");
                        _initialized = true;
                    }
                }
                else
                {
                    // Último intento: buscar la DLL en algún lugar del PATH del sistema
                    Console.WriteLine("Intentando cargar pdfium.dll desde el PATH del sistema");
                    try
                    {
                        string tempPath = FindFileInPath("pdfium.dll");
                        if (!string.IsNullOrEmpty(tempPath))
                        {
                            Console.WriteLine($"Encontrada en: {tempPath}");
                            IntPtr handle = LoadLibrary(tempPath);
                            if (handle != IntPtr.Zero)
                            {
                                Console.WriteLine("pdfium.dll cargada desde PATH con éxito");
                                _initialized = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR: No se encontró pdfium.dll en ninguna ubicación");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error buscando en PATH: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inicializando PdfiumLoader: {ex}");
            }
        }
        
        private static string FindFileInPath(string fileName)
        {
            string path = Environment.GetEnvironmentVariable("PATH");
            if (string.IsNullOrEmpty(path))
                return null;

            foreach (string dir in path.Split(Path.PathSeparator))
            {
                try
                {
                    string fullPath = Path.Combine(dir, fileName);
                    if (File.Exists(fullPath))
                        return fullPath;
                }
                catch { }
            }
            return null;
        }

        private static void TryCopyPdfiumFromPackages(string architectureFolder, string destPath)
        {
            try
            {
                Console.WriteLine($"Intentando copiar pdfium.dll desde carpeta de paquetes");
                
                // Ruta base del proyecto
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                
                // Intentar diferentes rutas para encontrar el paquete
                string[] possiblePaths = new string[]
                {
                    // Ruta relativa típica
                    Path.Combine(baseDir, "..", "..", "..", "packages"),
                    // Ruta absoluta basada en el directorio actual
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..", "..", "packages"),
                    // Ruta absoluta directa
                    @"C:\Users\Admin\Desktop\UtilizaciondeComponentes\packages"
                };
                
                string packageRoot = null;
                foreach (string path in possiblePaths)
                {
                    if (Directory.Exists(path))
                    {
                        packageRoot = path;
                        Console.WriteLine($"Directorio de paquetes encontrado: {packageRoot}");
                        break;
                    }
                }
                
                if (packageRoot == null)
                {
                    Console.WriteLine("No se pudo encontrar la carpeta de paquetes");
                    return;
                }
                
                string sourceFile = null;
                
                if (architectureFolder == "x64")
                {
                    // Buscar versión x64
                    string[] possibleX64Paths = new string[]
                    {
                        Path.Combine(packageRoot, "PdfiumViewer.Native.x86_64.v8-xfa.2018.4.8.256", "Build", "x64", "pdfium.dll"),
                        Path.Combine(packageRoot, "PdfiumViewer.Native.x86_64.v8-xfa.2018.4.8.256", "content", "x64", "pdfium.dll"),
                        Path.Combine(packageRoot, "PdfiumViewer.Native.x86_64.v8-xfa.2018.4.8.256", "x64", "pdfium.dll")
                    };
                    
                    foreach (string path in possibleX64Paths)
                    {
                        if (File.Exists(path))
                        {
                            sourceFile = path;
                            Console.WriteLine($"Encontrado archivo de origen x64: {sourceFile}");
                            break;
                        }
                    }
                }
                else
                {
                    // Buscar versión x86
                    string[] possibleX86Paths = new string[]
                    {
                        Path.Combine(packageRoot, "PdfiumViewer.Native.x86.v8-xfa.2018.4.8.256", "Build", "x86", "pdfium.dll"),
                        Path.Combine(packageRoot, "PdfiumViewer.Native.x86.v8-xfa.2018.4.8.256", "content", "x86", "pdfium.dll"),
                        Path.Combine(packageRoot, "PdfiumViewer.Native.x86.v8-xfa.2018.4.8.256", "x86", "pdfium.dll")
                    };
                    
                    foreach (string path in possibleX86Paths)
                    {
                        if (File.Exists(path))
                        {
                            sourceFile = path;
                            Console.WriteLine($"Encontrado archivo de origen x86: {sourceFile}");
                            break;
                        }
                    }
                    
                    // Búsqueda adicional si no se encuentra
                    if (sourceFile == null)
                    {
                        try
                        {
                            string[] potentialPackages = Directory.GetDirectories(packageRoot, "PdfiumViewer.Native.x86*");
                            foreach (string packageDir in potentialPackages)
                            {
                                string[] possibleLocations = new string[]
                                {
                                    Path.Combine(packageDir, "Build", "x86", "pdfium.dll"),
                                    Path.Combine(packageDir, "content", "x86", "pdfium.dll"),
                                    Path.Combine(packageDir, "x86", "pdfium.dll")
                                };
                                
                                foreach (string location in possibleLocations)
                                {
                                    if (File.Exists(location))
                                    {
                                        sourceFile = location;
                                        Console.WriteLine($"Encontrado en búsqueda adicional: {sourceFile}");
                                        break;
                                    }
                                }
                                
                                if (sourceFile != null)
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error en búsqueda adicional: {ex.Message}");
                        }
                    }
                }
                
                if (sourceFile != null)
                {
                    // Crear directorio si no existe
                    string destDir = Path.GetDirectoryName(destPath);
                    if (!Directory.Exists(destDir))
                    {
                        Directory.CreateDirectory(destDir);
                        Console.WriteLine($"Creado directorio: {destDir}");
                    }
                    
                    File.Copy(sourceFile, destPath, true);
                    Console.WriteLine($"Copiado pdfium.dll desde {sourceFile} a {destPath}");
                }
                else
                {
                    Console.WriteLine($"No se pudo encontrar pdfium.dll para {architectureFolder} en los paquetes");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error copiando pdfium.dll: {ex.Message}");
            }
        }
        
        private static Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            // Solo nos interesa PdfiumViewer
            if (!args.Name.StartsWith("PdfiumViewer"))
                return null;
            
            return Assembly.GetAssembly(typeof(PdfiumViewer.PdfDocument));
        }
    }
}

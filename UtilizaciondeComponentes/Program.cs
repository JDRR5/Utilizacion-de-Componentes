using System;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using PdfiumViewer;

namespace UtilizaciondeComponentes
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // Establecer cultura invariante para evitar problemas de localización
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                
                // Activar el registro en archivo para diagnóstico
                ConfigureLogging();
                
                Log("Iniciando aplicación...");
                Log($"Directorio actual: {AppDomain.CurrentDomain.BaseDirectory}");
                Log($"Plataforma: {(Environment.Is64BitProcess ? "x64" : "x86")}");
                
                // Verificar la arquitectura antes de inicializar
                PdfiumArchitectureHelper.VerifyArchitecture();
                
                // Inicializar pdfium y aplicar parches
                Log("Inicializando PdfiumViewer...");
                PdfiumLoader.Initialize();
                PdfiumResourceHandler.Initialize();
                PdfiumResourcePatcher.ApplyPatch();
                
                // Verificar si existen las bibliotecas nativas
                VerifyNativeLibraries();
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                try
                {
                    // Intentar crear una instancia de prueba
                    using (var document = PdfDocument.Load("sample-local-pdf.pdf"))
                    {
                        Log("Prueba de carga de documento exitosa");
                    }
                }
                catch (Exception ex)
                {
                    Log($"Prueba fallida: {ex.Message}");
                    // Continuar a pesar del error de prueba
                }
                
                Application.Run(new Frm_InicioMenu());
            }
            catch (Exception ex)
            {
                Log($"Error al iniciar la aplicación: {ex.ToString()}");
                MessageBox.Show($"Error al iniciar la aplicación: {ex.Message}\n\nConsulte el archivo log.txt para más detalles.", 
                    "Error de inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void VerifyNativeLibraries()
        {
            string binDir = AppDomain.CurrentDomain.BaseDirectory;
            string architecture = Environment.Is64BitProcess ? "x64" : "x86";
            
            // Verificar si existe la carpeta de arquitectura
            string archDir = Path.Combine(binDir, architecture);
            if (!Directory.Exists(archDir))
            {
                Log($"Creando directorio para {architecture}...");
                Directory.CreateDirectory(archDir);
            }
            
            // Verificar si existe pdfium.dll en la carpeta de arquitectura
            string pdfiumPath = Path.Combine(archDir, "pdfium.dll");
            if (!File.Exists(pdfiumPath))
            {
                Log($"No se encontró pdfium.dll en {pdfiumPath}");
                
                // Comprobar si existe en el directorio raíz
                string rootPdfiumPath = Path.Combine(binDir, "pdfium.dll");
                if (File.Exists(rootPdfiumPath))
                {
                    Log($"Copiando pdfium.dll desde {rootPdfiumPath} a {pdfiumPath}");
                    try
                    {
                        File.Copy(rootPdfiumPath, pdfiumPath, true);
                    }
                    catch (Exception ex)
                    {
                        Log($"Error al copiar pdfium.dll: {ex.Message}");
                    }
                }
                else
                {
                    Log("ADVERTENCIA: No se encontró pdfium.dll en ninguna ubicación");
                }
            }
        }
        
        private static void ConfigureLogging()
        {
            try
            {
                // Reorientar la salida de la consola a un archivo de registro
                string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
                File.WriteAllText(logPath, $"Log iniciado: {DateTime.Now}\n");
                Console.SetOut(new StreamWriter(logPath, true) { AutoFlush = true });
            }
            catch
            {
                // Ignorar errores de configuración de registro
            }
        }
        
        private static void Log(string message)
        {
            try
            {
                Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
            }
            catch
            {
                // Ignorar errores de registro
            }
        }
    }
}

using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;

namespace UtilizaciondeComponentes
{
    public static class PdfiumResourceHandler
    {
        private static ResourceManager _resourceManager;
        private static bool _hasInitializedIcons = false;
        private static Bitmap _shadeBorder_N = null;
        private static Bitmap _shadeBorder_NE = null;
        private static Bitmap _shadeBorder_E = null;
        private static Bitmap _shadeBorder_SE = null;
        private static Bitmap _shadeBorder_S = null;
        private static Bitmap _shadeBorder_SW = null;
        private static Bitmap _shadeBorder_W = null;
        private static Bitmap _shadeBorder_NW = null;

        static PdfiumResourceHandler()
        {
            // Inicializar el administrador de recursos
            try
            {
                Assembly assembly = Assembly.GetAssembly(typeof(PdfiumViewer.PdfDocument));
                _resourceManager = new ResourceManager("PdfiumViewer.Properties.Resources", assembly);
                
                // Inicializar los iconos
                InitializeIcons();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inicializando ResourceManager: {ex.Message}");
            }
        }

        private static void InitializeIcons()
        {
            if (_hasInitializedIcons)
                return;

            try
            {
                // Cargar los íconos desde los recursos embebidos de PdfiumViewer
                Assembly assembly = Assembly.GetAssembly(typeof(PdfiumViewer.PdfDocument));
                
                _shadeBorder_N = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_N");
                _shadeBorder_NE = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_NE");
                _shadeBorder_E = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_E");
                _shadeBorder_SE = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_SE");
                _shadeBorder_S = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_S");
                _shadeBorder_SW = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_SW");
                _shadeBorder_W = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_W");
                _shadeBorder_NW = LoadImageResource(assembly, "PdfiumViewer.Properties.Resources", "ShadeBorder_NW");

                _hasInitializedIcons = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al inicializar íconos: {ex.Message}");
            }
        }

        private static Bitmap LoadImageResource(Assembly assembly, string resourceNamespace, string resourceName)
        {
            try
            {
                // Intentar cargar recurso desde el ensamblado
                string fullResourceName = $"{resourceNamespace}.{resourceName}";
                using (Stream stream = assembly.GetManifestResourceStream(fullResourceName))
                {
                    if (stream != null)
                    {
                        return new Bitmap(stream);
                    }
                }

                // Crear una imagen vacía como fallback
                return new Bitmap(16, 16);
            }
            catch
            {
                // Fallback bitmap si no se puede cargar
                return new Bitmap(16, 16);
            }
        }

        public static void Initialize()
        {
            // Registrar el controlador de resolución de recursos
            AppDomain.CurrentDomain.ResourceResolve += OnResourceResolve;
        }

        private static Assembly OnResourceResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.Contains("PdfiumViewer.resources"))
            {
                // Devolver la misma asamblea de PdfiumViewer
                return Assembly.GetAssembly(typeof(PdfiumViewer.PdfDocument));
            }
            
            return null;
        }

        // Método auxiliar para obtener recursos específicos si es necesario
        public static object GetResource(string resourceName)
        {
            try
            {
                // Si es un recurso de imagen específico, devolver nuestro propio recurso
                switch (resourceName)
                {
                    case "ShadeBorder_N":
                        return _shadeBorder_N;
                    case "ShadeBorder_NE":
                        return _shadeBorder_NE;
                    case "ShadeBorder_E":
                        return _shadeBorder_E;
                    case "ShadeBorder_SE":
                        return _shadeBorder_SE;
                    case "ShadeBorder_S":
                        return _shadeBorder_S;
                    case "ShadeBorder_SW":
                        return _shadeBorder_SW;
                    case "ShadeBorder_W":
                        return _shadeBorder_W;
                    case "ShadeBorder_NW":
                        return _shadeBorder_NW;
                }

                if (_resourceManager != null)
                {
                    return _resourceManager.GetObject(resourceName, CultureInfo.CurrentUICulture);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener recurso {resourceName}: {ex.Message}");
            }
            
            return null;
        }
    }
} 
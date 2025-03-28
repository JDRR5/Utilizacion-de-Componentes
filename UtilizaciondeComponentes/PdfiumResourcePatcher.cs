using System;
using System.Reflection;
using System.Resources;

namespace UtilizaciondeComponentes
{
    public static class PdfiumResourcePatcher
    {
        private static bool _isPatched = false;

        public static void ApplyPatch()
        {
            if (_isPatched)
                return;

            try
            {
                // Obtener el tipo de la clase Resources de PdfiumViewer
                Type resourcesType = Type.GetType("PdfiumViewer.Properties.Resources, PdfiumViewer");
                if (resourcesType == null)
                {
                    Assembly pdfiumAssembly = Assembly.GetAssembly(typeof(PdfiumViewer.PdfDocument));
                    resourcesType = pdfiumAssembly.GetType("PdfiumViewer.Properties.Resources");
                }

                if (resourcesType != null)
                {
                    // Obtener el campo resourceMan
                    FieldInfo resourceManField = resourcesType.GetField("resourceMan", 
                        BindingFlags.Static | BindingFlags.NonPublic);

                    if (resourceManField != null)
                    {
                        // Obtener el ResourceManager actual
                        ResourceManager currentManager = 
                            resourceManField.GetValue(null) as ResourceManager;

                        if (currentManager == null)
                        {
                            // Crear un nuevo ResourceManager que no fallará
                            ResourceManager newManager = 
                                new ResourceManager("PdfiumViewer.Properties.Resources", 
                                    typeof(PdfiumViewer.PdfDocument).Assembly);

                            // Establecer el nuevo ResourceManager en el campo
                            resourceManField.SetValue(null, newManager);

                            Console.WriteLine("Pdfium ResourceManager parcheado correctamente");
                        }
                    }
                }

                _isPatched = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al parchear recursos de PdfiumViewer: {ex.Message}");
            }
        }
    }
} 
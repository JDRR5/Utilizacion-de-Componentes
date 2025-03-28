using System;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer;

namespace UtilizaciondeComponentes
{
    public partial class frmPDF : Form
    {
        private PdfDocument currentDocument = null;
        private string currentFilePath = string.Empty;

        public frmPDF()
        {
            // Ensure PdfiumViewer is properly initialized before we load any components
            PdfiumLoader.Initialize();
            
            // Inicializar el manejador de recursos
            PdfiumResourceHandler.Initialize();
            
            InitializeComponent();
        }

        private void PdfViewerForm_Load(object sender, EventArgs e)
        {

            UpdateNavigationControls();
        }

        private void PdfViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (currentDocument != null)
            {
                currentDocument.Dispose();
                currentDocument = null;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    openFileDialog.Title = "Open PDF File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        OpenPdfFile(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening PDF file: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenPdfFile(string filePath)
        {
            try
            {

                if (currentDocument != null)
                {
                    currentDocument.Dispose();
                    currentDocument = null;
                }


                currentDocument = PdfDocument.Load(filePath);
                pdfViewer.Document = currentDocument;

                currentFilePath = filePath;
                lblNombre.Text = Path.GetFileName(filePath);


                numPaginaActual.Minimum = 1;
                numPaginaActual.Maximum = currentDocument.PageCount;
                numPaginaActual.Value = 1;
                lblTotalPaginas.Text = $"of {currentDocument.PageCount}";

                UpdateNavigationControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PDF: " + ex.Message, "PDF Viewer Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentDocument != null && pdfViewer.Renderer.Page > 0)
            {
                pdfViewer.Renderer.Page--;
                numPaginaActual.Value = pdfViewer.Renderer.Page + 1;
                UpdateNavigationControls();
            }
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (currentDocument != null && pdfViewer.Renderer.Page < currentDocument.PageCount - 1)
            {
                pdfViewer.Renderer.Page++;
                numPaginaActual.Value = pdfViewer.Renderer.Page + 1;
                UpdateNavigationControls();
            }
        }

        private void NumericCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            if (currentDocument != null)
            {
                pdfViewer.Renderer.Page = (int)numPaginaActual.Value - 1;
                UpdateNavigationControls();
            }
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            if (currentDocument != null)
            {
                pdfViewer.Renderer.ZoomIn();
            }
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            if (currentDocument != null)
            {
                pdfViewer.Renderer.ZoomOut();
            }
        }

        private void BtnFitPage_Click(object sender, EventArgs e)
        {
            if (currentDocument != null)
            {
                pdfViewer.ZoomMode = PdfViewerZoomMode.FitHeight;
            }
        }

        private void BtnFitWidth_Click(object sender, EventArgs e)
        {
            if (currentDocument != null)
            {
                pdfViewer.ZoomMode = PdfViewerZoomMode.FitWidth;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateNavigationControls()
        {
            bool hasDocument = currentDocument != null;

            btnPrevio.Enabled = hasDocument && pdfViewer.Renderer.Page > 0;
            btnSiguiente.Enabled = hasDocument && pdfViewer.Renderer.Page < (currentDocument?.PageCount ?? 0) - 1;

            numPaginaActual.Enabled = hasDocument;
            btnHacerZoom.Enabled = hasDocument;
            btnZoomMenos.Enabled = hasDocument;
            btnAjustarPagina.Enabled = hasDocument;
            btnAncho.Enabled = hasDocument;
        }
    }
}

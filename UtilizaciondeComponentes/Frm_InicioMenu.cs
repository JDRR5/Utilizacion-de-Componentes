using System;
using System.Drawing;
using System.Windows.Forms;

namespace UtilizaciondeComponentes
{
    public partial class Frm_InicioMenu : Form
    {
        public Frm_InicioMenu()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void BtnMediaPlayer_Click(object sender, EventArgs e)
        {
            using (Frm_MediaPlayer mediaPlayerForm = new Frm_MediaPlayer())
            {
                mediaPlayerForm.FormBorderStyle = FormBorderStyle.Sizable;
                mediaPlayerForm.WindowState = FormWindowState.Normal;
                mediaPlayerForm.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                mediaPlayerForm.ShowDialog();
                this.Show();
            }
        }

        private void BtnPdfViewer_Click(object sender, EventArgs e)
        {
            using (frmPDF pdfViewerForm = new frmPDF())
            {
                pdfViewerForm.FormBorderStyle = FormBorderStyle.Sizable;
                pdfViewerForm.WindowState = FormWindowState.Normal;
                pdfViewerForm.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                pdfViewerForm.ShowDialog();
                this.Show();
            }
        }

        private void BtnWebBrowser_Click(object sender, EventArgs e)
        {
            using (Frm_Navegador webBrowserForm = new Frm_Navegador())
            {
                webBrowserForm.FormBorderStyle = FormBorderStyle.Sizable;
                webBrowserForm.WindowState = FormWindowState.Normal;
                webBrowserForm.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                webBrowserForm.ShowDialog();
                this.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "Confirmar Salida",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Frm_InicioMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

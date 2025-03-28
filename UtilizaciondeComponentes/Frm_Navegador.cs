using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace UtilizaciondeComponentes
{
    public partial class Frm_Navegador : Form
    {
        public Frm_Navegador()
        {
            InitializeComponent();
        }

        private async void WebBrowserForm_Load(object sender, EventArgs e)
        {
            // Inicializar el entorno para WebView2
            await webView.EnsureCoreWebView2Async(null);

            // Configurar eventos del navegador
            webView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            webView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
            webView.CoreWebView2.ProcessFailed += CoreWebView2_ProcessFailed;

            // Establecer URL inicial
            txtUrl.Text = "https://www.google.com";
            
            // Navegar a la URL
            webView.CoreWebView2.Navigate(txtUrl.Text);
        }

        private void CoreWebView2_NavigationStarting(object _, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            lblEstado.Text = "Cargando...";
        }

        private void CoreWebView2_NavigationCompleted(object _, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Actualizar título de la ventana
            if (!string.IsNullOrEmpty(webView.CoreWebView2.DocumentTitle))
            {
                this.Text = "Media Explorer - Web Browser - " + webView.CoreWebView2.DocumentTitle;
            }

            // Actualizar la URL en la barra de dirección
            txtUrl.Text = webView.Source.ToString();

            // Actualizar estado de los botones de navegación
            UpdateNavigationButtons();
            
            // Actualizar estado
            lblEstado.Text = e.IsSuccess ? "Listo" : "Error al cargar la página";
        }

        private void CoreWebView2_ProcessFailed(object _, CoreWebView2ProcessFailedEventArgs e)
        {
            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            lblEstado.Text = "Error de Navegación";
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            NavigateToUrl();
        }

        private void TxtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si se presiona Enter, navegar a la URL
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NavigateToUrl();
            }
        }

        private void NavigateToUrl()
        {
            try
            {
                string url = txtUrl.Text.Trim();

                // Verificar si la URL incluye el protocolo, de lo contrario agregarlo
                if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                    !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase) &&
                    !url.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
                {
                    url = "https://" + url;  // Usar HTTPS como predeterminado en lugar de HTTP
                    txtUrl.Text = url;
                }

                // Navegar a la URL
                webView.CoreWebView2.Navigate(url);

                // Actualizar el estado
                lblEstado.Text = "Cargando...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al navegar a la URL: " + ex.Message,
                    "Error de navegación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                // Si no se puede retroceder más, cerrar este formulario para volver al menú principal
                this.Close();
            }
        }

        private void BtnNavBack_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void BtnNavForward_Click(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            webView.Reload();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.google.com");
        }

        private void UpdateNavigationButtons()
        {
            // Actualizar estado de los botones de navegación
            btnNavRegreso.Enabled = webView.CanGoBack;
            btnNavAdelante.Enabled = webView.CanGoForward;

            // Actualizar estado
            lblEstado.Text = "Listo";
        }
    }
}

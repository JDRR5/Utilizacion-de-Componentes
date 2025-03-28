namespace UtilizaciondeComponentes
{
    partial class Frm_InicioMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InicioMenu));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnMediaPlayer = new System.Windows.Forms.Button();
            this.btnPdfLector = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reproductor de Medios";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(382, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 56);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnMediaPlayer);
            this.pnlContent.Controls.Add(this.btnPdfLector);
            this.pnlContent.Controls.Add(this.btnNavegador);
            this.pnlContent.Controls.Add(this.btnSalir);
            this.pnlContent.Controls.Add(this.lblTitulo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(900, 450);
            this.pnlContent.TabIndex = 7;
            // 
            // btnMediaPlayer
            // 
            this.btnMediaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaPlayer.Location = new System.Drawing.Point(338, 22);
            this.btnMediaPlayer.Name = "btnMediaPlayer";
            this.btnMediaPlayer.Size = new System.Drawing.Size(241, 54);
            this.btnMediaPlayer.TabIndex = 1;
            this.btnMediaPlayer.Text = "Media Player";
            this.btnMediaPlayer.UseVisualStyleBackColor = true;
            this.btnMediaPlayer.Click += new System.EventHandler(this.BtnMediaPlayer_Click);
            // 
            // btnPdfLector
            // 
            this.btnPdfLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdfLector.Location = new System.Drawing.Point(338, 119);
            this.btnPdfLector.Name = "btnPdfLector";
            this.btnPdfLector.Size = new System.Drawing.Size(241, 57);
            this.btnPdfLector.TabIndex = 2;
            this.btnPdfLector.Text = "Lector PDF";
            this.btnPdfLector.UseVisualStyleBackColor = true;
            this.btnPdfLector.Click += new System.EventHandler(this.BtnPdfViewer_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegador.Location = new System.Drawing.Point(338, 215);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(241, 57);
            this.btnNavegador.TabIndex = 3;
            this.btnNavegador.Text = "Navegador";
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.BtnWebBrowser_Click);
            // 
            // Frm_InicioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pnlContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_InicioMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor de Medios";
            this.Load += new System.EventHandler(this.Frm_InicioMenu_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Button btnPdfLector;
        private System.Windows.Forms.Button btnMediaPlayer;
    }
}

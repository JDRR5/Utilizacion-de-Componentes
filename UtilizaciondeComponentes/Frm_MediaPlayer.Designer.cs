namespace UtilizaciondeComponentes
{
    partial class Frm_MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MediaPlayer));
            this.lblMediaPlayer = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.trckBar_Volumen = new System.Windows.Forms.TrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.btnPantallaCompleta = new System.Windows.Forms.Button();
            this.btnMutear = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBar_Volumen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMediaPlayer
            // 
            this.lblMediaPlayer.AutoSize = true;
            this.lblMediaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaPlayer.Location = new System.Drawing.Point(307, 10);
            this.lblMediaPlayer.Name = "lblMediaPlayer";
            this.lblMediaPlayer.Size = new System.Drawing.Size(178, 20);
            this.lblMediaPlayer.TabIndex = 2;
            this.lblMediaPlayer.Text = "Reproductor Multimedia";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 28);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(12, 46);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(776, 375);
            this.mediaPlayer.TabIndex = 1;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            this.mediaPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.MediaPlayer_MediaError);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(93, 426);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(430, 23);
            this.lblNombreArchivo.TabIndex = 7;
            this.lblNombreArchivo.Text = "No hay archivo seleccionado";
            this.lblNombreArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trckBar_Volumen
            // 
            this.trckBar_Volumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trckBar_Volumen.Location = new System.Drawing.Point(627, 451);
            this.trckBar_Volumen.Maximum = 100;
            this.trckBar_Volumen.Name = "trckBar_Volumen";
            this.trckBar_Volumen.Size = new System.Drawing.Size(161, 45);
            this.trckBar_Volumen.TabIndex = 6;
            this.trckBar_Volumen.TickFrequency = 10;
            this.trckBar_Volumen.Value = 50;
            this.trckBar_Volumen.Scroll += new System.EventHandler(this.TrackBarVolume_Scroll);
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(627, 435);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(74, 13);
            this.lblVolumen.TabIndex = 5;
            this.lblVolumen.Text = "Volumen: 50%";
            // 
            // btnPantallaCompleta
            // 
            this.btnPantallaCompleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPantallaCompleta.Enabled = false;
            this.btnPantallaCompleta.Location = new System.Drawing.Point(529, 426);
            this.btnPantallaCompleta.Name = "btnPantallaCompleta";
            this.btnPantallaCompleta.Size = new System.Drawing.Size(92, 55);
            this.btnPantallaCompleta.TabIndex = 4;
            this.btnPantallaCompleta.Text = "Pantalla Completa";
            this.btnPantallaCompleta.UseVisualStyleBackColor = true;
            this.btnPantallaCompleta.Click += new System.EventHandler(this.BtnFullScreen_Click);
            // 
            // btnMutear
            // 
            this.btnMutear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMutear.Location = new System.Drawing.Point(341, 458);
            this.btnMutear.Name = "btnMutear";
            this.btnMutear.Size = new System.Drawing.Size(75, 23);
            this.btnMutear.TabIndex = 3;
            this.btnMutear.Text = "Silenciar";
            this.btnMutear.UseVisualStyleBackColor = true;
            this.btnMutear.Click += new System.EventHandler(this.BtnMute_Click);
            // 
            // btnParar
            // 
            this.btnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(259, 458);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Detener";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(176, 458);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Reproducir";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrir.Location = new System.Drawing.Point(12, 426);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // Frm_MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.trckBar_Volumen);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.btnPantallaCompleta);
            this.Controls.Add(this.btnMutear);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 500);
            this.Name = "Frm_MediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor Multimedia";
            this.Load += new System.EventHandler(this.MediaPlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBar_Volumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TrackBar trckBar_Volumen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Button btnPantallaCompleta;
        private System.Windows.Forms.Button btnMutear;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblMediaPlayer;
    }
}

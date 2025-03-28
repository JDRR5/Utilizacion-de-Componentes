namespace UtilizaciondeComponentes
{
    partial class frmPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDF));
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.lblPDF = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.pnlAbajo = new System.Windows.Forms.Panel();
            this.pnlBajar = new System.Windows.Forms.Panel();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.numPaginaActual = new System.Windows.Forms.NumericUpDown();
            this.btnAncho = new System.Windows.Forms.Button();
            this.btnAjustarPagina = new System.Windows.Forms.Button();
            this.btnZoomMenos = new System.Windows.Forms.Button();
            this.btnHacerZoom = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrevio = new System.Windows.Forms.Button();
            this.btnAbrirPDF = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlArriba.SuspendLayout();
            this.pnlAbajo.SuspendLayout();
            this.pnlBajar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.SystemColors.Control;
            this.pnlArriba.Controls.Add(this.lblPDF);
            this.pnlArriba.Controls.Add(this.btnRegresar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(800, 50);
            this.pnlArriba.TabIndex = 0;
            // 
            // lblPDF
            // 
            this.lblPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPDF.Location = new System.Drawing.Point(80, 0);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(720, 50);
            this.lblPDF.TabIndex = 1;
            this.lblPDF.Text = "Lector PDF";
            this.lblPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.Location = new System.Drawing.Point(0, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 50);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "< Volver";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 50);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(800, 361);
            this.pdfViewer.TabIndex = 1;
            // 
            // pnlAbajo
            // 
            this.pnlAbajo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAbajo.Controls.Add(this.pnlBajar);
            this.pnlAbajo.Controls.Add(this.lblNombre);
            this.pnlAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAbajo.Location = new System.Drawing.Point(0, 411);
            this.pnlAbajo.Name = "pnlAbajo";
            this.pnlAbajo.Size = new System.Drawing.Size(800, 50);
            this.pnlAbajo.TabIndex = 2;
            // 
            // pnlBajar
            // 
            this.pnlBajar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBajar.Controls.Add(this.lblTotalPaginas);
            this.pnlBajar.Controls.Add(this.numPaginaActual);
            this.pnlBajar.Controls.Add(this.btnAncho);
            this.pnlBajar.Controls.Add(this.btnAjustarPagina);
            this.pnlBajar.Controls.Add(this.btnZoomMenos);
            this.pnlBajar.Controls.Add(this.btnHacerZoom);
            this.pnlBajar.Controls.Add(this.btnSiguiente);
            this.pnlBajar.Controls.Add(this.btnPrevio);
            this.pnlBajar.Controls.Add(this.btnAbrirPDF);
            this.pnlBajar.Location = new System.Drawing.Point(293, 5);
            this.pnlBajar.Name = "pnlBajar";
            this.pnlBajar.Size = new System.Drawing.Size(497, 40);
            this.pnlBajar.TabIndex = 6;
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.Location = new System.Drawing.Point(219, 12);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(27, 17);
            this.lblTotalPaginas.TabIndex = 8;
            this.lblTotalPaginas.Text = "de ";
            // 
            // numPaginaActual
            // 
            this.numPaginaActual.Enabled = false;
            this.numPaginaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaginaActual.Location = new System.Drawing.Point(170, 8);
            this.numPaginaActual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPaginaActual.Name = "numPaginaActual";
            this.numPaginaActual.Size = new System.Drawing.Size(43, 25);
            this.numPaginaActual.TabIndex = 7;
            this.numPaginaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPaginaActual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPaginaActual.ValueChanged += new System.EventHandler(this.NumericCurrentPage_ValueChanged);
            // 
            // btnAncho
            // 
            this.btnAncho.BackColor = System.Drawing.SystemColors.Control;
            this.btnAncho.Enabled = false;
            this.btnAncho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAncho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAncho.Location = new System.Drawing.Point(444, 8);
            this.btnAncho.Name = "btnAncho";
            this.btnAncho.Size = new System.Drawing.Size(50, 25);
            this.btnAncho.TabIndex = 6;
            this.btnAncho.Text = "Ancho";
            this.btnAncho.UseVisualStyleBackColor = true;
            this.btnAncho.Click += new System.EventHandler(this.BtnFitWidth_Click);
            // 
            // btnAjustarPagina
            // 
            this.btnAjustarPagina.BackColor = System.Drawing.SystemColors.Control;
            this.btnAjustarPagina.Enabled = false;
            this.btnAjustarPagina.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAjustarPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustarPagina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjustarPagina.Location = new System.Drawing.Point(387, 8);
            this.btnAjustarPagina.Name = "btnAjustarPagina";
            this.btnAjustarPagina.Size = new System.Drawing.Size(51, 25);
            this.btnAjustarPagina.TabIndex = 5;
            this.btnAjustarPagina.Text = "Página";
            this.btnAjustarPagina.UseVisualStyleBackColor = true;
            this.btnAjustarPagina.Click += new System.EventHandler(this.BtnFitPage_Click);
            // 
            // btnZoomMenos
            // 
            this.btnZoomMenos.BackColor = System.Drawing.SystemColors.Control;
            this.btnZoomMenos.Enabled = false;
            this.btnZoomMenos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZoomMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomMenos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoomMenos.Location = new System.Drawing.Point(338, 8);
            this.btnZoomMenos.Name = "btnZoomMenos";
            this.btnZoomMenos.Size = new System.Drawing.Size(30, 25);
            this.btnZoomMenos.TabIndex = 4;
            this.btnZoomMenos.Text = "-";
            this.btnZoomMenos.UseVisualStyleBackColor = true;
            this.btnZoomMenos.Click += new System.EventHandler(this.BtnZoomOut_Click);
            // 
            // btnHacerZoom
            // 
            this.btnHacerZoom.BackColor = System.Drawing.SystemColors.Control;
            this.btnHacerZoom.Enabled = false;
            this.btnHacerZoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHacerZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerZoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHacerZoom.Location = new System.Drawing.Point(302, 8);
            this.btnHacerZoom.Name = "btnHacerZoom";
            this.btnHacerZoom.Size = new System.Drawing.Size(30, 25);
            this.btnHacerZoom.TabIndex = 3;
            this.btnHacerZoom.Text = "+";
            this.btnHacerZoom.UseVisualStyleBackColor = true;
            this.btnHacerZoom.Click += new System.EventHandler(this.BtnZoomIn_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSiguiente.Location = new System.Drawing.Point(254, 8);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(30, 25);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnPrevio
            // 
            this.btnPrevio.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevio.Enabled = false;
            this.btnPrevio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrevio.Location = new System.Drawing.Point(135, 8);
            this.btnPrevio.Name = "btnPrevio";
            this.btnPrevio.Size = new System.Drawing.Size(30, 25);
            this.btnPrevio.TabIndex = 1;
            this.btnPrevio.Text = "<";
            this.btnPrevio.UseVisualStyleBackColor = true;
            this.btnPrevio.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // btnAbrirPDF
            // 
            this.btnAbrirPDF.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbrirPDF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbrirPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPDF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirPDF.Location = new System.Drawing.Point(3, 3);
            this.btnAbrirPDF.Name = "btnAbrirPDF";
            this.btnAbrirPDF.Size = new System.Drawing.Size(75, 35);
            this.btnAbrirPDF.TabIndex = 0;
            this.btnAbrirPDF.Text = "Abrir";
            this.btnAbrirPDF.UseVisualStyleBackColor = true;
            this.btnAbrirPDF.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(275, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "No hay documento abierto";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.pnlAbajo);
            this.Controls.Add(this.pnlArriba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Explorer - Lector PDF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PdfViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.PdfViewerForm_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlAbajo.ResumeLayout(false);
            this.pnlBajar.ResumeLayout(false);
            this.pnlBajar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginaActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Button btnRegresar;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.Panel pnlAbajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlBajar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrevio;
        private System.Windows.Forms.Button btnAbrirPDF;
        private System.Windows.Forms.Button btnAncho;
        private System.Windows.Forms.Button btnAjustarPagina;
        private System.Windows.Forms.Button btnZoomMenos;
        private System.Windows.Forms.Button btnHacerZoom;
        private System.Windows.Forms.NumericUpDown numPaginaActual;
        private System.Windows.Forms.Label lblTotalPaginas;
    }
}

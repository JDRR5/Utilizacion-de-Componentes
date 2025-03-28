namespace UtilizaciondeComponentes
{
    partial class Frm_Navegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Navegador));
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNavRegreso = new System.Windows.Forms.Button();
            this.btnNavAdelante = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlToolbar.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolbar.Controls.Add(this.btnVolver);
            this.pnlToolbar.Controls.Add(this.btnNavRegreso);
            this.pnlToolbar.Controls.Add(this.btnNavAdelante);
            this.pnlToolbar.Controls.Add(this.btnRefrescar);
            this.pnlToolbar.Controls.Add(this.btnInicio);
            this.pnlToolbar.Controls.Add(this.txtUrl);
            this.pnlToolbar.Controls.Add(this.btnIr);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(800, 40);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(5, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(35, 25);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "X";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnNavRegreso
            // 
            this.btnNavRegreso.BackColor = System.Drawing.SystemColors.Control;
            this.btnNavRegreso.Enabled = false;
            this.btnNavRegreso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNavRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavRegreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNavRegreso.Location = new System.Drawing.Point(45, 8);
            this.btnNavRegreso.Name = "btnNavRegreso";
            this.btnNavRegreso.Size = new System.Drawing.Size(35, 25);
            this.btnNavRegreso.TabIndex = 1;
            this.btnNavRegreso.Text = "<";
            this.btnNavRegreso.UseVisualStyleBackColor = true;
            this.btnNavRegreso.Click += new System.EventHandler(this.BtnNavBack_Click);
            // 
            // btnNavAdelante
            // 
            this.btnNavAdelante.BackColor = System.Drawing.SystemColors.Control;
            this.btnNavAdelante.Enabled = false;
            this.btnNavAdelante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNavAdelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAdelante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNavAdelante.Location = new System.Drawing.Point(85, 8);
            this.btnNavAdelante.Name = "btnNavAdelante";
            this.btnNavAdelante.Size = new System.Drawing.Size(35, 25);
            this.btnNavAdelante.TabIndex = 2;
            this.btnNavAdelante.Text = ">";
            this.btnNavAdelante.UseVisualStyleBackColor = true;
            this.btnNavAdelante.Click += new System.EventHandler(this.BtnNavForward_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefrescar.Location = new System.Drawing.Point(125, 8);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 25);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.Control;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.Location = new System.Drawing.Point(205, 8);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(55, 25);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(265, 8);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(485, 21);
            this.txtUrl.TabIndex = 5;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrl_KeyPress);
            // 
            // btnIr
            // 
            this.btnIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIr.BackColor = System.Drawing.SystemColors.Control;
            this.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIr.Location = new System.Drawing.Point(755, 8);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(35, 25);
            this.btnIr.TabIndex = 6;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEstado.Controls.Add(this.lblEstado);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEstado.Location = new System.Drawing.Point(0, 486);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(800, 25);
            this.pnlEstado.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(12, 5);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(32, 15);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Listo";
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 40);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(800, 446);
            this.webView.TabIndex = 2;
            this.webView.ZoomFactor = 1D;
            // 
            // Frm_Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.pnlEstado);
            this.Controls.Add(this.pnlToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 500);
            this.Name = "Frm_Navegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegador Web";
            this.Load += new System.EventHandler(this.WebBrowserForm_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNavRegreso;
        private System.Windows.Forms.Button btnNavAdelante;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label lblEstado;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

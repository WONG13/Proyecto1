namespace InterfacesSief
{
    partial class E_RevSol
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.i_CapInt1 = new InterfacesSief.I_CapInt();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.i_CapAlu1 = new InterfacesSief.I_CapAlu();
            this.i_CapDoc1 = new InterfacesSief.I_CapDoc();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(221, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 48);
            this.btnAceptar.TabIndex = 86;
            this.btnAceptar.Text = "Aprobar\r\nSolicitud";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(120, 19);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(82, 48);
            this.btnReporte.TabIndex = 87;
            this.btnReporte.Text = "Reporte\r\nSolicitud";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(21, 19);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(82, 48);
            this.btnTerminar.TabIndex = 88;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 334);
            this.tabControl1.TabIndex = 91;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.i_CapInt1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // i_CapInt1
            // 
            this.i_CapInt1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapInt1.Location = new System.Drawing.Point(6, 24);
            this.i_CapInt1.Name = "i_CapInt1";
            this.i_CapInt1.Size = new System.Drawing.Size(326, 248);
            this.i_CapInt1.TabIndex = 89;
            this.i_CapInt1.Load += new System.EventHandler(this.i_CapInt1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.i_CapAlu1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // i_CapAlu1
            // 
            this.i_CapAlu1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapAlu1.Location = new System.Drawing.Point(3, 24);
            this.i_CapAlu1.Name = "i_CapAlu1";
            this.i_CapAlu1.Size = new System.Drawing.Size(336, 245);
            this.i_CapAlu1.TabIndex = 90;
            // 
            // i_CapDoc1
            // 
            this.i_CapDoc1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapDoc1.Location = new System.Drawing.Point(365, 3);
            this.i_CapDoc1.Name = "i_CapDoc1";
            this.i_CapDoc1.Size = new System.Drawing.Size(472, 410);
            this.i_CapDoc1.TabIndex = 92;
            // 
            // E_RevSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.i_CapDoc1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAceptar);
            this.Name = "E_RevSol";
            this.Size = new System.Drawing.Size(840, 410);
            this.Load += new System.EventHandler(this.E_RevSol_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnTerminar;
        private I_CapInt i_CapInt1;
        private I_CapAlu i_CapAlu1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private I_CapDoc i_CapDoc1;
    }
}
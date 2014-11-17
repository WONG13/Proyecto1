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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.i_CapAlu1 = new InterfacesSief.I_CapAlu();
            this.i_CapInt1 = new InterfacesSief.I_CapInt();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(329, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 127);
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(178, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 127);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 128);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Identificación Oficial";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 26);
            this.label14.TabIndex = 84;
            this.label14.Text = "Comprobante de Inscripcion\r\nal nuevo ciclo escolar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 83;
            this.label15.Text = "Boleta de Calficaciones";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(562, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 48);
            this.btnAceptar.TabIndex = 86;
            this.btnAceptar.Text = "Aprobar\r\nSolicitud";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(564, 296);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(82, 48);
            this.btnReporte.TabIndex = 87;
            this.btnReporte.Text = "Reporte\r\nSolicitud";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(564, 350);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(82, 48);
            this.btnTerminar.TabIndex = 88;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // i_CapAlu1
            // 
            this.i_CapAlu1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapAlu1.Location = new System.Drawing.Point(0, 33);
            this.i_CapAlu1.Name = "i_CapAlu1";
            this.i_CapAlu1.Size = new System.Drawing.Size(336, 245);
            this.i_CapAlu1.TabIndex = 90;
            // 
            // i_CapInt1
            // 
            this.i_CapInt1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapInt1.Location = new System.Drawing.Point(342, 33);
            this.i_CapInt1.Name = "i_CapInt1";
            this.i_CapInt1.Size = new System.Drawing.Size(326, 248);
            this.i_CapInt1.TabIndex = 89;
            this.i_CapInt1.Load += new System.EventHandler(this.i_CapInt1_Load);
            // 
            // E_RevSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.i_CapAlu1);
            this.Controls.Add(this.i_CapInt1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "E_RevSol";
            this.Size = new System.Drawing.Size(840, 410);
            this.Load += new System.EventHandler(this.E_RevSol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnTerminar;
        private I_CapInt i_CapInt1;
        private I_CapAlu i_CapAlu1;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTutor = new System.Windows.Forms.TabPage();
            this.i_CapInt1 = new InterfacesSief.I_CapInt();
            this.tabAlumnos = new System.Windows.Forms.TabPage();
            this.i_CapAlu1 = new InterfacesSief.I_CapAlu();
            this.i_CapDoc1 = new InterfacesSief.I_CapDoc();
            this.radbAprobar = new System.Windows.Forms.RadioButton();
            this.radbDenegar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errproValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabTutor.SuspendLayout();
            this.tabAlumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errproValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(136, 35);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(82, 35);
            this.btnReporte.TabIndex = 87;
            this.btnReporte.Text = "Reporte\r\nSolicitud";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(26, 35);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(82, 35);
            this.btnTerminar.TabIndex = 88;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTutor);
            this.tabControl1.Controls.Add(this.tabAlumnos);
            this.tabControl1.Location = new System.Drawing.Point(3, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 334);
            this.tabControl1.TabIndex = 91;
            // 
            // tabTutor
            // 
            this.tabTutor.Controls.Add(this.i_CapInt1);
            this.tabTutor.Location = new System.Drawing.Point(4, 22);
            this.tabTutor.Name = "tabTutor";
            this.tabTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabTutor.Size = new System.Drawing.Size(348, 308);
            this.tabTutor.TabIndex = 0;
            this.tabTutor.Text = "Tutor";
            this.tabTutor.UseVisualStyleBackColor = true;
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
            // tabAlumnos
            // 
            this.tabAlumnos.Controls.Add(this.i_CapAlu1);
            this.tabAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumnos.Size = new System.Drawing.Size(348, 308);
            this.tabAlumnos.TabIndex = 1;
            this.tabAlumnos.Text = "Alumno";
            this.tabAlumnos.UseVisualStyleBackColor = true;
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
            this.i_CapDoc1.Location = new System.Drawing.Point(365, 0);
            this.i_CapDoc1.Name = "i_CapDoc1";
            this.i_CapDoc1.Size = new System.Drawing.Size(475, 413);
            this.i_CapDoc1.TabIndex = 92;
            // 
            // radbAprobar
            // 
            this.radbAprobar.AutoSize = true;
            this.radbAprobar.Checked = true;
            this.radbAprobar.Location = new System.Drawing.Point(12, 3);
            this.radbAprobar.Name = "radbAprobar";
            this.radbAprobar.Size = new System.Drawing.Size(105, 17);
            this.radbAprobar.TabIndex = 93;
            this.radbAprobar.TabStop = true;
            this.radbAprobar.Text = "Aprobar Solicitud";
            this.radbAprobar.UseVisualStyleBackColor = true;
            // 
            // radbDenegar
            // 
            this.radbDenegar.AutoSize = true;
            this.radbDenegar.Location = new System.Drawing.Point(12, 23);
            this.radbDenegar.Name = "radbDenegar";
            this.radbDenegar.Size = new System.Drawing.Size(109, 17);
            this.radbDenegar.TabIndex = 93;
            this.radbDenegar.Text = "Denegar Solicitud";
            this.radbDenegar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.radbDenegar);
            this.panel1.Controls.Add(this.radbAprobar);
            this.panel1.Location = new System.Drawing.Point(222, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 44);
            this.panel1.TabIndex = 94;
            // 
            // errproValidar
            // 
            this.errproValidar.ContainerControl = this;
            // 
            // E_RevSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.i_CapDoc1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnReporte);
            this.Name = "E_RevSol";
            this.Size = new System.Drawing.Size(840, 410);
            this.Load += new System.EventHandler(this.E_RevSol_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTutor.ResumeLayout(false);
            this.tabAlumnos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errproValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnTerminar;
        private I_CapInt i_CapInt1;
        private I_CapAlu i_CapAlu1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTutor;
        private System.Windows.Forms.TabPage tabAlumnos;
        private I_CapDoc i_CapDoc1;
        private System.Windows.Forms.RadioButton radbAprobar;
        private System.Windows.Forms.RadioButton radbDenegar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errproValidar;
    }
}
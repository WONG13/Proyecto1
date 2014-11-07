namespace InterfacesSief
{
    partial class I_FormSol
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anexarDocumentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.capturarDatosToolStripMenuItem,
            this.enviarSolicitudToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // capturarDatosToolStripMenuItem
            // 
            this.capturarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interesadoToolStripMenuItem,
            this.alumnoToolStripMenuItem,
            this.anexarDocumentosToolStripMenuItem1});
            this.capturarDatosToolStripMenuItem.Name = "capturarDatosToolStripMenuItem";
            this.capturarDatosToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.capturarDatosToolStripMenuItem.Text = "Capturar de Datos";
            // 
            // interesadoToolStripMenuItem
            // 
            this.interesadoToolStripMenuItem.Name = "interesadoToolStripMenuItem";
            this.interesadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.interesadoToolStripMenuItem.Text = "Interesado";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // anexarDocumentosToolStripMenuItem1
            // 
            this.anexarDocumentosToolStripMenuItem1.Name = "anexarDocumentosToolStripMenuItem1";
            this.anexarDocumentosToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.anexarDocumentosToolStripMenuItem1.Text = "Anexar Documentos";
            // 
            // enviarSolicitudToolStripMenuItem
            // 
            this.enviarSolicitudToolStripMenuItem.Name = "enviarSolicitudToolStripMenuItem";
            this.enviarSolicitudToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.enviarSolicitudToolStripMenuItem.Text = "Enviar Solicitud";
            // 
            // I_FormSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "I_FormSol";
            this.Text = "Solicitud";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anexarDocumentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enviarSolicitudToolStripMenuItem;
    }
}


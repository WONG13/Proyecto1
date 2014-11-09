namespace InterfacesSief
{
    partial class InteresadoMainComponent
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agergarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFichasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agergarDatosToolStripMenuItem,
            this.hacerSolicitudToolStripMenuItem,
            this.subirDocumentoToolStripMenuItem,
            this.verFichasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agergarDatosToolStripMenuItem
            // 
            this.agergarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interesadoToolStripMenuItem,
            this.alumnoToolStripMenuItem});
            this.agergarDatosToolStripMenuItem.Name = "agergarDatosToolStripMenuItem";
            this.agergarDatosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.agergarDatosToolStripMenuItem.Text = "Agergar Datos";
            // 
            // interesadoToolStripMenuItem
            // 
            this.interesadoToolStripMenuItem.Name = "interesadoToolStripMenuItem";
            this.interesadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.interesadoToolStripMenuItem.Text = "Tutor";
            this.interesadoToolStripMenuItem.Click += new System.EventHandler(this.interesadoToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // hacerSolicitudToolStripMenuItem
            // 
            this.hacerSolicitudToolStripMenuItem.Name = "hacerSolicitudToolStripMenuItem";
            this.hacerSolicitudToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.hacerSolicitudToolStripMenuItem.Text = "Hacer Solicitud";
            this.hacerSolicitudToolStripMenuItem.Click += new System.EventHandler(this.hacerSolicitudToolStripMenuItem_Click);
            // 
            // subirDocumentoToolStripMenuItem
            // 
            this.subirDocumentoToolStripMenuItem.Name = "subirDocumentoToolStripMenuItem";
            this.subirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.subirDocumentoToolStripMenuItem.Text = "Subir Documento";
            // 
            // verFichasToolStripMenuItem
            // 
            this.verFichasToolStripMenuItem.Name = "verFichasToolStripMenuItem";
            this.verFichasToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.verFichasToolStripMenuItem.Text = "Ver Fichas";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // InteresadoMainComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "InteresadoMainComponent";
            this.Size = new System.Drawing.Size(668, 400);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agergarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFichasToolStripMenuItem;
    }
}

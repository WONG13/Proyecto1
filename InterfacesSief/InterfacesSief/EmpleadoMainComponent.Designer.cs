namespace InterfacesSief
{
    partial class EmpleadoMainComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucarSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeRevisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSolicitudesToolStripMenuItem,
            this.reporteDeSolicitudesToolStripMenuItem,
            this.bucarSolicitudToolStripMenuItem,
            this.registroDeRevisionesToolStripMenuItem});
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // verSolicitudesToolStripMenuItem
            // 
            this.verSolicitudesToolStripMenuItem.Name = "verSolicitudesToolStripMenuItem";
            this.verSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.verSolicitudesToolStripMenuItem.Text = "Ver Solicitudes";
            this.verSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.verSolicitudesToolStripMenuItem_Click);
            // 
            // reporteDeSolicitudesToolStripMenuItem
            // 
            this.reporteDeSolicitudesToolStripMenuItem.Name = "reporteDeSolicitudesToolStripMenuItem";
            this.reporteDeSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.reporteDeSolicitudesToolStripMenuItem.Text = "Reporte de Solicitudes";
            this.reporteDeSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeSolicitudesToolStripMenuItem_Click);
            // 
            // bucarSolicitudToolStripMenuItem
            // 
            this.bucarSolicitudToolStripMenuItem.Name = "bucarSolicitudToolStripMenuItem";
            this.bucarSolicitudToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.bucarSolicitudToolStripMenuItem.Text = "Buscar Solicitud";
            this.bucarSolicitudToolStripMenuItem.Click += new System.EventHandler(this.bucarSolicitudToolStripMenuItem_Click);
            // 
            // registroDeRevisionesToolStripMenuItem
            // 
            this.registroDeRevisionesToolStripMenuItem.Name = "registroDeRevisionesToolStripMenuItem";
            this.registroDeRevisionesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.registroDeRevisionesToolStripMenuItem.Text = "Registro de Revisiones";
            // 
            // EmpleadoMainComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "EmpleadoMainComponent";
            this.Size = new System.Drawing.Size(840, 410);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucarSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeRevisionesToolStripMenuItem;

    }
}

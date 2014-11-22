namespace InterfacesSief.Interfaces
{
    partial class U_PantReg
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
            this.i_NewUsu1 = new InterfacesSief.I_NewUsu();
            this.i_CapInt1 = new InterfacesSief.I_CapInt();
            this.SuspendLayout();
            // 
            // i_NewUsu1
            // 
            this.i_NewUsu1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_NewUsu1.Location = new System.Drawing.Point(419, 84);
            this.i_NewUsu1.Name = "i_NewUsu1";
            this.i_NewUsu1.Size = new System.Drawing.Size(348, 217);
            this.i_NewUsu1.TabIndex = 0;
            // 
            // i_CapInt1
            // 
            this.i_CapInt1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapInt1.Location = new System.Drawing.Point(65, 84);
            this.i_CapInt1.Name = "i_CapInt1";
            this.i_CapInt1.Size = new System.Drawing.Size(348, 217);
            this.i_CapInt1.TabIndex = 1;
            // 
            // U_PantReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.i_CapInt1);
            this.Controls.Add(this.i_NewUsu1);
            this.Name = "U_PantReg";
            this.Size = new System.Drawing.Size(840, 410);
            this.ResumeLayout(false);

        }

        #endregion

        private I_NewUsu i_NewUsu1;
        private I_CapInt i_CapInt1;

    }
}

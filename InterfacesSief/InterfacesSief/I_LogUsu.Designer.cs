namespace InterfacesSief
{
    partial class I_LogUsu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnNewUsu = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(110, 186);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtContra);
            this.GroupBox1.Controls.Add(this.txtUsuario);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Size = new System.Drawing.Size(254, 98);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(254, 35);
            this.label1.Text = "Inicio de Sesión";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 187);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(97, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(97, 59);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 3;
            // 
            // btnNewUsu
            // 
            this.btnNewUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewUsu.Location = new System.Drawing.Point(16, 165);
            this.btnNewUsu.Name = "btnNewUsu";
            this.btnNewUsu.Size = new System.Drawing.Size(75, 45);
            this.btnNewUsu.TabIndex = 8;
            this.btnNewUsu.Text = "Crear \r\nUsuario";
            this.btnNewUsu.UseVisualStyleBackColor = true;
            // 
            // I_LogUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(278, 221);
            this.Controls.Add(this.btnNewUsu);
            this.Name = "I_LogUsu";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnNewUsu, 0);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnNewUsu;
    }
}

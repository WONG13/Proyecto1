namespace InterfacesSief
{
    partial class E_RevDoc
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(416, 350);
            this.btnAceptar.Text = "Revisar";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.listBox1);
            this.GroupBox1.Size = new System.Drawing.Size(560, 261);
            // 
            // label1
            // 
            this.label1.Text = "Revisión de Solicitudes";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(497, 350);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 212);
            this.listBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solicitudes:";
            // 
            // I_RevDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 384);
            this.Name = "I_RevDoc";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}

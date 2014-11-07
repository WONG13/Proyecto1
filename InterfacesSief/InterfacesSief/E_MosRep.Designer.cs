namespace InterfacesSief
{
    partial class E_MosRep
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(466, 338);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.textBox1);
            this.GroupBox1.Controls.Add(this.listBox1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Size = new System.Drawing.Size(610, 249);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(610, 35);
            this.label1.Text = "Reportes";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(547, 338);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reporte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 147);
            this.textBox1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 147);
            this.listBox1.TabIndex = 10;
            // 
            // E_MosRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Name = "E_MosRep";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

namespace InterfacesSief
{
    partial class I_RegistrodeRev
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSolDenegadas = new System.Windows.Forms.DataGridView();
            this.dgvSolAprovadas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolDenegadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolAprovadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Revisiones";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvSolDenegadas);
            this.groupBox1.Controls.Add(this.dgvSolAprovadas);
            this.groupBox1.Location = new System.Drawing.Point(8, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 328);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solicitudes Denegadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solicitudes Aprobadas";
            // 
            // dgvSolDenegadas
            // 
            this.dgvSolDenegadas.AllowUserToAddRows = false;
            this.dgvSolDenegadas.AllowUserToDeleteRows = false;
            this.dgvSolDenegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolDenegadas.Location = new System.Drawing.Point(25, 191);
            this.dgvSolDenegadas.Name = "dgvSolDenegadas";
            this.dgvSolDenegadas.ReadOnly = true;
            this.dgvSolDenegadas.Size = new System.Drawing.Size(756, 137);
            this.dgvSolDenegadas.TabIndex = 1;
            // 
            // dgvSolAprovadas
            // 
            this.dgvSolAprovadas.AllowUserToAddRows = false;
            this.dgvSolAprovadas.AllowUserToDeleteRows = false;
            this.dgvSolAprovadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolAprovadas.Location = new System.Drawing.Point(25, 37);
            this.dgvSolAprovadas.Name = "dgvSolAprovadas";
            this.dgvSolAprovadas.ReadOnly = true;
            this.dgvSolAprovadas.Size = new System.Drawing.Size(756, 121);
            this.dgvSolAprovadas.TabIndex = 0;
            // 
            // I_RegistrodeRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "I_RegistrodeRev";
            this.Size = new System.Drawing.Size(840, 410);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolDenegadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolAprovadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSolDenegadas;
        private System.Windows.Forms.DataGridView dgvSolAprovadas;
    }
}

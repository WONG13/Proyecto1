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
            this.txtInfoReporte = new System.Windows.Forms.TextBox();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.txtTipoRep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(610, 35);
            this.label1.Text = "Reportes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTipoRep);
            this.groupBox1.Controls.Add(this.dgvReportes);
            this.groupBox1.Controls.Add(this.txtInfoReporte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Size = new System.Drawing.Size(610, 249);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(466, 338);
            this.btnAceptar.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(547, 338);
            this.btnCancel.Visible = false;
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
            // txtInfoReporte
            // 
            this.txtInfoReporte.Location = new System.Drawing.Point(302, 76);
            this.txtInfoReporte.Multiline = true;
            this.txtInfoReporte.Name = "txtInfoReporte";
            this.txtInfoReporte.ReadOnly = true;
            this.txtInfoReporte.Size = new System.Drawing.Size(280, 123);
            this.txtInfoReporte.TabIndex = 8;
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(10, 49);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(273, 150);
            this.dgvReportes.TabIndex = 10;
            this.dgvReportes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReportes_CellMouseClick);
            // 
            // txtTipoRep
            // 
            this.txtTipoRep.Location = new System.Drawing.Point(392, 48);
            this.txtTipoRep.Name = "txtTipoRep";
            this.txtTipoRep.ReadOnly = true;
            this.txtTipoRep.Size = new System.Drawing.Size(190, 20);
            this.txtTipoRep.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de Reporte:";
            // 
            // E_MosRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "E_MosRep";
            this.Size = new System.Drawing.Size(634, 372);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInfoReporte;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoRep;
    }
}

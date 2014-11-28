namespace InterfacesSief
{
    partial class I_CapDoc
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
            this.btnAdjBol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVerCompleto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(816, 35);
            this.label1.Text = "Documentación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerCompleto);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnEliminar1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdjBol);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Size = new System.Drawing.Size(816, 301);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(672, 376);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(753, 376);
            // 
            // btnAdjBol
            // 
            this.btnAdjBol.Location = new System.Drawing.Point(30, 375);
            this.btnAdjBol.Name = "btnAdjBol";
            this.btnAdjBol.Size = new System.Drawing.Size(75, 23);
            this.btnAdjBol.TabIndex = 0;
            this.btnAdjBol.Text = "Adjuntar";
            this.btnAdjBol.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comprobante de Inscripcion\r\nal nuevo ciclo escolar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Location = new System.Drawing.Point(211, 375);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar1.TabIndex = 9;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(319, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 55);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar Archivo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Intrucciones:\r\n1.- Elija un tipo de documento de la lista.\r\n2.- Busque el archivo" +
                " del documento (solo formatos de imagenes .jpg, .bmp, .png).\r\n3.- Suba el archiv" +
                "o.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Documento";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(319, 165);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(79, 44);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar\r\nArchivo";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVerCompleto
            // 
            this.btnVerCompleto.Location = new System.Drawing.Point(319, 215);
            this.btnVerCompleto.Name = "btnVerCompleto";
            this.btnVerCompleto.Size = new System.Drawing.Size(77, 38);
            this.btnVerCompleto.TabIndex = 17;
            this.btnVerCompleto.Text = "Ver Completo";
            this.btnVerCompleto.UseVisualStyleBackColor = true;
            this.btnVerCompleto.Click += new System.EventHandler(this.btnVerCompleto_Click);
            // 
            // I_CapDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "I_CapDoc";
            this.Size = new System.Drawing.Size(840, 410);
            this.Load += new System.EventHandler(this.I_CapDoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdjBol;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVerCompleto;
    }
}

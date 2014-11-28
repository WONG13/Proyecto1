namespace InterfacesSief
{
    partial class I_CapAlu
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
            this.components = new System.ComponentModel.Container();
            this.txtProAlu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomAlumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxNivel = new System.Windows.Forms.ComboBox();
            this.ComboBoxEsc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGraAlu = new System.Windows.Forms.TextBox();
            this.dateFechNacimiento = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Size = new System.Drawing.Size(312, 35);
            this.label1.Text = "Captura Datos del Alumno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateFechNacimiento);
            this.groupBox1.Controls.Add(this.txtGraAlu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBoxEsc);
            this.groupBox1.Controls.Add(this.ComboBoxNivel);
            this.groupBox1.Controls.Add(this.txtProAlu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomAlumno);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Size = new System.Drawing.Size(312, 184);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(168, 228);
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 228);
            // 
            // txtProAlu
            // 
            this.txtProAlu.Location = new System.Drawing.Point(134, 150);
            this.txtProAlu.Name = "txtProAlu";
            this.txtProAlu.Size = new System.Drawing.Size(168, 20);
            this.txtProAlu.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre de la Escuela:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nivel Academico:";
            // 
            // txtNomAlumno
            // 
            this.txtNomAlumno.Location = new System.Drawing.Point(134, 19);
            this.txtNomAlumno.Name = "txtNomAlumno";
            this.txtNomAlumno.Size = new System.Drawing.Size(168, 20);
            this.txtNomAlumno.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre Completo:";
            // 
            // ComboBoxNivel
            // 
            this.ComboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNivel.FormattingEnabled = true;
            this.ComboBoxNivel.Location = new System.Drawing.Point(134, 70);
            this.ComboBoxNivel.Name = "ComboBoxNivel";
            this.ComboBoxNivel.Size = new System.Drawing.Size(168, 21);
            this.ComboBoxNivel.TabIndex = 47;
            this.ComboBoxNivel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNivel_SelectedIndexChanged);
            // 
            // ComboBoxEsc
            // 
            this.ComboBoxEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEsc.FormattingEnabled = true;
            this.ComboBoxEsc.Location = new System.Drawing.Point(134, 97);
            this.ComboBoxEsc.Name = "ComboBoxEsc";
            this.ComboBoxEsc.Size = new System.Drawing.Size(168, 21);
            this.ComboBoxEsc.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Grado Escolar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Promedio Escolar:";
            // 
            // txtGraAlu
            // 
            this.txtGraAlu.Location = new System.Drawing.Point(134, 124);
            this.txtGraAlu.Name = "txtGraAlu";
            this.txtGraAlu.Size = new System.Drawing.Size(168, 20);
            this.txtGraAlu.TabIndex = 52;
            // 
            // dateFechNacimiento
            // 
            this.dateFechNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechNacimiento.Location = new System.Drawing.Point(134, 45);
            this.dateFechNacimiento.Name = "dateFechNacimiento";
            this.dateFechNacimiento.Size = new System.Drawing.Size(168, 20);
            this.dateFechNacimiento.TabIndex = 53;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // I_CapAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "I_CapAlu";
            this.Size = new System.Drawing.Size(336, 254);
            this.Load += new System.EventHandler(this.I_CapAlu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProAlu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGraAlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxEsc;
        private System.Windows.Forms.DateTimePicker dateFechNacimiento;
        private System.Windows.Forms.ComboBox ComboBoxNivel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

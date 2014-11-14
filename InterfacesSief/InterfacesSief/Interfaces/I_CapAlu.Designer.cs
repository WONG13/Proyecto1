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
            this.txtProAlu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomComInt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxDia = new System.Windows.Forms.ComboBox();
            this.ComboBoxMes = new System.Windows.Forms.ComboBox();
            this.ComboBoxA = new System.Windows.Forms.ComboBox();
            this.ComboBoxNivel = new System.Windows.Forms.ComboBox();
            this.ComboBoxEsc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGraAlu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(239, 281);
            this.btnAceptar.Text = "Guardar";
            // 
            // GroupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGraAlu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBoxEsc);
            this.groupBox1.Controls.Add(this.ComboBoxNivel);
            this.groupBox1.Controls.Add(this.ComboBoxA);
            this.groupBox1.Controls.Add(this.ComboBoxMes);
            this.groupBox1.Controls.Add(this.ComboBoxDia);
            this.groupBox1.Controls.Add(this.txtProAlu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomComInt);
            this.groupBox1.Size = new System.Drawing.Size(383, 192);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(383, 35);
            this.label1.Text = "Captura Datos del Alumno";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 280);
            // 
            // txtProAlu
            // 
            this.txtProAlu.Location = new System.Drawing.Point(134, 150);
            this.txtProAlu.Name = "txtProAlu";
            this.txtProAlu.Size = new System.Drawing.Size(216, 20);
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
            // txtNomComInt
            // 
            this.txtNomComInt.Location = new System.Drawing.Point(134, 19);
            this.txtNomComInt.Name = "txtNomComInt";
            this.txtNomComInt.Size = new System.Drawing.Size(216, 20);
            this.txtNomComInt.TabIndex = 38;
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
            // ComboBoxDia
            // 
            this.ComboBoxDia.FormattingEnabled = true;
            this.ComboBoxDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ComboBoxDia.Location = new System.Drawing.Point(134, 45);
            this.ComboBoxDia.Name = "ComboBoxDia";
            this.ComboBoxDia.Size = new System.Drawing.Size(68, 21);
            this.ComboBoxDia.TabIndex = 44;
            // 
            // ComboBoxMes
            // 
            this.ComboBoxMes.FormattingEnabled = true;
            this.ComboBoxMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.ComboBoxMes.Location = new System.Drawing.Point(208, 45);
            this.ComboBoxMes.Name = "ComboBoxMes";
            this.ComboBoxMes.Size = new System.Drawing.Size(68, 21);
            this.ComboBoxMes.TabIndex = 45;
            // 
            // ComboBoxA
            // 
            this.ComboBoxA.FormattingEnabled = true;
            this.ComboBoxA.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.ComboBoxA.Location = new System.Drawing.Point(282, 45);
            this.ComboBoxA.Name = "ComboBoxA";
            this.ComboBoxA.Size = new System.Drawing.Size(68, 21);
            this.ComboBoxA.TabIndex = 46;
            // 
            // ComboBoxNivel
            // 
            this.ComboBoxNivel.FormattingEnabled = true;
            this.ComboBoxNivel.Location = new System.Drawing.Point(134, 70);
            this.ComboBoxNivel.Name = "ComboBoxNivel";
            this.ComboBoxNivel.Size = new System.Drawing.Size(216, 21);
            this.ComboBoxNivel.TabIndex = 47;
            // 
            // ComboBoxEsc
            // 
            this.ComboBoxEsc.FormattingEnabled = true;
            this.ComboBoxEsc.Location = new System.Drawing.Point(134, 97);
            this.ComboBoxEsc.Name = "ComboBoxEsc";
            this.ComboBoxEsc.Size = new System.Drawing.Size(216, 21);
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
            this.txtGraAlu.Size = new System.Drawing.Size(216, 20);
            this.txtGraAlu.TabIndex = 52;
            // 
            // I_CapAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(407, 315);
            this.Name = "I_CapAlu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProAlu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomComInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxDia;
        private System.Windows.Forms.ComboBox ComboBoxA;
        private System.Windows.Forms.ComboBox ComboBoxMes;
        private System.Windows.Forms.TextBox txtGraAlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxEsc;
        private System.Windows.Forms.ComboBox ComboBoxNivel;
    }
}

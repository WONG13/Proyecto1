﻿namespace InterfacesSief
{
    partial class I_CapInt
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
            this.txtTelInt = new System.Windows.Forms.TextBox();
            this.txtCorInt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDirInt = new System.Windows.Forms.TextBox();
            this.txtNomComInt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(147, 183);
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.Text = "Capturar Datos del Interesado";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 183);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelInt);
            this.groupBox1.Controls.Add(this.txtCorInt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDirInt);
            this.groupBox1.Controls.Add(this.txtNomComInt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Size = new System.Drawing.Size(291, 139);
            // 
            // txtTelInt
            // 
            this.txtTelInt.Location = new System.Drawing.Point(111, 103);
            this.txtTelInt.Name = "txtTelInt";
            this.txtTelInt.Size = new System.Drawing.Size(164, 20);
            this.txtTelInt.TabIndex = 37;
            // 
            // txtCorInt
            // 
            this.txtCorInt.Location = new System.Drawing.Point(111, 77);
            this.txtCorInt.Name = "txtCorInt";
            this.txtCorInt.Size = new System.Drawing.Size(164, 20);
            this.txtCorInt.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "*Correo Electronico:";
            // 
            // txtDirInt
            // 
            this.txtDirInt.Location = new System.Drawing.Point(111, 51);
            this.txtDirInt.Name = "txtDirInt";
            this.txtDirInt.Size = new System.Drawing.Size(164, 20);
            this.txtDirInt.TabIndex = 33;
            // 
            // txtNomComInt
            // 
            this.txtNomComInt.Location = new System.Drawing.Point(111, 25);
            this.txtNomComInt.Name = "txtNomComInt";
            this.txtNomComInt.Size = new System.Drawing.Size(164, 20);
            this.txtNomComInt.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "*Nombre Completo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // I_CapInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "I_CapInt";
            this.Size = new System.Drawing.Size(315, 217);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelInt;
        private System.Windows.Forms.TextBox txtCorInt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDirInt;
        private System.Windows.Forms.TextBox txtNomComInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

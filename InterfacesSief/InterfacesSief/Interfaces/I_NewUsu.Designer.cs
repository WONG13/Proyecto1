namespace InterfacesSief
{
    partial class I_NewUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_NewUsu));
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomUsuInt = new System.Windows.Forms.TextBox();
            this.txtConConInt = new System.Windows.Forms.TextBox();
            this.txtConUsuInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.i_CapInt1 = new InterfacesSief.I_CapInt();
            this.i_CapAlu1 = new InterfacesSief.I_CapAlu();
            this.label4 = new System.Windows.Forms.Label();
            this.deteccionError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deteccionError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Size = new System.Drawing.Size(816, 35);
            this.label1.Text = "Creación de Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.i_CapAlu1);
            this.groupBox1.Controls.Add(this.i_CapInt1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNomUsuInt);
            this.groupBox1.Controls.Add(this.txtConConInt);
            this.groupBox1.Controls.Add(this.txtConUsuInt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Size = new System.Drawing.Size(807, 362);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(680, 415);
            this.btnAceptar.Text = "Registrarse";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(761, 414);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "*Confirmar Contraseña:";
            // 
            // txtNomUsuInt
            // 
            this.txtNomUsuInt.Location = new System.Drawing.Point(177, 22);
            this.txtNomUsuInt.Name = "txtNomUsuInt";
            this.txtNomUsuInt.Size = new System.Drawing.Size(169, 20);
            this.txtNomUsuInt.TabIndex = 31;
            // 
            // txtConConInt
            // 
            this.txtConConInt.Location = new System.Drawing.Point(177, 77);
            this.txtConConInt.Name = "txtConConInt";
            this.txtConConInt.PasswordChar = '*';
            this.txtConConInt.Size = new System.Drawing.Size(169, 20);
            this.txtConConInt.TabIndex = 21;
            // 
            // txtConUsuInt
            // 
            this.txtConUsuInt.Location = new System.Drawing.Point(177, 50);
            this.txtConUsuInt.Name = "txtConUsuInt";
            this.txtConUsuInt.PasswordChar = '*';
            this.txtConUsuInt.Size = new System.Drawing.Size(169, 20);
            this.txtConUsuInt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "*Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Nombre de Usuario:";
            // 
            // i_CapInt1
            // 
            this.i_CapInt1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapInt1.Location = new System.Drawing.Point(58, 116);
            this.i_CapInt1.Name = "i_CapInt1";
            this.i_CapInt1.Size = new System.Drawing.Size(333, 215);
            this.i_CapInt1.TabIndex = 32;
            // 
            // i_CapAlu1
            // 
            this.i_CapAlu1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.i_CapAlu1.Location = new System.Drawing.Point(407, 103);
            this.i_CapAlu1.Name = "i_CapAlu1";
            this.i_CapAlu1.Size = new System.Drawing.Size(351, 251);
            this.i_CapAlu1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 78);
            this.label4.TabIndex = 34;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // deteccionError
            // 
            this.deteccionError.ContainerControl = this;
            // 
            // I_NewUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "I_NewUsu";
            this.Size = new System.Drawing.Size(840, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deteccionError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomUsuInt;
        private System.Windows.Forms.TextBox txtConConInt;
        private System.Windows.Forms.TextBox txtConUsuInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private I_CapAlu i_CapAlu1;
        private I_CapInt i_CapInt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider deteccionError;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginComponent LogCom = new LoginComponent();
            panel1.Controls.Add(LogCom);
            LogCom.Show();
            InteresadoMainComponent IMC = new InteresadoMainComponent();
            panel2.Controls.Add(IMC);
            IMC.Show();
            /*
            I_LogUsu log = new I_LogUsu();
            log.TopLevel = false;
            log.StartPosition = FormStartPosition.CenterScreen;
            log.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(log);
            log.Show();*/
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

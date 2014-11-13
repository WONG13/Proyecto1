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
    delegate void cargarComponentes(Usuario user);
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();         
            loginComponent1.setDelegado(this);
            
            //I_FormSol f1 = new I_FormSol();
            /*f1.TopLevel = false;
            f1.WindowState = FormWindowState.Maximized;
            panel2.Controls.Add(f1);
            f1.Show();*/
            
            /*
            I_LogUsu log = new I_LogUsu();
            log.TopLevel = false;
            log.StartPosition = FormStartPosition.CenterScreen;
            log.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(log);
            log.Show();*/
            
        }

        public void loadComponentsByUser(Usuario user)
        {
            switch(user.getPermisos())
            {
                case "Interesado":
                    InteresadoMainComponent IMC = new InteresadoMainComponent();
                    IMC.setUsuario(user);
                    panel2.Controls.Add(IMC);
                    IMC.Show();
                    break;
                case "Empleado":
                    //Hacer cosas
                    break;
                case "Lider":
                    //Hacer cosas
                    break;
            }
        }
        
    }
}

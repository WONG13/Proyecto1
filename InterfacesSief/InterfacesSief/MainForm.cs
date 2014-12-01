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
    delegate void cerrarSesion();
    delegate void abrirRegistro();
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
            pnlCentral.Controls.Clear();
            switch(user.getPermisos())
            {
                case "Interesado":
                    InteresadoMainComponent IMC = new InteresadoMainComponent();
                    IMC.setUsuario(user);
                    pnlCentral.Controls.Add(IMC);
                    IMC.Show();
                    break;
                case "Empleado":
                    EmpleadoMainComponent EMC = new EmpleadoMainComponent();
                    EMC.setUsuario((Empleado)user);
                    //EMC.setUsuario(user);
                    pnlCentral.Controls.Add(EMC);
                    EMC.Show();
                    break;
                case "Lider":
                    //Hacer cosas
                    break;
            }
        }

        public void Logout()
        {
            pnlCentral.Controls.Clear();

        }

        public void showLogUpScreen()
        {
            I_NewUsu Registro=new I_NewUsu();
            Registro.SetDelegado(this);
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(Registro);
        }
        
    }
}

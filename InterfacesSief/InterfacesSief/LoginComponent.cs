using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class LoginComponent : UserControl
    {
        Usuario actual;
        cargarComponentes cargarEnMainForm;
        public LoginComponent()
        {
            InitializeComponent();
        }

        public void setDelegado(MainForm f)
        {
            cargarEnMainForm=new cargarComponentes(f.loadComponentsByUser);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuario user=Usuario.getUsuarioFromDB(txtUsuario.Text, -1);
                if(user!=null)
                    if (user.getAcceso(txtContraseña.Text))
                    {
                        actual = user.abrirSesion();
                        mostrarUsuario();
                        cargarEnMainForm(actual);
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorrectas");
                else
                    MessageBox.Show("Usuario o contraseña incorrectas");
            }
        }

        public bool Validar()
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Error: Llene los compos completamente \n"+
                                "Usuario o Contraseña vacios");
                return false;
            }
            else
                return true;
        }

        private void mostrarUsuario()
        {            
            label1.Text += ": "+ actual.nomUsu +"\nConectado";
            label1.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            label2.Visible = false;
            txtContraseña.Visible = false;
            txtUsuario.Visible = false;
            Registrarse.Visible = false;
            btnLogin.Visible = false;
            btnLogout.Location = btnLogin.Location;
            btnLogout.Visible = true;
        }
    }
}

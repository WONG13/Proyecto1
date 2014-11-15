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
        cerrarSesion logout;
        public LoginComponent()
        {
            InitializeComponent();
        }

        public void setDelegado(MainForm f)
        {
            cargarEnMainForm=new cargarComponentes(f.loadComponentsByUser);
            logout = new cerrarSesion(f.Logout);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MetodoLogin();
        }

        private void MetodoLogin()
        {
            if (Validar())
            {
                Usuario user = Usuario.getUsuarioFromDB(txtUsuario.Text, -1);
                if (user != null)
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
            label3.Location = label1.Location;
            label3.Text = "Usuario: " + actual.nomUsu + "\nConectado";
            label3.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            label3.Visible = true;            
            label1.Visible = false;            
            label2.Visible = false;
            txtContraseña.Visible = false;
            txtUsuario.Visible = false;
            Registrarse.Visible = false;
            btnLogin.Visible = false;
            //btnLogout.Location = btnLogin.Location;
            btnLogout.Visible = true;
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            label1.Visible = true;
            label2.Visible = true;
            txtContraseña.Visible = true;
            txtUsuario.Visible = true;
            btnLogin.Visible = true;
            //btnLogin.Location = btnLogout.Location;
            Registrarse.Visible = true;
            btnLogout.Visible = false;
            label3.Visible = false;
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            logout();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                MetodoLogin();
            }

        }
    }
}

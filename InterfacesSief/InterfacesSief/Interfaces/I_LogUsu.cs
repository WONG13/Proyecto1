using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class I_LogUsu : InterfacesSief.I_FormPlantilla
    {
        public I_LogUsu()
        {
            InitializeComponent();
        }

        private void I_LogUsu_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Usuario u = Usuario.getUsuarioFromDB(txtUsuario.Text,-1);
            //Usuario.Login(txtUsuario.Text, txtContra.Text);
        }
    }
}

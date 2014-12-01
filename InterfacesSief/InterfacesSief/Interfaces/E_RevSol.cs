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
    
    public partial class E_RevSol : UserControl,iModulo
    {
        int x;
        public E_RevSol(int x)
        {
            InitializeComponent();
            this.x = x;
        }


        private void E_RevSol_Load(object sender, EventArgs e)
        {
            i_CapAlu1.setInteresado(Interesado.getInteresadoFromUsuario(x,"",""));
            i_CapAlu1.CargarDatosIniciales();
            i_CapAlu1.OcultarBotones();
            i_CapInt1.OcultarBotones();
            i_CapInt1.cargarDatos(x);//Este es el numero del Interesado
            Interesado inte = Interesado.getInteresadoFromUsuario(x, "", "");
            i_CapDoc1.setUser(inte);
            i_CapDoc1.Inicializar();
            i_CapDoc1.OcultarBotones();

        }

        private void i_CapInt1_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            E_ElaRep ERS = new E_ElaRep();
            ERS.ShowDialog();
        }
    }
}

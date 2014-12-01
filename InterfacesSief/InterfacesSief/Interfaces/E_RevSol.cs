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
        Solicitud sol;
        Interesado inte=null;
        Empleado emp;
        public E_RevSol()
        {
            InitializeComponent();
            //sol = s;
            //sol=Solicitud.getUnaSolicitudFromDB(-1,
        }

        public void setSolicitud(Solicitud s, Interesado i, Empleado e)
        {
            sol = s;
            inte = i;
            emp = e;
        }

        private void E_RevSol_Load(object sender, EventArgs e)
        {
            i_CapAlu1.setInteresado(inte);
            i_CapAlu1.CargarDatosIniciales();
            i_CapAlu1.OcultarBotones();
            i_CapInt1.OcultarBotones();
            i_CapInt1.cargarDatos(inte);//Este es el numero del Interesado
            //Interesado inte = Interesado.getInteresadoFromUsuario(x, "", "");
            i_CapDoc1.setUser(inte);
            i_CapDoc1.Inicializar();
            i_CapDoc1.OcultarBotones();

        }

        private void i_CapInt1_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            E_ElaRep ER = new E_ElaRep();
            ER.setSolicitud(sol, emp);
            //ERS.setSolicitud(
            ER.ShowDialog();
        }
    }
}

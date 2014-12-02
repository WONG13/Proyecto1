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
        Revision rev;
        public E_RevSol()
        {
            InitializeComponent();
            //sol = s;
            //sol=Solicitud.getUnaSolicitudFromDB(-1,
        }

        public void inicializar(Solicitud s, Interesado i, Empleado e)
        {
            sol = s;
            inte = i;
            emp = e;
            rev = Revision.getRevisionFromDB(-1, sol.codSol, "En proceso", emp.getCodigo());
            if (rev == null)
            {
                rev = new Revision(-1, sol.codSol, "En proceso", -1, emp.getCodigo(), DateTime.Now, -1);
                rev.saveRevisionToDB();
                rev = Revision.getRevisionFromDB(-1, sol.codSol, "En proceso", emp.getCodigo());
            }
            
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
            ER.setSolicitud(sol, emp,rev);
            //ERS.setSolicitud(
            ER.ShowDialog();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (radbAprobar.Checked)
            {
                DataTable tabla = Reporte.getTablaReportesFromDB(emp.getCodigo(), rev.codRev);
                if (tabla.Rows.Count == 0)
                {
                    rev.estRev = "Aprobada";
                    rev.fecRev = DateTime.Now;
                    sol.estSol = "Aprobada";
                    if (rev.actualizarRevisionToDB() && sol.ModificarEstadoSolicitud())
                    {
                        MessageBox.Show("Revision registrada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un Error durante el registro de la revision a la Base de Datos");
                    }
                }
                else
                {
                    errproValidar.SetError(radbAprobar, "Existen Reportes de Inconsistencias");
                }
            }
            else if (radbDenegar.Checked)
            {               
                DataTable tabla = Reporte.getTablaReportesFromDB(emp.getCodigo(),rev.codRev);
                if (tabla.Rows.Count > 0)
                {
                    rev.estRev = "Denegada";
                    rev.fecRev = DateTime.Now;
                    sol.estSol = "Denegada";
                    if (rev.actualizarRevisionToDB() && sol.ModificarEstadoSolicitud())
                    {
                        MessageBox.Show("Revision registrada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un Error durante el registro de la revision a la Base de Datos");
                    }
                }
                else
                {
                    errproValidar.SetError(radbDenegar, "No Existen Reportes de Inconsistencias, ¿Olvido crear alguno?");
                } 
            }
        }
    }
}

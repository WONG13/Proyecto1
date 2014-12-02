using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfacesSief
{
    
    public partial class E_ElaRep : Form//UserControl,iModulo
    {
        Dictionary<string, int> tipo;
        public Empleado user;
        public Solicitud sol;
        public Revision rev;
        public int CodSol, CodRev;
        private SqlCommand comando = null;
        private DataTable dTable = null;

        public E_ElaRep()
        {
            InitializeComponent();
            
            //cmbboxTipoReporte.Items.Add
        }

        public void setSolicitud(Solicitud s,Empleado emp)
        {
            sol = s;
            user = emp;  
        }
       
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                rev = new Revision(-1, sol.codSol, "Denegada", -1, user.getCodigo(), DateTime.Now, -1);
                rev.saveRevisionToDB();
                rev = Revision.getRevisionFromDB(-1, sol.codSol, "Denegada", user.getCodigo());
                //tipo=Reporte.getTipoReporte();
                Reporte repo = new Reporte(-1, sol.codSol, rev.codRev, 
                    tipo[cmbboxTipoReporte.Text], InfoReporte.Text, user.getCodigo());
                if (repo.saveReporteToDB())
                {
                    MessageBox.Show("Reporte guardado correctamente");
                }                                    
            }

        }
        public bool Validar()
        {
            if (cmbboxTipoReporte.Text != "")
            {
                if (InfoReporte.Text != "")
                {
                    return true;
                }
            }
            return false;
        }

        private void E_ElaRep_Load(object sender, EventArgs e)
        {
            tipo=Reporte.getTipoReporte();
            foreach(KeyValuePair<string,int> d in tipo)
            {
                cmbboxTipoReporte.Items.Add(d.Key);
            }
            cmbboxTipoReporte.SelectedIndex = 0 ;
        }
    }
}

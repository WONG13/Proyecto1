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

        public void setSolicitud(Solicitud s,Empleado emp,Revision r)
        {
            sol = s;
            user = emp;
            rev = r;
        }
       
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {                
                Reporte repo = new Reporte(-1, sol.codSol, rev.codRev, 
                    tipo[cmbboxTipoReporte.Text], InfoReporte.Text, user.getCodigo());
                if (repo.saveReporteToDB())
                {
                    MessageBox.Show("Reporte guardado correctamente");
                    this.Close();
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
                else
                {
                    errproValidar.SetError(InfoReporte, "Debe de llenar este campo con las especificaciones del reporte");
                }
            }
            else
            {
                errproValidar.SetError(cmbboxTipoReporte, "No se permite un tipo de reporte vacio");
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

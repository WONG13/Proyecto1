using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class E_MosRep : InterfacesSief.I_FormPlantilla, iModulo
    {
        private Empleado user;
        public E_MosRep()
        {
            InitializeComponent();
        }

        public void setEmpleado(Empleado e)
        {
            user = e;
        }

        public void Inicializar()
        { 
            DataTable repos=Reporte.getTablaReportesFromDB(user.getCodigo(),-1);
            dgvReportes.DataSource=repos;
        }
    }
}

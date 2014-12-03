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
    public partial class I_RegistrodeRev : UserControl
    {
        Interesado inter;
        Empleado emp;

        public I_RegistrodeRev()
        {
            InitializeComponent();
        }

        public void inicializar(Interesado i, Empleado e)
        {
            inter = i;
            emp = e;
            if (inter != null && emp == null)
            {
                dgvSolAprovadas.DataSource = Solicitud.getSolicitudTableFromDB(-1, inter.getCodigo(), -1, "Aprobada", -1);
                dgvSolDenegadas.DataSource = Solicitud.getSolicitudTableFromDB(-1, inter.getCodigo(), -1, "Denegada", -1);
            }
            else if (inter == null && emp != null)
            {
                dgvSolAprovadas.DataSource = Solicitud.getSolicitudTableFromDB(-1, -1, -1, "Aprobada",emp.getCodigo());
                dgvSolDenegadas.DataSource = Solicitud.getSolicitudTableFromDB(-1, -1, -1, "Denegada", emp.getCodigo());
            }
            else if (inter != null && emp != null)
            {
                dgvSolAprovadas.DataSource = Solicitud.getSolicitudTableFromDB(-1, inter.getCodigo(), -1, "Aprobada", emp.getCodigo());
                dgvSolDenegadas.DataSource = Solicitud.getSolicitudTableFromDB(-1, inter.getCodigo(), -1, "Denegada", emp.getCodigo());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


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
        int Index;
        private void dgvReportes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = dgvReportes.CurrentRow.Index;
            txtInfoReporte.Text = dgvReportes[4, Index].Value.ToString();

            Consulta();
            string Asunto = tabla.Rows[0][0].ToString();
            txtTipoRep.Text = Asunto;

        }
        DataTable tabla;
        private void Consulta()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT TipRep FROM TipoReporte where CodTipRep=@CodTipRep";
            comando.Parameters.AddWithValue("@CodTipRep", Int16.Parse(dgvReportes[3, Index].Value.ToString()));
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


        }
    }
}

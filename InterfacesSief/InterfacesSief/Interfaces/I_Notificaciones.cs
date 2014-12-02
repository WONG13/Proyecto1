using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace InterfacesSief
{
    public partial class I_Notificaciones : UserControl
    {
       

        public I_Notificaciones()
        {
            InitializeComponent();
        }

        Interesado user;
        public void setInteresado(Interesado i)
        {
            user = Interesado.getInteresadoFromDB(i.getCodigo());
        }
        public void Inicializar()
        {

            ConsultaGrid(user.getCodigo());
            int idSol = Int16.Parse(tabla.Rows[0][0].ToString());
            DataTable repos = Interesado.getTablaNotificacionesFromDB(idSol);
            dataGridView1.DataSource = repos;
        }




        DataTable tabla;
        private void ConsultaGrid(int idint)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT CodSol FROM Solicitudes where CodUsuInt=@CodUsuInt";
            comando.Parameters.AddWithValue("@CodUsuInt", idint);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


        }

        DataTable tabla2;
        private void Consulta()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT TipRep FROM TipoReporte where CodTipRep=@CodTipRep";
            comando.Parameters.AddWithValue("@CodTipRep", Int16.Parse(dataGridView1[3, Index].Value.ToString()));
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            tabla2 = new DataTable();
            adaptador.Fill(tabla2);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


        }

        int Index;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = dataGridView1.CurrentRow.Index;
            txtInfoNotificacion.Text = dataGridView1[4, Index].Value.ToString();

            Consulta();
            string Asunto = tabla2.Rows[0][0].ToString();
            txtTipoRep.Text = Asunto;
        }



    }
}

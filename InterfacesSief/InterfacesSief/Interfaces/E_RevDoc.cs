using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace InterfacesSief
{
    public partial class E_RevDoc : InterfacesSief.I_FormPlantilla ,iModulo
    {
        public LlamarRevision LR;
        private SqlCommand comando = null;
        private DataTable dTable = null;
        public DataTable DatosSolicitudes;
        int Index=-1;
        public static int ID, IDint ;
        public E_RevDoc()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            DatosSolicitudes = new DataTable();
            DatosSolicitudes = ConsultaSolicitud();

            //dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.DataSource = DatosSolicitudes;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].HeaderText = "Nombre del Solicitante";
            dataGridView1.Columns[1].Width = 155; ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if (Index != -1)
            {
                ID = Int16.Parse(dataGridView1[0, Index].Value.ToString());
                IDint = Int16.Parse(dataGridView1[2, Index].Value.ToString());
                ActualizarSolicitud();

                LR(new E_RevSol(IDint));
            }
        }

        private void ActualizarSolicitud()
        {
            comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            //comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText =
                "Update Solicitudes Set CodUsuEmp=@CodUsuEmp where CodSol=@CodSol";
            int E=  Empleado.codUsuEmp;
            comando.Parameters.AddWithValue("@CodUsuEmp", E);
            comando.Parameters.AddWithValue("@CodSol", ID);


            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }




        private DataTable ConsultaSolicitud()
        {         
            comando = new SqlCommand();
            dTable = new DataTable();

            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select CodSol, NomInt, s.CodUsuInt from Solicitudes s join Interesados i on i.CodUsuInt=s.CodUsuInt";
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dTable);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            return dTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Index=dataGridView1.CurrentRow.Index;

        }













    }
}

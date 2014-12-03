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
    public partial class E_RevDoc : InterfacesSief.I_FormPlantilla ,iModulo
    {
        public LlamarRevision LR;
        private SqlCommand comando = null;
        private DataTable dTable = null;
        public DataTable DatosSolicitudes;
        Empleado user;
        int Index=-1;
        public int ID, IDint ;
        public E_RevDoc()
        {
            InitializeComponent();
            
        }

        public void setEmpleado(Empleado emp)
        {
            user = emp;
        }

        public void Inicio()
        {
            DatosSolicitudes = new DataTable();
            DatosSolicitudes = Solicitud.getSolicitudTableFromDB(-1, -1, -1, "Pendiente", user.getCodigo()); //ConsultaSolicitud();
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
                ID = int.Parse(dataGridView1[0, Index].Value.ToString());
                IDint = int.Parse(dataGridView1[2, Index].Value.ToString());
                ActualizarSolicitud();

                Solicitud sol = Solicitud.getUnaSolicitudFromDB(ID, IDint, -1, "Pendiente", -1);
                E_RevSol ERS = new E_RevSol();
                ERS.inicializar(sol, Interesado.getInteresadoFromDB(IDint),user);
                LR(ERS);
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
            //dataGridView1.CurrentRow;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Index = dataGridView1.CurrentRow.Index;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = dataGridView1.CurrentRow.Index;
        }













    }
}

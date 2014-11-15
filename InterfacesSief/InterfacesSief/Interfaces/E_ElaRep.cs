using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace InterfacesSief
{
    
    public partial class E_ElaRep : UserControl,iModulo
    {
        public int CodSol, CodRev;
        private SqlCommand comando = null;
        private DataTable dTable = null;

        public E_ElaRep()
        {
            InitializeComponent();
        }

        public string Reporte;
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { Reporte = textBox1.Text; }

        }


        private void InsertarReporte()
        
        {

            comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();

            comando.CommandText =
                "Insert into Reportes(CodRep, CodSol, , CodRev, InfRep )" +
                "Values (@CodRep, @CodSol, @CodRev, @InfRep)";

            //comando.Parameters.AddWithValue("@CodRep",  );
            //comando.Parameters.AddWithValue("@CodSol", );
            //comando.Parameters.AddWithValue("@CodRev", );
            //comando.Parameters.AddWithValue("@InfRep", );
         

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}

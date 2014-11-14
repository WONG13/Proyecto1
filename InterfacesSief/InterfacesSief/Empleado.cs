using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace InterfacesSief
{
    class Empleado:Usuario
    {
        public static int codUsuEmp;
        private string nomEmp;
        private string puesto;
        
        public Empleado(int codigo,string NomUsu, string PerUsu, string nombre, string puesto):
            base(codigo,NomUsu,null,PerUsu)
        {            
            codUsuEmp = codigo;     
            nomEmp = nombre;
            this.puesto = puesto;

        }


        internal static Usuario getEmpleadoFromUsuario(int codUsu, string nomUsu, string perUsu)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM Empleados where CodUsu=@CodUsu";
            comando.Parameters.AddWithValue("@CodUsu", codUsu);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            Empleado i;
            if (tabla.Rows.Count > 0)
            {
                i = new Empleado(tabla.Rows[0].Field<int>("CodUsuEmp"), nomUsu, perUsu,
                                             tabla.Rows[0].Field<string>("NomEmp"),
                                             tabla.Rows[0].Field<string>("PueEmp"));

            }
            else
                i = null;
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace InterfacesSief
{
    class Interesado: Usuario
    {        
        private string nomInt;
        private string dirInt;
        private string telInt;
        private string corInt;
        public Interesado()
        { }

        public Interesado(int codigo,string NomUsu, string PerUsu, string nombre, string direccion, string telefono, string correo):
            base(codigo,NomUsu,null,PerUsu)
        {
            Usuario temp = getUsuarioFromDB("", codigo);
            codUsu = codigo;     
            nomInt = nombre;
            dirInt = direccion;
            telInt = telefono;
            corInt = correo;
        }

        public static Interesado getInteresadoFromUsuario(int codUsu, string nomUsu, string perUsu)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM Interesados where CodUsuInt=@CodUsu";
            comando.Parameters.AddWithValue("@CodUsu", codUsu);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            Interesado i;
            if (tabla.Rows.Count > 0)
            {
                i = new Interesado(tabla.Rows[0].Field<int>("CodUsuInt"),nomUsu,perUsu,
                                             tabla.Rows[0].Field<string>("NomInt"),
                                             tabla.Rows[0].Field<string>("DirInt"),
                                             tabla.Rows[0].Field<string>("TelInt"),
                                             tabla.Rows[0].Field<string>("CorInt"));
            }
            else
                i = null;
            return i;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InterfacesSief
{
    public class Interesado: Usuario
    {
        public static int CodInt;
        private string nomInt;
        private string dirInt;
        private string telInt;
        private string corInt;
        public Interesado()
        { }

        public Interesado(int codigo,string NomUsu, string PerUsu, string nombre, string direccion, string telefono, string correo):
            base(codigo,NomUsu,null,PerUsu)
        {            
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
                CodInt = tabla.Rows[0].Field<int>("CodUsuInt");


            }
            else
                i = null;
            return i;
        }

        public static Interesado getInteresadoFromDB(int codUsu)
        {
            return getInteresadoFromUsuario(codUsu, "", "");
        }

        public string getNombre()
        {
            return nomInt;
        }

        public string getDireccion()
        {
            return dirInt;
        }

        public string getCorreo()
        {
            return corInt;
        }

        public string getTelefono()
        {
            return telInt;
        }

        public bool ActualizarToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "UPDATE Interesados SET NomInt=@NomInt,"+
                                                         "DirInt=@DirInt,"+
                                                         "CorInt=@CorInt,"+ 
                                                         "TelInt=@TelInt WHERE CodUsuInt=@CodUsuInt";
            comando.Parameters.AddWithValue("@NomInt", nomInt);
            comando.Parameters.AddWithValue("@DirInt", dirInt);
            comando.Parameters.AddWithValue("@CorInt", corInt);
            comando.Parameters.AddWithValue("@TelInt", telInt);
            comando.Parameters.AddWithValue("@CodUsuInt", getCodigo());
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar los datos: " + e.Message);
                return false;               
            }
            return true;
        }

        public bool CreateInteresadoToDB(int CodUsu)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"INSERT INTO Interesados (CodUsuInt,NomInt,DirInt,CorInt,TelInt)
                                              VALUES (@CodUsuInt,@NomInt, @DirInt, @CorInt,@TelInt)";
            comando.Parameters.AddWithValue("@NomInt", nomInt);
            comando.Parameters.AddWithValue("@DirInt", dirInt);
            comando.Parameters.AddWithValue("@CorInt", corInt);
            comando.Parameters.AddWithValue("@TelInt", telInt);
            comando.Parameters.AddWithValue("@CodUsuInt", CodUsu);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Crear Interesado y guardar los datos: " + e.Message);
                return false;
            }
            return true;
        }
    }
}

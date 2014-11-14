using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace InterfacesSief
{
    public class Usuario
    {
        protected int codUsu;
        public string nomUsu;
        private string contUsu;        
        private string perUsu;
        public Usuario()
        {}



        public Usuario(int numero, string nombre, string contraseña, string permiso)
        {
            codUsu = numero;
            nomUsu = nombre;
            contUsu = contraseña;
            perUsu = permiso;
        }

        public Usuario abrirSesion()
        {
            Usuario result=new Usuario();
            switch (perUsu)
            {
                case "Interesado":
                    result = Interesado.getInteresadoFromUsuario(codUsu,nomUsu,perUsu); 
                    break;
                case "Empleado":
                    result = Empleado.getEmpleadoFromUsuario(codUsu, nomUsu, perUsu); 
                    break;
                case "Lider":
                    break;
            }
            return result;
            
        }

        public bool comprobarContraseña(string contraseña, string confirmacion)
        {
            if (contraseña == confirmacion)
                return true;
            else
                return false;
        }

        public static Usuario getUsuarioFromDB(string nombre, int codigo)
        {
            SqlCommand comando=new SqlCommand();
            comando.Connection=Conexion.ObtenerConexion();
            if (codigo < 0)
            {
                comando.CommandText = "SELECT * FROM Usuarios U WHERE U.NomUsu=@NomUsu";
                comando.Parameters.AddWithValue("@NomUsu", nombre);
            }
            else if (nombre == "")
            {
                comando.CommandText = "SELECT * FROM Usuarios U WHERE U.CodUsu=@CodUsu";
                comando.Parameters.AddWithValue("@CodUsu", codigo);
            }
            else
                return null;

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            
            DataTable tabla=new DataTable();           
            adaptador.Fill(tabla);

            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Fallo en la conexion>> "+
                e.Message.ToString());
            }
            //return tabla;
            Usuario u;
            if (tabla.Rows.Count > 0)
            {
                u = new Usuario(tabla.Rows[0].Field<int>("CodUsu"),
                                        tabla.Rows[0].Field<string>("NomUsu"),
                                        tabla.Rows[0].Field<string>("ConUsu"),
                                        tabla.Rows[0].Field<string>("PerUsu"));
            }
            else
                u = null;
            return u;
        }

        public bool getAcceso(string contraseña)
        {
            return comprobarContraseña(contraseña, contUsu);                
        }

        public string[] Datos()
        {
            string[] temp = new string[3];
            temp[0] = codUsu.ToString();
            temp[1] = nomUsu;
            temp[2] = perUsu;
            return temp;
        }

        public int getCodigo()
        {
            return codUsu;
        }

        public string getPermisos()
        {
            return perUsu;
        }

    }
}

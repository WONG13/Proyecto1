using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace InterfacesSief
{
    public class Escuela
    {
        public int codEsc;
        public string nomEsc;
        string dirEsc;
        string claEsc;
        public int codNiv;

        public Escuela(int CodEsc, string NomEsc, string DirEsc, string ClaEsc, int CodNiv)
        {
            codEsc = CodEsc; nomEsc = NomEsc; dirEsc = DirEsc; claEsc = ClaEsc; codNiv = CodNiv;
        }

        public static List<Escuela> getEscuelasFromDB(int CodEsc, string NomEsc, string ClaEsc, int CodNiv)
        {
            List<Escuela> escuelas = new List<Escuela>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM Escuelas E";
            if (CodEsc >= 0 || NomEsc != "" || ClaEsc != "" || CodNiv >= 0)
            {
                comando.CommandText += " where ";
                if (CodEsc >= 0)
                {
                    comando.CommandText += " E.CodEsc=@CodEsc";
                    comando.Parameters.AddWithValue("@CodEsc", CodEsc);
                }
                if (NomEsc !="")
                {
                    if (CodEsc >= 0)
                        comando.CommandText += " AND ";
                    comando.CommandText += " E.NomEsc=@NomEsc";
                    comando.Parameters.AddWithValue("@NomEsc", NomEsc);
                }
                if (ClaEsc != "")
                {
                    if (CodEsc >= 0 || NomEsc!="")
                        comando.CommandText += " AND ";
                    comando.CommandText += " E.ClaEsc=@ClaEsc";
                    comando.Parameters.AddWithValue("@ClaEsc", ClaEsc);
                }
                if (CodNiv >= 0)
                {
                    if (CodEsc >= 0 || NomEsc != "" || ClaEsc != "")
                        comando.CommandText += " AND ";
                    comando.CommandText += " E.CodNiv=@CodNiv";
                    comando.Parameters.AddWithValue("@CodNiv", CodNiv);
                }
            }
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al bucar los Datos de la Escuela en la base de datos: " + e.Message);
                return null;
            }
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow registro in tabla.Rows)
                {
                    int _CodEsc = registro.Field<int>("CodEsc");
                    string _NomEsc = registro.Field<string>("NomEsc");
                    string _DirEsc = registro.Field<string>("DirEsc");
                    string _ClaEsc = registro.Field<string>("ClaEsc");
                    int _CodNiv = registro.Field<int>("CodNiv");
                    escuelas.Add(new Escuela(_CodEsc, _NomEsc, _DirEsc, _ClaEsc, _CodNiv));
                }
                return escuelas;
            }
            else
                return null;
        }

        public static Escuela getEscuelaFromDB(int _CodEsc, string _NomEsc, string _ClaEsc, int _CodNiv)
        {
            List<Escuela> e=getEscuelasFromDB(_CodEsc, _NomEsc, _ClaEsc, _CodNiv);
            if (e != null)
            {
                if (e.Count >= 0)
                {
                    return e[0];
                }
                else
                    return null;
            }
            else
                return null;
            
        }

        //public static 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace InterfacesSief
{
    class NivelEducativo
    {
        public int codNiv;
        public string nivAca;

        public NivelEducativo() { }

        public NivelEducativo(int CodNiv, string NivAca)
        {
            codNiv = CodNiv;
            nivAca = NivAca;
        }

        public static List<NivelEducativo> getNivelesFromDB(int CodNiv,string NivAca)
        {
            List<NivelEducativo> niveles = new List<NivelEducativo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM Nivel N";
            if (CodNiv >= 0 || NivAca != "")
            {
                comando.CommandText += " where ";
                if (CodNiv >= 0)
                {
                    comando.CommandText += " N.CodNiv=@CodNiv";
                    comando.Parameters.AddWithValue("@CodNiv", CodNiv);
                }
                if (NivAca != "")
                {
                    if (CodNiv>= 0)
                        comando.CommandText += " AND ";
                    comando.CommandText += " E.NivAca=@NivAca";
                    comando.Parameters.AddWithValue("@NivAca", NivAca);
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
                MessageBox.Show("Error al bucar los Niveles Educativos en la base de datos: " + e.Message);
                return null;
            }
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow registro in tabla.Rows)
                {
                    int _CodNiv = registro.Field<int>("CodNiv");
                    string _NivAca = registro.Field<string>("NivAca");                    
                    niveles.Add(new NivelEducativo(_CodNiv, _NivAca));
                }
                return niveles;
            }
            else
                return null;
        }

        public static NivelEducativo getNivelFromDB(int CodNiv, string NivAca)
        {
            List<NivelEducativo> lista = getNivelesFromDB(CodNiv, NivAca);
            if (lista != null)
            {
                if (lista.Count >= 0)
                    return lista[0];
                else
                    return null;
            }
            else
                return null;
        }
    }
}

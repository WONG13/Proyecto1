using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace InterfacesSief
{
    class Ficha
    {
        int codSol;
        int codFic;
        int codUsuInt;
        DateTime fecFic;
        string estFic;

        public Ficha()
        { }

        public Ficha(int CodFic, int CodSol, int CodInt, string EstFic, DateTime FecFic)
        {
            codSol = CodSol; codFic = CodFic; codUsuInt = CodInt; estFic = EstFic; fecFic = FecFic;
 
        }

        public bool saveFichaToDB()
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"INSERT INTO Fichas (CodSol, CodInt, EstFic, FecFic)
                                    VALUES (@CodSol, @CodInt, @EstFic, @FecFic)";

            comando.Parameters.AddWithValue("@CodSol", codSol);
            comando.Parameters.AddWithValue("@CodInt", codUsuInt);
            comando.Parameters.AddWithValue("@EstFic", estFic);
            comando.Parameters.AddWithValue("@FecFic", fecFic);
            
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar la Ficha>> " + e.Message);
                return false;
            }
            return true;
        }

        public static Ficha getFichaFromDB(int CodSol, int CodUsuInt)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM Fichas F
                                    WHERE F.CodSol=@CodSol AND F.CodUsuInt=@CodUsuInt";

            if (CodSol > 0)
                comando.Parameters.AddWithValue("@CodSol", CodSol);
            else 
            {
                comando.CommandText = comando.CommandText.Replace("F.CodSol=@CodSol AND", "");
            }
            if (CodUsuInt > 0)
                comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
            else
            {
                comando.CommandText = comando.CommandText.Replace("AND F.CodUsuInt=@CodUsuInt","");
            }
            DataTable tabla=new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar la Ficha>> " + e.Message);
                return null;
            }
            DataRow r=tabla.Rows[0];
            return new Ficha(r.Field<int>("CodFic"),
                             r.Field<int>("CodSol"),
                             r.Field<int>("CodUsuInt"),
                             r.Field<string>("EstFic"),
                             r.Field<DateTime>("FecFic"));
        }

    }
}

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
        public int codSol;
        public int codFic;
        public int codUsuInt;
        public DateTime fecFic;
        public string estFic;

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
            comando.CommandText = @"INSERT INTO Fichas (CodSol, CodUsuInt, EstFic, FecFic)
                                    VALUES (@CodSol, @CodUsuInt, @EstFic, @FecFic)";

            comando.Parameters.AddWithValue("@CodSol", codSol);
            comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt);
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

        public static DataTable getTablaFichaFromDB(int CodSol, int CodUsuInt, string FecFic)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM Fichas F
                                    WHERE F.CodSol=@CodSol AND F.CodUsuInt=@CodUsuInt AND F.FecFic=@FecFic";

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
                comando.CommandText = comando.CommandText.Replace("F.CodUsuInt=@CodUsuInt AND","");
            }
            if (FecFic !="")
                comando.Parameters.AddWithValue("@FecFic", DateTime.Parse(FecFic));
            else
            {
                comando.CommandText = comando.CommandText.Replace("AND F.FecFic=@FecFic", "");
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
            return tabla;
        }

        public static List<Ficha> getFichasFromDB(int CodSol, int CodUsuInt, string FecFic)
        {
            List<Ficha> F = new List<Ficha>();
            DataTable tabla = getTablaFichaFromDB(CodSol, CodUsuInt, FecFic);
            if(tabla!=null)
            foreach (DataRow r in tabla.Rows)
            {
                F.Add(new Ficha(r.Field<int>("CodFic"),
                                r.Field<int>("CodSol"),
                                r.Field<int>("CodUsuInt"),
                                r.Field<string>("EstFic"),
                                r.Field<DateTime>("FecFic")));
            }
            return F;
        }

        public static DateTime getDiaCita()
        {
            DateTime hoy = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,8,0,0);
            DateTime cita=hoy.AddDays(14);
            cita = ComprobarDiaHabil(cita);
            cita = ComprobarHoraHabil(cita);
            return cita;
        }

        public static DateTime ComprobarDiaHabil(DateTime cita)
        {
            while (cita.DayOfWeek == DayOfWeek.Saturday || cita.DayOfWeek == DayOfWeek.Sunday)
            {
                cita.AddDays(1);
            }
            return cita;
        }

        public static DateTime ComprobarHoraHabil(DateTime cita)
        {
            List<Ficha> temp = getFichasFromDB(-1, -1, cita.ToString());
            while (temp.Count != 0)
            {
                cita=cita.AddMinutes(10);                
                if (cita.Hour == 12)
                {
                    cita = new DateTime(cita.Year, cita.Month, cita.Day + 1, 8, 0, 0);
                    cita = ComprobarDiaHabil(cita);
                }
                temp = getFichasFromDB(-1, -1, cita.ToString());
            }
            return cita;
        }

    }
}

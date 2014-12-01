using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InterfacesSief.ClasesPrimarias
{
    class Revision
    {

        public int codRev;
        public int	codSol;
        public string	estRev;
        public int codMon;
        public int codUsuEmp;
        public DateTime fecRev;
        public int codFic;
        public Revision() { }

        public Revision(int CodRev, int CodSol, string EstRev, int CodMon, int CodUsuEmp, DateTime FecRev, int CodFic)
        {
            codRev= CodRev;
            codSol=CodSol;
            estRev=EstRev;
            codMon=CodMon;
            codUsuEmp=CodUsuEmp;
            fecRev=FecRev;
            codFic=CodFic;
        }

        public static DataTable getRevisionesFromDB(int CodRev, int CodSol, string EstRev, int CodUsuEmp)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM Revisiones R ";
            if (CodRev>0 || CodSol>0 || EstRev!="" || CodUsuEmp>0 )
                comando.CommandText += " where ";
            if (CodRev > 0)
            {
                comando.CommandText += " R.CodRev=@CodRev";
                comando.Parameters.AddWithValue("@CodRev", CodRev);
                if (CodSol>0 || EstRev!="" || CodUsuEmp>0 )
                    comando.CommandText += " AND";
            }
            if (CodSol > 0 )
            {
                comando.CommandText += " R.CodSol =@CodSol ";
                comando.Parameters.AddWithValue("@CodSol ", CodSol);
                if (EstRev != "" || CodUsuEmp > 0)
                    comando.CommandText += " AND";
            }
            if (EstRev != "")
            {
                comando.CommandText += " R.EstRev=@EstRev";
                comando.Parameters.AddWithValue("@EstRev", EstRev);
                if (CodUsuEmp > 0)
                    comando.CommandText += " AND";
            }
            if (CodUsuEmp > 0)
            {
                comando.CommandText += " R.CodUsuEmp=@CodUsuEmp";
                comando.Parameters.AddWithValue("@CodUsuEmp", CodUsuEmp);
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
                MessageBox.Show("Error al bucar al Alumno en la base de datos: " + e.Message);
                return null;
            }
            return tabla;
        }

        public bool saveRevisionToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"INSERT INTO Revisiones (CodSol, EstRev, CodMon,  CodEmp,  FecRev, CodFic)
                                    VALUES (@CodSol, @EstRev, @CodMon, @CodUsuEmp, @FecRev, @CodFic)";
          
            comando.Parameters.AddWithValue("@CodSol ", codSol);
            comando.Parameters.AddWithValue("@EstRev ", estRev);
            comando.Parameters.AddWithValue("@CodMon ", codMon);
            comando.Parameters.AddWithValue("@CodEmp ", codUsuEmp);
            comando.Parameters.AddWithValue("@FecRev ", fecRev);
            comando.Parameters.AddWithValue("@CodFic ", codFic);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar las Revisiones>> "+e.Message);
                return false;
            }
            return true;
        }
    }
}

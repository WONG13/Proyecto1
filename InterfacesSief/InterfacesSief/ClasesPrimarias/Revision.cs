using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InterfacesSief
{
    public class Revision
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

        public static Revision getRevisionFromDB(int CodRev, int CodSol, string EstRev, int CodUsuEmp)
        {
            DataTable tabla=getRevisionesFromDB(CodRev,CodSol,EstRev,CodUsuEmp);
            Revision rev;
            if (tabla.Rows.Count > 0)
            {
                int _CodMon=-1, _CodFic=-1;
                try
                {
                    _CodMon = tabla.Rows[0].Field<int>("CodMon");
                    _CodFic = tabla.Rows[0].Field<int>("CodFic");
                }
                catch (Exception)
                {
 
                }
                rev = new Revision(tabla.Rows[0].Field<int>("CodRev"),
                                      tabla.Rows[0].Field<int>("CodSol"),
                                      tabla.Rows[0].Field<string>("EstRev"),
                                      _CodMon,
                                      tabla.Rows[0].Field<int>("CodUsuEmp"),
                                      tabla.Rows[0].Field<DateTime>("FecRev"),
                                      _CodFic);
                return rev;
            }
            else
            {
                MessageBox.Show("Error al cargar Revision de la Base de Datos");
                return null;
            }
        }

        public bool saveRevisionToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"INSERT INTO Revisiones (CodSol, EstRev, CodMon,  CodUsuEmp,  FecRev, CodFic)
                                    VALUES (@CodSol, @EstRev, @CodMon, @CodUsuEmp, @FecRev, @CodFic)";

            if (codMon > 0)
            {
                comando.Parameters.AddWithValue("@CodMon ", codMon);
            }
            else
            {
                comando.CommandText=comando.CommandText.Replace(", CodMon", "");
                comando.CommandText=comando.CommandText.Replace(", @CodMon", "");
            }
            comando.Parameters.AddWithValue("@CodSol ", codSol);
            comando.Parameters.AddWithValue("@EstRev ", estRev);
            comando.Parameters.AddWithValue("@CodUsuEmp ", codUsuEmp);
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

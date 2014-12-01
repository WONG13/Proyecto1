using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace InterfacesSief
{
    class Reporte
    {
        int codRep;		
        int codSol;	
        int codRev;	
        int codTipRep;	
        string infRep;
        int codUsuEmp;

        public Reporte(int CodRep, int CodSol, int CodRev, int CodTipRep, string InfRep, int CodUsuEmp)
        {
            codRep = CodRep; codSol = CodSol; codRev = CodRev; codTipRep = CodTipRep; infRep = InfRep;
            codUsuEmp = CodUsuEmp;
        }

        public bool saveReporteToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"INSERT INTO Reportes (CodSol, CodRev, CodTipRep, InfRep, CodUsuEmp)
                                    VALUES (@CodSol, @CodRev, @CodTipRep, @InfRep, @CodUsuEmp)";

            //comando.Parameters.AddWithValue("@CodRep ", codRep);
            comando.Parameters.AddWithValue("@CodSol", codSol);
            comando.Parameters.AddWithValue("@CodRev", codRev);
            comando.Parameters.AddWithValue("@CodTipRep ", codTipRep);
            comando.Parameters.AddWithValue("@InfRep", infRep);
            comando.Parameters.AddWithValue("@CodUsuEmp", codUsuEmp);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar el Reporte>> " + e.Message);
                return false;
            }
            return true;
 
        }

        public static DataTable getTablaTipoReporte()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM TipoReporte";
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
                MessageBox.Show("Error al cargar los tipos de Reporte>> " + e.Message);
                return null;
            }
            return tabla; 
        }

        public static Dictionary<string,int> getTipoReporte()
        {
            Dictionary<string, int> tipos = new Dictionary<string, int>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM TipoReporte";
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
                MessageBox.Show("Error al cargar los tipos de Reporte>> " + e.Message);
                return null;
            }
            foreach (DataRow r in tabla.Rows)
            {
                tipos.Add(r.Field<string>("TipRep"), r.Field<int>("CodTipRep"));
            }
            return tipos;
        }

        public static DataTable getTablaReportesFromDB(int CodUsuEmp)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM Reportes WHERE CodUsuEmp=@CodUsuEmp";
            comando.Parameters.AddWithValue("@CodUsuEmp", CodUsuEmp);
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
                MessageBox.Show("Error al cargar los tipos de Reporte>> " + e.Message);
                return null;
            }
            return tabla; 
        }
        
    }
}

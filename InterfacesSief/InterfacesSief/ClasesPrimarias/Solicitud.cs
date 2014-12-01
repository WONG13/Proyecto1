using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InterfacesSief
{
    class Solicitud
    {
        public int codSol,
                    codAlu,
                    codUsuInt,
                    codUsuEmp;
        public DateTime fecSol;
        public string estSol;

        public Solicitud()
        { }

        public Solicitud(int CodSol, int CodAlu, int CodUsuInt, int CodUsuEmp, DateTime FecSol, string EstSol)
        {
            codSol = CodSol; codAlu = CodAlu; codUsuEmp = CodUsuEmp;
            fecSol = FecSol; estSol = EstSol; codUsuInt = CodUsuInt;
        }

        public static DataTable getSolicitudTableFromDB(int CodSol, int CodUsuInt, int CodAlu, string EstSol, int CodUsuEmp)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM Solicitudes WHERE ";
            if (CodAlu != -1)
            {
                comando.CommandText += "@CodSol=CodSol ";
                if (CodAlu > 0 || CodUsuInt > 0 || EstSol != "" || CodUsuEmp>0)
                    comando.CommandText += "AND ";
                comando.Parameters.AddWithValue("@CodSol", CodSol);
            }
            if (CodUsuInt != -1)
            {
                comando.CommandText += "@CodUsuInt=CodUsuInt ";
                if (CodAlu > 0 || EstSol != "" || CodUsuEmp > 0)
                    comando.CommandText += "AND ";
                comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
            }
            if (CodAlu != -1)
            {
                comando.CommandText += "@CodAlu=CodAlu ";
                if (EstSol != "" || CodUsuEmp > 0)
                    comando.CommandText += "AND ";
                comando.Parameters.AddWithValue("@CodAlu", CodAlu);
            }
            if (EstSol != "")
            {
                comando.CommandText += "@EstSol=EstSol ";
                if (CodUsuEmp > 0)
                    comando.CommandText += " AND ";
                comando.Parameters.AddWithValue("@EstSol", EstSol);
            }
            if (CodUsuEmp>0)
            {
                comando.CommandText += "@CodUsuEmp=CodUsuEmp ";
                comando.Parameters.AddWithValue("@CodUsuEmp", CodUsuEmp);
            }

            DataTable tabla = new DataTable();
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
                MessageBox.Show("Error al cargar las Solicitudes desde la base de datos: " + e.Message);
                return null;
            }
            return tabla;
        }
        
        public static List<Solicitud> getSolicitudFromDB(int CodSol, int CodUsuInt, int CodAlu, string EstSol, int CodUsuEmp)
        {
            DataTable tabla = getSolicitudTableFromDB(CodSol, CodUsuInt, CodAlu, EstSol,CodUsuEmp);
            List<Solicitud> sol=new List<Solicitud>();
            foreach(DataRow r in tabla.Rows)
            {
                int _codUsuEmp = -1;
                try
                {
                    _codUsuEmp=r.Field<int>("CodUsuEmp");
                }
                catch(Exception)
                {
                    _codUsuEmp=-1;
                }

                Solicitud nueva = new Solicitud(r.Field<int>("CodSol"),
                                                r.Field<int>("CodAlu"),
                                                r.Field<int>("CodUsuInt"),
                                                _codUsuEmp,
                                                r.Field<DateTime>("FecSol"),
                                                r.Field<string>("EstSol"));

                sol.Add(nueva);            
            }
            return sol;
        }

        public static Solicitud getUnaSolicitudFromDB(int CodSol, int CodUsuInt, int CodAlu, string EstSol, int CodUsuEmp)
        {
            List<Solicitud> sol = getSolicitudFromDB(CodSol, CodUsuInt, CodAlu, EstSol, CodUsuEmp);
            if (sol.Count > 0)
                return sol[0];
            else
                return null;
        }

        public bool saveSolicitudToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"INSERT INTO Solicitudes (CodUsuInt, CodAlu, FecSol, EstSol) 
                                                        VALUES (@CodUsuInt, @CodAlu, @FecSol, @EstSol)";
            
            comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt);            
            comando.Parameters.AddWithValue("@CodAlu", codAlu);
            comando.Parameters.AddWithValue("@FecSol", fecSol);
            comando.Parameters.AddWithValue("@EstSol", estSol);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Enviar la Solicitud: " + e.Message);
                return false;
            }
            return true;
 
        }

        public bool ModificarEstadoSolicitud()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"UPDATE Solicitudes SET EstSol=@EstSol WHERE CodSol=@CodSol";

            comando.Parameters.AddWithValue("@CodSol", codSol);                        
            comando.Parameters.AddWithValue("@EstSol", estSol);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cambiar Estado de la Solicitud: " + e.Message);
                return false;
            }
            return true;
 
        }

        public bool SetEmpleado()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"UPDATE Solicitudes SET CodUsuEmp=@CodUsuEmp WHERE CodSol=@CodSol";
            codSol=Solicitud.getUnaSolicitudFromDB(-1,codUsuInt,-1,"Pendiente",-1).codSol;
            comando.Parameters.AddWithValue("@CodSol", codSol);
            comando.Parameters.AddWithValue("@CodUsuEmp", codUsuEmp);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al asignar Empleado para la Revision: " + e.Message);
                return false;
            }
            return true;
        }
    }
}

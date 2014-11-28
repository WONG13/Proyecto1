using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace InterfacesSief
{
    public class Alumno
    {
        public int codAlu;
        public string nomAlu;
        public DateTime nacAlu;        
        public int codEsc; 
        public double proAlu;
        public int graAca;
        int codUsuInt;

        public Alumno() { }

        public Alumno(int CodAlu, string NomAlu, DateTime NacAlum, int CodEsc, double ProAlu, int GraAca, int CodUsuInt)
        {
            codAlu = CodAlu; nomAlu = NomAlu; nacAlu = NacAlum;
            codEsc = CodEsc; proAlu = ProAlu; graAca = GraAca; codUsuInt = CodUsuInt;
        }

        public static Alumno getAlumnosFromDB(int CodAlu, string NomAlu, int CodUsuInt)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM Alumnos A ";
            if (CodAlu >= 0 || NomAlu != "" || CodUsuInt >= 0)
                comando.CommandText += " where ";
            if (CodUsuInt >= 0)
            {
                comando.CommandText+=" A.CodUsuInt=@CodUsuInt";
                comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
            }
            if (CodAlu >=0)
            {
                comando.CommandText += " AND A.CodAlu=@CodAlu";
                comando.Parameters.AddWithValue("@CodAlu", CodAlu);
            }
            if (NomAlu != "")
            {
                comando.CommandText += " AND A.NomAlu=@NomAlu";
                comando.Parameters.AddWithValue("@NomAlu", NomAlu);
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
                MessageBox.Show("Error al bucar al Alumno en la base de datos: "+e.Message);
                return null;
            }
            Alumno i;
            if (tabla.Rows.Count > 0)
            {
                int _CodAlu = tabla.Rows[0].Field<int>("CodAlu");
                string _NomAlu=tabla.Rows[0].Field<string>("NomAlu");
                DateTime _NacAlu=tabla.Rows[0].Field<DateTime>("NacAlu");
                int _CodEsc;
                try
                {
                    _CodEsc = tabla.Rows[0].Field<int>("CodEsc");
                }
                catch (Exception)
                {
                    _CodEsc = -1;
                }
                double _ProAlu=tabla.Rows[0].Field<double>("ProAlu");
                int _GraAca=tabla.Rows[0].Field<int>("GraAca");
                int _CodUsuInt = tabla.Rows[0].Field<int>("CodUsuInt");

                i = new Alumno(_CodAlu, _NomAlu, _NacAlu, _CodEsc, _ProAlu, _GraAca, _CodUsuInt);                               
                return i;
            }
            else
                return null;
        }

        public int CreateAlumnoToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            if (codEsc > 0)
            {
                comando.CommandText = @"INSERT INTO Alumnos (NomAlu,NacAlu,CodEsc,ProAlu,GraAca, CodUsuInt)
                                    VALUES (@NomAlu,@NacAlu,@CodEsc,@ProAlu,@GraAca, @CodUsuInt)";
                comando.Parameters.AddWithValue("@NomAlu", nomAlu);
                comando.Parameters.AddWithValue("@NacAlu", nacAlu);
                comando.Parameters.AddWithValue("@CodEsc", codEsc);
                comando.Parameters.AddWithValue("@ProAlu", proAlu);
                comando.Parameters.AddWithValue("@GraAca", graAca);
                comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt);
            }
            else
            {
                comando.CommandText = @"INSERT INTO Alumnos (NomAlu,NacAlu,ProAlu,GraAca, CodUsuInt)
                                    VALUES (@NomAlu,@NacAlu,@ProAlu,@GraAca, @CodUsuInt)";
                comando.Parameters.AddWithValue("@NomAlu", nomAlu);
                comando.Parameters.AddWithValue("@NacAlu", nacAlu);                
                comando.Parameters.AddWithValue("@ProAlu", proAlu);
                comando.Parameters.AddWithValue("@GraAca", graAca);
                comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt); 
            }
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Guardar datos del Alumno en la base de datos: " + e.Message);
                return -1;
            }
            //Terminado el guardado
            comando.CommandText = @"SELECT CodAlu FROM Alumnos WHERE @NomAlu=NomAlu AND @CodUsuInt=CodUsuInt";
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            int CodAlu=-1;
            if (tabla.Rows.Count > 0)
                CodAlu = tabla.Rows[0].Field<int>("CodAlu");
            return CodAlu;
            //Regresa el CodAlu con que fue guardado
        }

        public bool ActualizarToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            if (codEsc > 0)
            {
                comando.CommandText = @"UPDATE Alumnos SET NomAlu=@NomAlu, NacAlu=@NacAlu,CodEsc=@CodEsc,
                                                        ProAlu=@ProAlu,GraAca=@GraAca 
                                                        where CodAlu=@CodAlu";
                comando.Parameters.AddWithValue("@NomAlu", nomAlu);
                comando.Parameters.AddWithValue("@NacAlu", nacAlu);
                comando.Parameters.AddWithValue("@CodEsc", codEsc);
                comando.Parameters.AddWithValue("@ProAlu", proAlu);
                comando.Parameters.AddWithValue("@GraAca", graAca);
                comando.Parameters.AddWithValue("@CodAlu", codAlu);
            }
            else
            {
                comando.CommandText = @"UPDATE Alumnos SET NomAlu=@NomAlu, NacAlu=@NacAlu,
                                                        ProAlu=@ProAlu,GraAca=@GraAca
                                                        where CodAlu=@CodAlu";
                comando.Parameters.AddWithValue("@NomAlu", nomAlu);
                comando.Parameters.AddWithValue("@NacAlu", nacAlu);                
                comando.Parameters.AddWithValue("@ProAlu", proAlu);
                comando.Parameters.AddWithValue("@CodAlu", codAlu); 
            }
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Guardar datos del Alumno en la base de datos: " + e.Message);
                return false;
            }
            return true;

        }
    }
}

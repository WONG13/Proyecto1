using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace InterfacesSief.ClasesPrimarias
{
    class AdminReviciones
    {
        static int RevisionesPorEmpleado = 5;

        public static bool AsignarEmpleado(Solicitud sol)
        {
            try
            {                
                sol.codUsuEmp = BuscarEmpleado();
                if (sol.codUsuEmp == -1)
                {
                    MessageBox.Show("No hay personal dsponible para atender so solicitud intentelo mas tarde>> ");
                    return false;
                }
                sol.SetEmpleado();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al asignar un empleado para la revision " + e.Message);
                return false;
            }
            return true;
        }

        public static int BuscarEmpleado()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT * FROM (
                                    SELECT (
                                    SELECT COUNT (*) FROM Solicitudes S
                                    WHERE S.EstSol='Pendiente'
                                    AND E.CodUsuEmp=S.CodUsuEmp) AS SolPen,
                                    E.CodUsuEmp, e.NomEmp FROM Empleados E) C
                                    WHERE C.SolPen<@Limite";
            
            comando.Parameters.AddWithValue("@Limite", RevisionesPorEmpleado); 
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
                MessageBox.Show("Error al Enviar la Solicitud: " + e.Message);
                return -1;
            }
            if (tabla.Rows.Count > 0)
            {
                int CodUsuEmp = tabla.Rows[0].Field<int>("CodUsuEmp");
                return CodUsuEmp;
            }
            else
                return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace InterfacesSief
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con =
                new SqlConnection(@"Data Source= LANIX-PC\SQLEXPRESS2008;
                Initial Catalog = Sief; User ID = ConectionPass; Password = 12345");
//                new SqlConnection(@"Data Source= PCWONG\SQLWONG;
//                Initial Catalog = Sief; User ID = sa; Password = 12211429");
            return con;


            // @"server=. \SQLEXPRESS; Initial Catalog=biblioteca; integrated security=true"
        }
    }
}

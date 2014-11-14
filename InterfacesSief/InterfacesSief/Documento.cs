using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
namespace InterfacesSief
{
    class Documento
    {
        private int codDoc;
        private int codUsuInt;
        private int codAlu;
        public string tipDoc, dirDoc;
        private byte[] doc;
        public Bitmap imaDoc;

        public Documento() { }

        public Documento(int CodDoc, int CodUsuInt, int CodAlu, string tipo, byte[] Documento)
        {
            codDoc = CodDoc;
            codUsuInt = CodUsuInt;
            codAlu = CodAlu;
            tipDoc = tipo;
            doc = Documento;
        }

        static public DataTable getDocumentsTypesFromDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM TipoDocumento";

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            return tabla;
        }

        static public List<Documento> getDocumentFromDB(int CodUsuInt, int CodAlu,string tipo, int CodDoc)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            if(CodAlu==-1 && tipo=="" && CodDoc==-1)
            {
            comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD 
                                    where CodUsuInt=@CodUsuInt and C.TipoDoc=TD.CodTipDoc";
            comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
            }
            else if(CodDoc==-1)
            {
                comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD 
                                    where CodUsuInt=@CodUsuInt and C.TipoDoc=TD.CodTipDoc 
                                            AND CodAlu=@CodAlu AND TipoDoc=@tipo";
                comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
                comando.Parameters.AddWithValue("@CodAlu", CodAlu);
                comando.Parameters.AddWithValue("@tipo", tipo);
            }
            else if (CodDoc!=-1)
            {
                comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD 
                                    where CodDoc=@CodDoc and C.TipoDoc=TD.CodTipDoc";
                comando.Parameters.AddWithValue("@CodDoc", CodDoc);
            }


            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            List<Documento> d=new List<Documento>();
            foreach(DataRow DT in tabla.Rows)
            {
                d.Add( new Documento(DT.Field<int>("CodDoc"),
                                    DT.Field<int>("CodUsuInt"),
                                    DT.Field<int>("CodAlu"),
                                    DT.Field<string>("TipoDoc"),
                                    DT.Field<byte[]>("Doc")));                
            }
            return d;
                
        }

        public bool saveDocumentToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
                comando.CommandText = @"insert into Documentos  values (@CodUsuInt,
                                            (SELECT TD.CodTipDoc FROM TipoDocumento TD where TD.TipoDoc=@TipoDoc),
                                            @Doc, @CodAlu)";

                comando.Parameters.AddWithValue("@CodDoc", codDoc);
                comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt);
                comando.Parameters.AddWithValue("@CodAlu", codAlu);
                comando.Parameters.AddWithValue("@TipoDoc", tipDoc);
                comando.Parameters.AddWithValue("@Doc", doc);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                return true;

        }

        public void makeImage()
        {
            imaDoc = (Bitmap)Image.FromStream(new System.IO.MemoryStream(doc)); 
        }
    }
}

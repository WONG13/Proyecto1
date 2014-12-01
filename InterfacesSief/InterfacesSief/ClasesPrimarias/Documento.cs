using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace InterfacesSief
{
    public class Documento
    {
        public int codDoc;
        private int codUsuInt;
        private int codAlu;
        public string tipDoc, dirDoc;
        public int codTipDoc;
        public byte[] doc;
        public Bitmap imaDoc;

        public Documento() { }

        public Documento(int CodDoc, int CodUsuInt, int CodAlu, int CodTipDoc, string tipo, byte[] Documento)
        {
            codDoc = CodDoc;
            codUsuInt = CodUsuInt;
            codAlu = CodAlu;
            codTipDoc = CodTipDoc;
            tipDoc = tipo;
            doc = Documento;
        }

        static public DataTable getDocumentsTypesFromDB(int CodTipDoc)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = "SELECT * FROM TipoDocumento";

            if (CodTipDoc > 0)
            {
                comando.CommandText += " WHERE CodTipDoc=@CodTipDoc";
                comando.Parameters.AddWithValue("@CodTipDoc", CodTipDoc);
            }
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

            return tabla;
        }

//        static public List<Documento> getDocumentListFromDB(int CodUsuInt, int CodAlu,string tipo, int CodDoc)
//        {
//            SqlCommand comando = new SqlCommand();
//            comando.Connection = Conexion.ObtenerConexion();
//            if(CodAlu==-1 && tipo=="" && CodDoc==-1)
//            {
//            comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD 
//                                    where CodUsuInt=@CodUsuInt and C.TipoDoc=TD.CodTipDoc";
//            comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
//            }
//            else if(CodDoc==-1)
//            {
//                comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD 
//                                    where CodUsuInt=@CodUsuInt and C.TipoDoc=TD.CodTipDoc 
//                                            AND CodAlu=@CodAlu AND TipoDoc=@tipo";
//                comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
//                comando.Parameters.AddWithValue("@CodAlu", CodAlu);
//                comando.Parameters.AddWithValue("@tipo", tipo);
//            }
//            else if (CodDoc!=-1)
//            {
//                comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD 
//                                    where CodDoc=@CodDoc and C.TipoDoc=TD.CodTipDoc";
//                comando.Parameters.AddWithValue("@CodDoc", CodDoc);
//            }


//            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
//            DataTable tabla = new DataTable();
//            adaptador.Fill(tabla);

//            comando.Connection.Open();
//            comando.ExecuteNonQuery();
//            comando.Connection.Close();

//            List<Documento> d=new List<Documento>();
//            foreach(DataRow DT in tabla.Rows)
//            {
//                d.Add( new Documento(DT.Field<int>("CodDoc"),
//                                    DT.Field<int>("CodUsuInt"),
//                                    DT.Field<int>("CodAlu"),
//                                    DT.Field<string>("TipoDoc"),
//                                    DT.Field<byte[]>("Doc")));                
//            }
//            return d;
                
//        }

        static public Dictionary<string,Documento> getDocumentFromDB(int CodUsuInt, int CodAlu, string tipo, int CodDoc)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, TD.CodTipDoc, TD.TipoDoc, C.Doc FROM Documentos C, TipoDocumento TD";
            if(CodUsuInt>0 || CodAlu>0 || CodDoc>0 || tipo!="")
            {
                comando.CommandText+=" WHERE ";
                if(CodUsuInt>0)
                {
                    comando.CommandText+=" CodUsuInt=@CodUsuInt ";
                    comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);                    
                }
                if(CodAlu>0)
                {
                    comando.CommandText += " AND CodAlu=@CodAlu";
                    comando.Parameters.AddWithValue("@CodAlu", CodAlu);
                    
                }
                if(CodDoc>0)
                {
                    comando.CommandText += " AND CodDoc=@CodDoc";
                    comando.Parameters.AddWithValue("@CodDoc", CodDoc);
                  
                }
                if (tipo != "")
                {
                    comando.CommandText += " AND CodTipDoc=@CodTipDoc";
                    comando.Parameters.AddWithValue("@tipo", tipo);
                }
                else
                {
                    comando.CommandText += " AND C.CodTipDoc = TD.CodTipDoc ";                    
                }
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
            catch(Exception e)
            {
                
            }
            Dictionary<string, Documento> d = new Dictionary<string, Documento>();
            foreach (DataRow DT in tabla.Rows)
            {                
                Documento doc=new Documento(DT.Field<int>("CodDoc"),
                                    DT.Field<int>("CodUsuInt"),
                                    DT.Field<int>("CodAlu"),
                                    DT.Field<int>("CodTipDoc"),
                                    DT.Field<string>("TipoDoc"),
                                    DT.Field<byte[]>("Doc"));                
                d.Add(doc.tipDoc,doc);
            }
            return d;
        }

        public bool saveDocumentToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"insert into Documentos  values (@CodUsuInt,@Doc, @CodAlu,
                                    (SELECT TD.CodTipDoc FROM TipoDocumento TD where TD.TipoDoc=@TipoDoc))";

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

        public bool updateDocumentToDB()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            comando.CommandText = @"UPDATE Documentos  SET CodUsuInt=@CodUsuInt, Doc=@Doc, CodAlu=@CodAlu,
                                    CodTipDoc=@CodTipDoc WHERE CodDoc=@CodDoc ";

            comando.Parameters.AddWithValue("@CodDoc", codDoc);
            comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt);
            comando.Parameters.AddWithValue("@CodAlu", codAlu);
            comando.Parameters.AddWithValue("@TipoDoc", tipDoc);
            comando.Parameters.AddWithValue("@Doc", doc);
            comando.Parameters.AddWithValue("@CodTipDoc", codTipDoc);
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Actualizar Documento >>" + e.Message);
                return false;
            }
            return true; 
        }

        public void makeImage()
        {
            imaDoc = (Bitmap)Image.FromStream(new System.IO.MemoryStream(doc)); 
        }
    }
}

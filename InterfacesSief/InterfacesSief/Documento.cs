﻿using System;
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

        static public List<Documento> getDocumentFromDB(int CodUsuInt, int CodAlu,string tipo, int CodDoc)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.ObtenerConexion();
            if(CodAlu==-1 && tipo=="" && CodDoc==-1)
            {
            comando.CommandText = "SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, C.TipoDoc, C.Doc FROM Documentos C " +
                                    "where CodUsuInt=@CodUsuInt ";
            comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
            }
            else if(CodDoc==-1)
            {
                comando.CommandText = "SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, C.TipoDoc, C.Doc FROM Documentos C" +
                                        " where CodUsuInt=@CodUsuInt "+
                                            "AND CodAlu=@CodAlu AND TipoDoc=@tipo";
                comando.Parameters.AddWithValue("@CodUsuInt", CodUsuInt);
                comando.Parameters.AddWithValue("@CodAlu", CodAlu);
                comando.Parameters.AddWithValue("@tipo", tipo);
            }
            else if (CodDoc!=-1)
            {
                comando.CommandText = "SELECT C.CodDoc, C.CodUsuInt, C.CodAlu, C.TipoDoc, C.Doc FROM Documentos C "+ 
                                        "where CodDoc=@CodDoc";
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
                comando.CommandText = "insert into Documentos  values (@CodUsuInt,@TipoDoc,(SELECT BulkColumn "+ 
                                       "FROM Openrowset( Bulk @DirDoc, Single_Blob) as img), @CodAlu)";

                comando.Parameters.AddWithValue("@CodDoc", codDoc);
                comando.Parameters.AddWithValue("@CodUsuInt", codUsuInt);
                comando.Parameters.AddWithValue("@CodAlu", codAlu);
                comando.Parameters.AddWithValue("@TipoDoc", tipDoc);
                comando.Parameters.AddWithValue("@DirDoc", dirDoc);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                return true;

        }
    }
}
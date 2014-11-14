using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InterfacesSief
{
    public partial class I_CapDoc : InterfacesSief.I_FormPlantilla
    {
        Usuario user;
        Alumno student;
        List<Documento> listaDoc=new List<Documento>();
        DataTable tipos;
        public I_CapDoc()
        {
            InitializeComponent();
        }

        public void setUser(Usuario u/*, /*Alumno a*/)
        {
            if (u.getPermisos() == "Interesado")
                user = (Interesado)u;
            else if (u.getPermisos() == "Empleado")
                user = (Empleado)u;
            else if (u.getPermisos() == "Lider")
            { /*Falta clase Lider*/}
                //student = a;
        }

        private void I_CapDoc_Load(object sender, EventArgs e)
        {
            listaDoc = Documento.getDocumentFromDB(user.getCodigo(), -1, "", -1);
            tipos=Documento.getDocumentsTypesFromDB();
            int i = 0;
            foreach (DataRow r in tipos.Rows)
            {
                comboBox1.Items.Add(r.Field<string>("TipoDoc"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            //openFileDialog1.InitialDirectory = "C://";
            openFileDialog1.ShowDialog();


            string path = openFileDialog1.FileName;//SafeFileName;
            Bitmap ima = (Bitmap)Image.FromFile(path);
            pictureBox1.Image = ima;
            MemoryStream ms = new MemoryStream();
            ima.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Documento doc = new Documento(0, user.getCodigo(), 1, comboBox1.Text, ms.ToArray());


            if (doc.saveDocumentToDB())
            {
                MessageBox.Show("Guardado Exitosamente");
                listaDoc = Documento.getDocumentFromDB(user.getCodigo(), -1, "", -1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Documento d in listaDoc)
            {

                if (d.tipDoc == comboBox1.Text)
                {
                    if (d.imaDoc == null)
                        d.makeImage();
                    pictureBox1.Image = d.imaDoc;
                }
            }
            
        }
    }
}

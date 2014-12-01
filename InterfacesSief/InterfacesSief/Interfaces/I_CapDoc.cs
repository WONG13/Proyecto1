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
        bool vacio = true;
        Interesado user;
        Alumno student;
        List<Documento> listaDoc=new List<Documento>();
        Dictionary<string, Documento> Doc = new Dictionary<string, Documento>();
        DataTable tipos;
        Bitmap ima = null;
        MemoryStream ms = null;
        
        public I_CapDoc()
        {
            InitializeComponent();            
        }

        public void setUser(Interesado u/*, /*Alumno a*/)
        {
            //if (u.getPermisos() == "Interesado")
            user = u;// (Interesado)u;
            //else if (u.getPermisos() == "Empleado")
              //  user = (Empleado)u;
            //else if (u.getPermisos() == "Lider")
            //{ /*Falta clase Lider*/}
                //student = a;
        }

        private void I_CapDoc_Load(object sender, EventArgs e)
        {
            
        }

        public void Inicializar()
        {
            //listaDoc = Documento.getDocumentFromDB(user.getCodigo(), -1, "", -1);
            Doc = Documento.getDocumentFromDB(user.getCodigo(), -1, "", -1);
            tipos = Documento.getDocumentsTypesFromDB(-1);
            student = Alumno.getAlumnosFromDB(-1, "", user.getCodigo());
            foreach (DataRow r in tipos.Rows)
            {
                comboBox1.Items.Add(r.Field<string>("TipoDoc"));
            }
            comboBox1.SelectedIndex = 0;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            //openFileDialog1.InitialDirectory = "C://";
            openFileDialog1.ShowDialog();
            
            string path = openFileDialog1.FileName;//SafeFileName;
            if (path!="")
            {
                try
                {
                    ima = (Bitmap)Image.FromFile(path);
                }
                catch (Exception _e)
                {
                    MessageBox.Show(@"Error al cargar el Archivo de Imagen, 
                                      Asegurece de que sea .jpg, .png, .bmp>> "
                                    + _e.Message);
                    return;
                }
                pictureBox1.Image = ima;
                ms = new MemoryStream();
                vacio = false;
                ima.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                btnEnviar.Visible = true;
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Doc.ContainsKey(comboBox1.Text))
            {
                if (Doc[comboBox1.Text].imaDoc == null)
                    Doc[comboBox1.Text].makeImage();
                pictureBox1.Image = Doc[comboBox1.Text].imaDoc;
                vacio = false;
            }
            else
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.Clear(Color.White);
                g.DrawString("No se ha cargado la imagen en el sistema",
                    new Font("Arial", 16, FontStyle.Bold),
                    new SolidBrush(Color.Red),
                    new RectangleF(10, 100, pictureBox1.Size.Width - 10, 100));
                vacio = true;
                g = null;
                pictureBox1.Refresh();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ms != null && !vacio)
            {
                if (Doc.ContainsKey(comboBox1.Text))
                {
                    Doc[comboBox1.Text].doc = ms.ToArray();
                    if (Doc[comboBox1.Text].updateDocumentToDB())
                    {
                        Doc[comboBox1.Text].makeImage();
                        MessageBox.Show("Actualizado correctamente");
                    }
                }
                else
                {
                    Documento doc = new Documento(-1, user.getCodigo(), student.codAlu, -1, comboBox1.Text, ms.ToArray());
                    if (doc.saveDocumentToDB())
                    {
                        Doc.Add(doc.tipDoc, doc);
                        MessageBox.Show("Guardado Exitosamente");
                    }
                }
            }
            else
                MessageBox.Show("Aun no ha seleccionado un archivo");
        }

        private void btnVerCompleto_Click(object sender, EventArgs e)
        {            
            Form f = new Form()
            {
                Name=comboBox1.Text,
                Size=pictureBox1.Image.Size,
                BackgroundImage=pictureBox1.Image
            };
            f.ShowDialog();
        }

        public void OcultarBotones()
        {
            btnBuscar.Visible = false;
            btnEnviar.Visible = false;
        }
    }
}

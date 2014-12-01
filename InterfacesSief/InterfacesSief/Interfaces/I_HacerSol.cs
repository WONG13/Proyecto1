using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InterfacesSief.ClasesPrimarias;
namespace InterfacesSief.Interfaces
{
    public partial class I_HacerSol : UserControl
    {
        Interesado user;
        bool _Alumno = false, _Documento = false, _Tutor=false; 
        public I_HacerSol()
        {
            InitializeComponent();
        }

        public void setInteresado(Interesado i)
        {
            user=Interesado.getInteresadoFromDB(i.getCodigo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Solicitud.getSolicitudFromDB(-1, user.getCodigo(), -1, "Pendiente",-1).Count == 0)
            {
                if (_Alumno && _Documento && _Tutor)
                {
                    Solicitud sol = new Solicitud(-1,
                                                  Alumno.getAlumnosFromDB(-1, "", user.getCodigo()).codAlu,
                                                  user.getCodigo(),
                                                  -1,
                                                  DateTime.Now, "Pendiente");
                    if (sol.saveSolicitudToDB())
                    {
                        AdminReviciones.AsignarEmpleado(sol);
                        MessageBox.Show("Solicitud enviada correctamente");
                    }

                }
                else
                    MessageBox.Show("Aun no puede hacer una solicitud hasta que llenar todos los campos");
            }
            else
                MessageBox.Show("Ya hay una Solicitud anterior pendiente de Revision");
        }

        bool ComprobarDatosAlumno(Alumno alum)
        {
            bool verificacion=false;
            if (alum != null)
            {
                if (alum.codEsc > 0 && alum.nomAlu != "" &&
                    alum.graAca > 0 && alum.proAlu > 0 && alum.nacAlu != null)
                {
                    verificacion = true;
                }                                    
            }
            return verificacion;
        }

        bool ComprobarDatosInteresado(Interesado inter)
        {
            if (inter.getNombre() != "" && inter.getCorreo() != "" && inter.getDireccion() != "" &&
                inter.getTelefono() != "")
                return true;
            else
                return false;
        }

        bool ComprobarDatosDocumento(Dictionary<string,Documento> doc)
        {
            DataTable Tipos=Documento.getDocumentsTypesFromDB(-1);
            bool condicion = false;
            foreach (DataRow r in Tipos.Rows)
            {
                condicion = doc.ContainsKey(r.Field<string>("TipoDoc"));
                if (!condicion)
                    return false;
            }
            return true;            
        }

        private void I_HacerSol_Load(object sender, EventArgs e)
        {
            Alumno alum = Alumno.getAlumnosFromDB(-1, "", user.getCodigo());
            Dictionary<string, Documento> doc = Documento.getDocumentFromDB(user.getCodigo(), -1, "", -1);
            //List<Documento> doc = Documento.getDocumentFromDB(user.getCodigo(), -1, "", -1);
            _Alumno = ComprobarDatosAlumno(alum);
            _Documento = ComprobarDatosDocumento(doc);
            _Tutor = ComprobarDatosInteresado(user);

            if (_Alumno)
            {
                pictureBox1.Image = Image.FromFile(@"..\..\Imagenes\palomita.png");
            }
            else
                pictureBox1.Image = Image.FromFile(@"..\..\Imagenes\tacha.png");
            if (_Documento)
            {
                pictureBox2.Image = Image.FromFile(@"..\..\Imagenes\palomita.png");
            }
            else
                pictureBox2.Image = Image.FromFile(@"..\..\Imagenes\tacha.png");
            if (_Tutor)
            {
                pictureBox3.Image = Image.FromFile(@"..\..\Imagenes\palomita.png");
            }
            else
                pictureBox3.Image = Image.FromFile(@"..\..\Imagenes\tacha.png");
            //if()
        }
    }
}

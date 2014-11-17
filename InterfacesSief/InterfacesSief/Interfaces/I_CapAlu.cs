using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace InterfacesSief
{
    partial class I_CapAlu : InterfacesSief.I_FormPlantilla
    {
        Alumno a;
        Escuela esc;
        Interesado user;
        List<NivelEducativo> niveles;
        List<Escuela> lista;
        public I_CapAlu()
        {
            InitializeComponent();
        }

        public void setInteresado(Interesado i)
        {
            user = i;
        }

        public void CargarDatosIniciales()
        {
            a = Alumno.getAlumnosFromDB(-1, "", user.getCodigo());
            esc = Escuela.getEscuelaFromDB(a.codEsc, "", "", -1);

            niveles = NivelEducativo.getNivelesFromDB(-1, "");
            foreach (NivelEducativo n in niveles)
            {
                if (esc.codNiv == n.codNiv)
                {
                    ComboBoxNivel.Text = n.nivAca;
                    lista = Escuela.getEscuelasFromDB(-1, "", "", n.codNiv);
                }
                ComboBoxNivel.Items.Add(n.nivAca);
            }
            foreach (Escuela _esc in lista)
            {
                if (_esc.codEsc == a.codEsc)
                    ComboBoxEsc.Text = _esc.nomEsc;
                ComboBoxEsc.Items.Add(_esc.nomEsc);
            }
            txtNomAlumno.Text = a.nomAlu;
            txtGraAlu.Text = a.graAca.ToString();
            txtProAlu.Text = a.proAlu.ToString();
            dateFechNacimiento.Value = a.nacAlu;
        }

        private void I_CapAlu_Load(object sender, EventArgs e)
        {
            if (user != null)
                CargarDatosIniciales();
        }

        public void ActualizarEscuelas()
        {
            ComboBoxEsc.Items.Clear();
            foreach (NivelEducativo NE in niveles)
            {
                if (NE.nivAca == ComboBoxNivel.Text)
                {
                    lista = Escuela.getEscuelasFromDB(-1, "", "", NE.codNiv);
                    ComboBoxEsc.Text = "";
                }
            }
            foreach (Escuela _esc in lista)
            {                
                ComboBoxEsc.Items.Add(_esc.nomEsc);
            }
        }

        private void ComboBoxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEscuelas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                a.nomAlu = txtNomAlumno.Text;
                a.nacAlu = dateFechNacimiento.Value;
                a.proAlu = double.Parse(txtProAlu.Text);
                a.graAca = int.Parse(txtGraAlu.Text);
                foreach (Escuela es in lista)
                {
                    if (es.nomEsc == ComboBoxEsc.Text)
                        a.codEsc = es.codEsc;
                }
                if (a.ActualizarToDB())
                    MessageBox.Show("Datos de Alumno guardados Exitosamente :-)");
            }
        }

        private bool Validar()
        {
            errorProvider1.Clear();
            bool comprobar=true;
            //Comprobar que el nombre no este vacio
            if (txtNomAlumno.Text == "")
            {
                comprobar = false;
                errorProvider1.SetError(txtNomAlumno, "Error, el campo nombre no debe de estar vacio");
            }
            //Comprobar que el Promedio sea numerico y que sea mayor que 0
            try
            {
                if (double.Parse(txtProAlu.Text) > 0)
                    comprobar = true;
                else
                {
                    errorProvider1.SetError(txtProAlu, "El prmedio no puede se menor que 0");
                    comprobar = false;
                }
            }
            catch (Exception e)
            {
                errorProvider1.SetError(txtProAlu, "Error, datos no numericos: " + e.Message);
                comprobar = false;
            }
            //Comprobar que el Grado sea numerico y mayor que 0
            try
            {
                if (int.Parse(txtGraAlu.Text) > 0)
                    comprobar = true;
                else
                {
                    errorProvider1.SetError(txtGraAlu, "El grado debe de ser mayor a 0");
                    comprobar = false;
                }
            }
            catch (Exception e)
            {
                errorProvider1.SetError(txtGraAlu, "Error, datos no numericos: " + e.Message);
                comprobar = false;
            }
            //Comprovar que la Escuela se Encuentre en la lista oficial
            bool comprobar2 = false;
            foreach (Escuela es in lista)
            {
                if (ComboBoxEsc.Text == es.nomEsc)
                    comprobar2 = true;
            }
            if (comprobar2) { }
            else
            {
                errorProvider1.SetError(ComboBoxEsc, "Error, la escuela no se encuentra en la lista oficial");
                comprobar = false;
            }
            //Regresar resultados de la validacion
            return comprobar;
        }
    }
}

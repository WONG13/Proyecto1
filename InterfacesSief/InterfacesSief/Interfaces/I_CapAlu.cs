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
            niveles = NivelEducativo.getNivelesFromDB(-1, "");
            txtGraAlu.Text = "0";
            txtProAlu.Text = "0";
        }

        public void setInteresado(Interesado i)
        {
            user = i;
        }

        public void CargarDatosIniciales()
        {
           
            if (user != null)//Verificar que se haya cargado un usuario Interesado
            {
                //Optiene Alumno de la BD segun codigo
                a = Alumno.getAlumnosFromDB(-1, "", user.getCodigo());
                //Optiene la Escuela de la BD segun el codigo que tiene el alumno
                if (a.codEsc > 0)
                    esc = Escuela.getEscuelaFromDB(a.codEsc, "", "", -1);
                else
                    esc = null;
            }
            else
                a = null;

            //Optiene todos los Niveles Academicos
            niveles = NivelEducativo.getNivelesFromDB(-1, "");
            
            if (a != null)
            {
                foreach (NivelEducativo n in niveles)
                {
                    ComboBoxNivel.Items.Add(n.nivAca);
                    if (esc != null)
                    {
                        if (esc.codNiv == n.codNiv)
                        {
                            ComboBoxNivel.SelectedItem = n.nivAca;//.Text = n.nivAca;
                            lista = Escuela.getEscuelasFromDB(-1, "", "", n.codNiv);
                        }
                    }
                }
                //ComboBoxNivel.DropDownStyle = ComboBoxStyle.DropDownList;
                ComboBoxEsc.Items.Clear();
                try
                {
                    foreach (Escuela _esc in lista)
                    {
                        ComboBoxEsc.Items.Add(_esc.nomEsc);
                        if (_esc.codEsc == a.codEsc)
                            ComboBoxEsc.SelectedItem = _esc.nomEsc;
                    }
                }
                catch (Exception)
                { }
                txtNomAlumno.Text = a.nomAlu;
                txtGraAlu.Text = a.graAca.ToString();
                txtProAlu.Text = a.proAlu.ToString();
                dateFechNacimiento.Value = a.nacAlu;
            }
            else
            {                
                lista = Escuela.getEscuelasFromDB(-1, "", "", -1);
                foreach (NivelEducativo n in niveles)
                {                    
                    ComboBoxNivel.Items.Add(n.nivAca);
                } 
            }
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
                }
            }
            foreach (Escuela _esc in lista)
            {                
                ComboBoxEsc.Items.Add(_esc.nomEsc);
            }
            ComboBoxEsc.SelectedValue = 0;
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
                try
                {
                    foreach (Escuela es in lista)
                    {
                        try
                        {
                            if (es.nomEsc == ComboBoxEsc.SelectedItem.ToString())
                                a.codEsc = es.codEsc;
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                catch (Exception)
                {
                }
                if (a.ActualizarToDB())
                    MessageBox.Show("Datos de Alumno guardados Exitosamente :-)");
            }
        }

        public bool Validar()
        {
            errorProvider1.Clear();
            bool comprobar=true;
            //Comprobar que el nombre no este vacio
            if (txtNomAlumno.Text == "")
            {
                comprobar = false;
                errorProvider1.SetError(txtNomAlumno, "Error, el campo nombre no debe de estar vacio");
            }
            //Comprobar que Promedio no este vacio
            if (txtProAlu.Text != "")
            {
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
            }
            else
            {
                errorProvider1.SetError(txtProAlu, "Promedio no puede estar vacio");
                comprobar = false;
            }
            //Comprobar que Grado no este vacio
            if (txtGraAlu.Text != "")
            {
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
            }
            else
            {
                errorProvider1.SetError(txtGraAlu, "Grado no puede estar vacio");
                comprobar = false;
            }
            
           
                //Comprovar que la Escuela se Encuentre en la lista oficial
                bool comprobar2 = true;
                if (ComboBoxEsc.Text != "")//Comprobar que Escuela no este vacio
                {
                    comprobar2 = false;
                    foreach (Escuela es in lista)
                    {
                        if (ComboBoxEsc.Text == es.nomEsc)
                            comprobar2 = true;
                    }
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

        public int CrearAlumno(int CodUsuInt)
        {
            int ID_Esc = -1;
            try
            {
                Escuela esc = Escuela.getEscuelaFromDB(-1, ComboBoxEsc.SelectedItem.ToString(), "", -1);
                ID_Esc = esc.codEsc;
            }
            catch (Exception)
            {
                ID_Esc = -1; 
            }
            Alumno a_nuevo = new Alumno(-1, txtNomAlumno.Text, 
                                            dateFechNacimiento.Value, 
                                            ID_Esc, 
                                            double.Parse(txtProAlu.Text),
                                            int.Parse(txtGraAlu.Text),
                                            CodUsuInt);
            int CodAlu=a_nuevo.CreateAlumnoToDB();
            return CodAlu;
        }

        public void OcultarBotones()
        {
            btnAceptar.Visible = false;
            btnCancel.Visible = false;
        }
    }
}

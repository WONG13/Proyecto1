﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class I_CapInt : InterfacesSief.I_FormPlantilla
    {
        Interesado user;
        public I_CapInt()
        {
            InitializeComponent();
        }

        public bool cargarDatos(int codUsu)
        {
            user = Interesado.getInteresadoFromDB(codUsu);
            if (user == null)
                return false;
            else
            {
                txtNomComInt.Text = user.getNombre();
                txtDirInt.Text = user.getDireccion();
                txtCorInt.Text = user.getCorreo();
                txtTelInt.Text = user.getTelefono();
                return true;
            }
        }

        public bool cargarDatos(Interesado i)
        {
            user = i;
            if (user == null)
                return false;
            else
            {
                txtNomComInt.Text = user.getNombre();
                txtDirInt.Text = user.getDireccion();
                txtCorInt.Text = user.getCorreo();
                txtTelInt.Text = user.getTelefono();
                return true;
            }
        }
        private void guardarCambios()
        {
            Interesado actuzalido = new Interesado(user.getCodigo(), "", "",
                                                 txtNomComInt.Text,
                                                 txtDirInt.Text,
                                                 txtTelInt.Text,
                                                 txtCorInt.Text);
            if (actuzalido.ActualizarToDB())
                MessageBox.Show("Datos Guardados Exitosamente =3");
            else
                MessageBox.Show("Error al actualizar los datos");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                guardarCambios();
            }
        }

        public bool validar()
        {
            bool condicion = true;
            errorProvider1.Clear();
            if (txtNomComInt.Text.Length == 0)
            {
                errorProvider1.SetError(txtNomComInt, "El nombre no puede quedar vacio");
                condicion = false;
            }
            if (txtCorInt.Text.Length == 0)
            {
                errorProvider1.SetError(txtCorInt, "Es necesario un correo de referencia");
                condicion = false;
            }
            return condicion;
        }

        public void OcultarBotones()
        {
            btnAceptar.Visible = false;
            btnCancel.Visible = false;
        }

        public bool CrearInteresado(int CodUsu)
        {
            Interesado i_nuevo = new Interesado(CodUsu,"","Interesado",
                                                 txtNomComInt.Text,
                                                 txtDirInt.Text,
                                                 txtTelInt.Text,
                                                 txtCorInt.Text);
            if (i_nuevo.CreateInteresadoToDB(CodUsu))
                return true;//MessageBox.Show("Datos de Tutor guardados Exitosamente");
            else
                return false;
        }

        internal void BloquearBotones2()
        {
            txtCorInt.ReadOnly = true;
            txtDirInt.ReadOnly = true;
            txtNomComInt.ReadOnly = true;
            txtTelInt.ReadOnly = true;
        }
    }
}

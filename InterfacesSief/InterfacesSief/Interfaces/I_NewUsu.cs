using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class I_NewUsu : InterfacesSief.I_FormPlantilla
    {
        bool contraseñaConNumero = true;
        string permiso = "Interesado";
        cerrarSesion logout;
        public I_NewUsu()
        {
            InitializeComponent();
            ocultarBotones();
            i_CapAlu1.CargarDatosIniciales();
        }

        public void SetDelegado(MainForm f)
        {
            logout = new cerrarSesion(f.Logout);
        }

        public void ocultarBotones()
        {
            i_CapInt1.btnAceptar.Visible = false;
            i_CapInt1.btnCancel.Visible = false;
            i_CapAlu1.btnAceptar.Visible = false;
            i_CapAlu1.btnCancel.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuario u_nuevo = new Usuario(-1, txtNomUsuInt.Text, txtConUsuInt.Text, permiso);
                if (u_nuevo.CreateUserToDB())
                {
                    u_nuevo = Usuario.getUsuarioFromDB(txtNomUsuInt.Text, -1);
                    i_CapInt1.CrearInteresado(u_nuevo.getCodigo());
                    i_CapAlu1.CrearAlumno(u_nuevo.getCodigo());
                    MessageBox.Show("Usuario registrado correctamente");
                    
                }

            }

        }

        public bool Validar()
        {
            deteccionError.Clear();
            bool correcto = true;
            if (!i_CapInt1.validar())
                correcto= false;
            if (!i_CapAlu1.Validar())
                correcto= false;
            if (txtConConInt.Text == "")
            {
                correcto= false;
                deteccionError.SetError(txtConConInt, "Campo vacio");
            }
            if(txtConUsuInt.Text == "")
            {
                correcto = false;
                deteccionError.SetError(txtConUsuInt, "Campo vacio");
            }
            if(txtNomUsuInt.Text == "")
            {
                correcto = false;
                deteccionError.SetError(txtNomUsuInt, "Campo vacio");
            }
            else
            {
                //Comprobar que el nombre de usuario no exista
                Usuario repetido = Usuario.getUsuarioFromDB(txtNomUsuInt.Text, -1);
                if (repetido != null)
                {
                    deteccionError.SetError(txtNomUsuInt, "Este nombre de usuarios ya Existe");
                    correcto = false;
                }
                //Comprobar que el nombre sea mayor a 6 caracteres
                if (txtNomUsuInt.Text.Length < 6)
                {
                    deteccionError.SetError(txtNomUsuInt, "El nombre debe de tener minimo 6 caracteres de largo");
                    correcto = false;
                }
                //Comprobar que las contraseñas sean iguales
                if (txtConUsuInt.Text != txtConConInt.Text)
                {
                    deteccionError.SetError(txtConConInt, "Las contraseñas no coinciden");
                    correcto = false;
                }
                //Comprobar que las contraseñas cumplan con estandar de seguridad
                if (txtConUsuInt.Text.Length >= 6)
                {
                    bool tieneUnNumero = false;
                    foreach (char c in txtConUsuInt.Text)
                    {
                        if (char.IsNumber(c))
                        {
                            tieneUnNumero = true;
                            break;
                        }
                    }
                    if (contraseñaConNumero)
                    {
                        if (!tieneUnNumero)
                        {
                            correcto = false;
                            deteccionError.SetError(txtConUsuInt, "La contraseña debe de contener por lo menos un numero");
                        }
                    }
                }
                else
                {
                    deteccionError.SetError(txtConUsuInt, "La contraseña debe de tener 6 o mas caraceres de largo");
                    correcto = false;
                }
               
            }
            return correcto;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            logout();
        }
    }
}

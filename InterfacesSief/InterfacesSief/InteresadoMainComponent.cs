using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class InteresadoMainComponent : UserControl
    {
        Usuario interesado;
        public InteresadoMainComponent()
        {
            InitializeComponent();
        }

        public void setUsuario(Usuario user)
        {
            interesado = user;
        }

        public void eliminarAnterior()
        {
            if (Controls.Count > 1)
                Controls.RemoveAt(1); 
        }

        private void interesadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarAnterior();
            I_CapInt ICI = new I_CapInt();
            if (!ICI.cargarDatos(interesado.getCodigo()))
                MessageBox.Show("Error al cargar datos");
            Controls.Add(ICI);
            ICI.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarAnterior();
            I_CapAlu ICA = new I_CapAlu();
            Controls.Add(ICA);
            ICA.Show();
        }

        private void hacerSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

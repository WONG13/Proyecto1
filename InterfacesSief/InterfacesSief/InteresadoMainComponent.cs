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
        public InteresadoMainComponent()
        {
            InitializeComponent();
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
            Controls.Add(ICI);
            ICI.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
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

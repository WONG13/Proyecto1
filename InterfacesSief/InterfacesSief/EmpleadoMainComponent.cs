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
    public partial class EmpleadoMainComponent : UserControl
    {
        public EmpleadoMainComponent()
        {
            InitializeComponent();
        }

        string ApuntadorControl = null;
        private iModulo ModuloActual { get; set; }

        private void verSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E_MosRep ObjE = new E_MosRep();
             MostrarModulo(ObjE);


        }

        private void MostrarModulo(UserControl NuevoModulo)
        {
            if (ModuloActual != null)
            {
                ((IDisposable)ModuloActual).Dispose();
            }

            ModuloActual = (iModulo)NuevoModulo;
            NuevoModulo.Dock = DockStyle.Fill;
            this.Controls.Add(NuevoModulo);
            
            //NuevoModulo.Parent = this
        }
    }
}

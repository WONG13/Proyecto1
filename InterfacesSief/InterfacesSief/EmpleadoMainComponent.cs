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
        string ApuntadorControl = null;
        private iModulo ModuloActual { get; set; }
        
        public EmpleadoMainComponent()
        {
            InitializeComponent();
            Inicio();
        }

       
        private void Inicio()
        {
            MostrarModulo(new E_RevDoc());
        }

        private void verSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarModulo(new E_RevDoc());
        }

        private void reporteDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarModulo(new E_MosRep());
        }

        private void bucarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MostrarModulo(new E_MosRep());
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

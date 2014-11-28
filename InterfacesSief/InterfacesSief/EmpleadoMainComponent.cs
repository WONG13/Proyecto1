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
    public delegate void LlamarRevision(UserControl u);
    public delegate void LlamarRevision1(E_RevSol u);
    public partial class EmpleadoMainComponent : UserControl
    {
        string ApuntadorControl = null;
        private iModulo ModuloActual { get; set; }


         public Usuario Empleado;
        public EmpleadoMainComponent()
        {
            InitializeComponent();
            Inicio();
        }
        public void setUsuario(Usuario user)
        {
            Empleado = user;
        }
       
        private void Inicio()
        {
            E_RevDoc ER = new E_RevDoc();          
            ER.LR = new LlamarRevision(MostrarModulo);
            MostrarModulo(ER);
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


        public void MostrarModulo(UserControl NuevoModulo)
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

        public void MostrarModulo(E_RevSol NuevoModulo)
        {           
            NuevoModulo.Dock = DockStyle.Fill;
            this.Controls.Add(NuevoModulo);
            //NuevoModulo.Parent = this
        }

    

      

     
    }
}

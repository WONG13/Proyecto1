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


        public Empleado user;
        public EmpleadoMainComponent()
        {
            InitializeComponent();
            
        }
        public void setUsuario(Empleado emp)
        {
            user=emp;
        }
       
        public void Inicio()
        {
            E_RevDoc ERD = new E_RevDoc();
            ERD.setEmpleado(user);
            ERD.Inicio();
            ERD.LR = new LlamarRevision(MostrarModulo);
            MostrarModulo(ERD);
        }

        private void verSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E_RevDoc ERD = new E_RevDoc();
            ERD.setEmpleado(user);
            ERD.Inicio();
            ERD.LR = new LlamarRevision(MostrarModulo);
            MostrarModulo(ERD);
            
        }

        private void reporteDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E_MosRep ER = new E_MosRep();
            ER.setEmpleado(user);
            ER.Inicializar();
            MostrarModulo(ER);
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


        public void EliminarAnterior()
        {
            int n = this.Controls.IndexOf(menuStrip1);
            this.Controls[n + 1].Dispose();
        }
    

      

     
    }
}

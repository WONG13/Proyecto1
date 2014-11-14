using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    public partial class E_RevDoc : InterfacesSief.I_FormPlantilla ,iModulo
    {
        public LlamarRevision LR;
        public E_RevDoc()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LR(new E_RevSol());
            
        }
    }
}

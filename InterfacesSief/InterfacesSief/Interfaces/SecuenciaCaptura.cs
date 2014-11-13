using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief.Interfaces
{
    public partial class SecuenciaCaptura : Form
    {
        public SecuenciaCaptura()
        {
            InitializeComponent();
            Inicio();
        }
        private void Inicio()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "I_CapAlu")
                {
                    f.Activate();
                    return;
                }
            }
            I_CapAlu formHijo = new I_CapAlu();
            //formHijo.MdiParent = this;
            //formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "I_CapAlu")
                {
                    f.Activate();
                    return;
                }
            }
            I_CapInt formHijo = new I_CapInt();
            //formHijo.MdiParent = this;
            //formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();

        }
    }
}

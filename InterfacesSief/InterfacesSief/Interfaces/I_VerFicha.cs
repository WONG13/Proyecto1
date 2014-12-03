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
    public partial class I_VerFicha : UserControl
    {
        Interesado inter;
        public I_VerFicha()
        {
            InitializeComponent();
        }

        public void setInteresado(Interesado i)
        {
            inter = i;
        }

        public void inicialiszar()
        {
            dataGridView1.DataSource = Ficha.getTablaFichaFromDB(-1, inter.getCodigo(), "");
        }
        
    }
}

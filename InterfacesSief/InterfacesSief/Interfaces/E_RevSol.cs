﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacesSief
{
    
    public partial class E_RevSol : UserControl,iModulo
    {
        int x;
        public E_RevSol(int x)
        {
            InitializeComponent();
            this.x = x;
        }


        private void E_RevSol_Load(object sender, EventArgs e)
        {
           
            
            i_CapInt1.OcultarBotones();
            i_CapInt1.cargarDatos(x);//Este es el numero del Interesado
        }
    }
}

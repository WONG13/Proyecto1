using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiEFlib
{
    public class Usuario
    {
        private int CodUsu;
        private string nomUsu;
        private string contUsu;
        public enum Permiso { interesado, lider_proyecto, empleado };
        private Permiso permiso;

        public Usuario()
        {}

        public void abrirSesion()
        {
            
        }
    }
}

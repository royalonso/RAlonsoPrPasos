using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAlonsoPrPasos
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        string Contrasenia { get; set; }
        public string mail { get; set; }

        public Usuario()
        {
            
        }
    }
}

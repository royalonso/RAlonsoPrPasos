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

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            this.mail = mail;
        }
    }
}

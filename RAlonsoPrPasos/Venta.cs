using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAlonsoPrPasos
{
    public class Venta
    {
        public int id { get; set; }
        public string Comentarios { get; set; }

        public Venta()
        {

        }
        public Venta(int id, string comentarios)
        {
            this.id = id;
            Comentarios = comentarios;
        }
    }

}

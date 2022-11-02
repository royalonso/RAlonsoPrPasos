using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAlonsoPrPasos
{
    public class Producto
    {
        public int Id { get; set; } 
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }  
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int idUsuario { get; set; }

        public Producto()
        {

        }
        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            this.idUsuario = idUsuario;
        }

    }
}

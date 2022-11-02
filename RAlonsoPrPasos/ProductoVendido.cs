using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAlonsoPrPasos
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int idVenta { get; set; }

        public ProductoVendido()
        {

        }
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            this.idVenta = idVenta;
        }
    }
}

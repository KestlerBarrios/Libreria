using System.Collections.Generic;

namespace Libreria.Models
{
    public class Venta
    {
        public string ventaId { get; set; }
        public int noVenta { get; set; }
        public string cliente { get; set; }
        public List<Producto> productos { get; set; }
        public decimal totalVenta { get; set; }
        
        public Venta()
        {

        }

        public Venta(int venta, string client)
        {
            noVenta = venta;
            cliente = client;
        }
    }
}
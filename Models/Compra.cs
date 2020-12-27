using System;
using System.Collections.Generic;

namespace Libreria.Models
{
    public class Compra
    {
        public int compraId { get; set; }
        public List<Proveedor> proveedor { get; set; }
        public  DateTime fecha { get; set; }
        public decimal totalCompra { get; set; }
        public List<Producto> productos { get; set; }

    }
}
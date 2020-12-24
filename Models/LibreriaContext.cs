using Microsoft.EntityFrameworkCore;

namespace Libreria.Models
{
    public class LibreriaContext: DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

    }
}
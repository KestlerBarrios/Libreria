using System;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Models
{
    public class LibreriaContext: DbContext
    {
        
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        public LibreriaContext(DbContextOptions<LibreriaContext> options): base (options){


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var id = Guid.NewGuid().ToString();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto{productoId = "1", nombreProducto= "Crayones", marca= "Tucan", precio= 12.4},
                new Producto{productoId = "2", nombreProducto= "Crayones", marca= "Tucan", precio= 12.4},
                new Producto{productoId = "3", nombreProducto= "Marcadores", marca= "Mis Pasitos", precio= 14.25},
                new Producto{productoId = "4", nombreProducto= "Resaltadores", marca= "Facela", precio= 18.265},
                new Producto{productoId = "5", nombreProducto= "Lapiz", marca= "Facela", precio= 2},
                new Producto{productoId = "6", nombreProducto= "Lapicero", marca= "Bic", precio= 1.5},
                new Producto{productoId = "7", nombreProducto= "Borrador", marca= "Fast", precio= 1},
                new Producto{productoId = "8", nombreProducto= "Sacapuntas", marca= "Tucan", precio= .50},
                new Producto{productoId = "9", nombreProducto= "Compas", marca= "Huiut", precio= 4}
            );
            modelBuilder.Entity<Venta>().HasData(
                new Venta{ventaId = "1", noVenta = 1, cliente = "Luis"},
                new Venta{ventaId = "2", noVenta = 2, cliente = "Javier"},
                new Venta{ventaId = "3", noVenta = 3, cliente = "Arelis"},
                new Venta{ventaId = "4", noVenta = 4, cliente = "Kestler"}
            );
        }

    }
}
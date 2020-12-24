using System.Collections.Generic;
using Libreria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var productos = new List<Producto>(){
                new Producto{nombreProducto= "Crayones", marca= "Tucan", precio= 12.4},
                new Producto{nombreProducto= "Marcadores", marca= "Mis Pasitos", precio= 14.25},
                new Producto{nombreProducto= "Resaltadores", marca= "Facela", precio= 18.265}
            };

            return View(productos);
        }
    }
}
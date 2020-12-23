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
                new Producto{nombreProducto= "Crayones"},
                new Producto{nombreProducto= "Marcadores"},
                new Producto{nombreProducto= "Resaltadores"}
            };

            return View(productos);
        }
    }
}
using Libreria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var producto = new Producto();
            producto.nombreProducto = "Crayones";
            producto.marca = "Tucan";
            producto.distintivo = "Cera Jumbo";
            producto.color = "Verdes";
            return View(producto);
        }
    }
}
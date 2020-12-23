using Libreria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Index()
        {
            var venta = new Venta();
            return View(venta);
        }
    }
}
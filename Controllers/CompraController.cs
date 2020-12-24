using Microsoft.AspNetCore.Mvc;
using Libreria.Models;

namespace Libreria.Controllers
{
    public class CompraController: Controller
    {
        public IActionResult Index()
        {
            var compra = new Compra();
            return View(compra);
        }
    }  
}
using Microsoft.AspNetCore.Mvc;
using Libreria.Models;

namespace Libreria.Controllers
{
    public class ProveedorController: Controller
    {

        public IActionResult Index()
        {
            var proveedor = new Proveedor();
            return View(proveedor);
        }
    }

}
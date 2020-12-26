using Microsoft.AspNetCore.Mvc;
using Libreria.Models;

namespace Libreria.Controllers
{
    public class AcercaController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }  
}
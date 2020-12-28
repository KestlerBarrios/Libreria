using System.Linq;
using Libreria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Index()
        {
            var ventas = _context.Ventas.ToList();
            return View(ventas);
        }
        private LibreriaContext _context;
        public VentaController(LibreriaContext context)
        {
            _context = context;
        }
    }
}
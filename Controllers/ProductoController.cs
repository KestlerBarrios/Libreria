using System.Linq;
using System.Collections.Generic;
using Libreria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class ProductoController : Controller
    {
        private LibreriaContext _context;
        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            return View(productos);
        }

        public ProductoController(LibreriaContext context)
        {
            _context = context;
        }
    }
}
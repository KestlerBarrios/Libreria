using System.Linq;
using System.Collections.Generic;
using Libreria.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Libreria.Controllers
{
    public class ProductoController : Controller
    {
        private LibreriaContext _context;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Producto producto)
        {
            producto.productoId = Guid.NewGuid().ToString();
            _context.Productos.Add(producto); 
            _context.SaveChanges();
            return View();
        }

        

        public ProductoController(LibreriaContext context)
        {
            _context = context;
        }
    }
}
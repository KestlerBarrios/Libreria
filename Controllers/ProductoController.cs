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
        public IActionResult ProductoS(Producto producto)
        {
            return View(_context.Productos.ToList());
        }

        [Route("Producto/ProductoSee/{productoId?}")]
        public IActionResult ProductoSee(string productoId)
        {
            var Product = from produ in _context.Productos
                          where produ.productoId == productoId
                          select produ;
            return View(Product.SingleOrDefault());
        }
        public ProductoController(LibreriaContext context)
        {
            _context = context;
        }
    }
}
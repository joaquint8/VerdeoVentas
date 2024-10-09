using Microsoft.AspNetCore.Mvc;
using VerdeoVentas.Models;
using System.Collections.Generic;

namespace VerdeoVentas.Controllers
{
    public class VentasController : Controller
    {
        private static List<Venta> ventas = new List<Venta>
        {
            new Venta { Id = 1, Articulo = "Producto 1", Descripcion = "Descripción 1", Precio = 100, Cantidad = 2, PagoTotal = 200, FechaVenta = DateTime.Now },
            new Venta { Id = 2, Articulo = "Producto 2", Descripcion = "Descripción 2", Precio = 150, Cantidad = 1, PagoTotal = 150, FechaVenta = DateTime.Now }
        };

        public IActionResult Index()
        {
            return View(ventas);
        }

        [HttpPost]
        public IActionResult Create(Venta venta)
        {
            Console.WriteLine("Método Create llamado");
            if (ModelState.IsValid)
            {
                Console.WriteLine("Modelo válido");
                ventas.Add(venta);
                return RedirectToAction("Index");
            }
            Console.WriteLine("Modelo no válido");
            return View(venta);
        }

    }
}

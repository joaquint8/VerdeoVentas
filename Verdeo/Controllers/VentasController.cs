using Microsoft.AspNetCore.Mvc;
using VerdeoVentas.Models;
using VerdeoVentas.Enums;
using System.Collections.Generic;

namespace VerdeoVentas.Controllers
{
    public class VentasController : Controller
    {
        private static List<Venta> ventas = new List<Venta>
        {
            new Venta { Id = 1, Cliente = "Joaquin Pavone", Pedido = "1 docena de soja", Precio = 8500, Pago = true, TipoDePago = TipoDePago.Efectivo, FechaVenta = DateTime.Now, Envio = false, Total = 8500 },
            new Venta { Id = 2, Cliente = "Candela Pepe", Pedido = "x3 paquetes de milanesas", Precio = 9500, Pago = false, TipoDePago = TipoDePago.Transferencia, FechaVenta = DateTime.Now, Envio = true, Total = 10000 }
        };

        public IActionResult Index()
        {
            return View(ventas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Venta venta)
        {
            if (ModelState.IsValid)
            {
                //autoincrementar ID
                venta.Id = ventas.Count > 0 ? ventas.Max(v => v.Id) + 1 : 1;
                ventas.Add(venta);
                return RedirectToAction("Index");
            }
            return View(venta);
        }
    }
}

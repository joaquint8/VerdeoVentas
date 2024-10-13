using System.ComponentModel.DataAnnotations;
using VerdeoVentas.Enums;

namespace VerdeoVentas.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public required string Cliente { get; set; }
        public required string Pedido { get; set; }
        public decimal Precio { get; set; }
        public bool Pago { get; set; }
        public TipoDePago TipoDePago { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Envio { get; set; }
        public decimal Total { get; set; }
    }
}

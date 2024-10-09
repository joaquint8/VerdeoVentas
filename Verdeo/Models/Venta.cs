namespace VerdeoVentas.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal PagoTotal { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}

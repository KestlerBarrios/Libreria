namespace Libreria.Models
{
    public class Producto
    {
        public string productoId { get; set; }
        public string nombreProducto { get; set; }
        public string marca { get; set; }
        public string distintivo { get; set; }
        public string color { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public int bodega { get; set; }

        public Producto()
        {
            
        }
        public Producto(string nombre, int cantida)
        {
            nombreProducto = nombre;
            cantidad = cantida;
        }
    }

}
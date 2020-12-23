namespace Libreria.Models
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }

        public Proveedor()
        {

        }
        public Proveedor(string nombre, int tel, string direc)
        {
            nombreProveedor = nombre;
            telefono = tel;
            direccion = direc;
        }
    }
}
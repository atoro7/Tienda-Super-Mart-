using SuperMart.Enums;

namespace SuperMart.Modelos
{
    public class Producto
    {
        public string Nombre { get; private set; }
        public double Precio { get; private set; }
        public CategoriaProducto Categoria { get; private set; }

        public Producto(string nombre, double precio, CategoriaProducto categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
    }
}

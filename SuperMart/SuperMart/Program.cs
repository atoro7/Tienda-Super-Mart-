using SuperMart.Modelos;
using SuperMart.Enums;

namespace SuperMart
{
    class Program
    {
        static void Main()
        {
            Tienda tienda = new Tienda("Super Mart");

            Producto producto1 = new Producto("Remera", 7, CategoriaProducto.Ropa);
            Producto producto2 = new Producto("Celular", 15, CategoriaProducto.Electronico);
            Producto producto3 = new Producto("Hamburguesa", 1, CategoriaProducto.Alimento);

            tienda.AgregarProducto(producto1);
            tienda.AgregarProducto(producto2);
            tienda.AgregarProducto(producto3);

            tienda.MostrarDetalles();
        }
    }
}

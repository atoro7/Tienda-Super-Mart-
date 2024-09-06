namespace SuperMart.Modelos
{
    public class Tienda
    {
        public string Nombre { get; private set; }
        public List<Producto> Inventario { get; private set; } = new List<Producto>();

        public Tienda(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarProducto(Producto producto)
        {
            Inventario.Add(producto);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Tienda {Nombre}:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Productos:\n");
            
            foreach (var producto in Inventario)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Precio: {producto.Precio:C}");
                Console.WriteLine($"Categoria: {producto.Categoria}\n");
            }

        }
    }
}

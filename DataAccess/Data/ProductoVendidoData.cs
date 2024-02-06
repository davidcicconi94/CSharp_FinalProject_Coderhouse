using Coder.DataAccess.Context;
using Project_Coderhouse.Entities;

namespace Coder.DataAccess.Data
{
    public static class ProductoVendidoData
    {
        public static bool ObtenerProductoVendido(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendidoEncontrado = context.ProductoVendidos.FirstOrDefault(x =>
                        x.Id == id
                    );

                    if (productoVendidoEncontrado != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Producto vendido no encontrado: {ex.Message}");
                    return false;
                }
            }
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    List<ProductoVendido> listaDeProductosVendidos =
                        context.ProductoVendidos.ToList();

                    if (listaDeProductosVendidos.Count != 0)
                    {
                        return listaDeProductosVendidos;
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron Productos vendidos.");
                        return new List<ProductoVendido>();
                    }
                }
                catch (Exception ex)
                {
                    Console.Write($"Productos vendidos no encontrados: {ex.Message}");
                    return new List<ProductoVendido>();
                }
            }
        }

        public static bool CrearProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Add(nuevoProductoVendido);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear un producto vendido: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool ModificarProductoVendido(int id, ProductoVendido productoVendidoMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendido = context.ProductoVendidos.Find(id);

                    if (productoVendido != null)
                    {
                        productoVendido.IdProducto = productoVendido.IdProducto;
                        productoVendido.IdVenta = productoVendido.IdVenta;
                        productoVendido.Stock = productoVendido.Stock;

                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"No fue posible modificar un producto vendido: {ex.Message}"
                    );
                    return false;
                }
            }
        }

        public static bool EliminarProductoVendido(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var productoVendidoEncontrado = context.ProductoVendidos.Find(id);

                    if (productoVendidoEncontrado != null)
                    {
                        context.ProductoVendidos.Remove(productoVendidoEncontrado);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible eliminar un producto vendido: {ex.Message}");
                    return false;
                }
            }
        }
    }
}

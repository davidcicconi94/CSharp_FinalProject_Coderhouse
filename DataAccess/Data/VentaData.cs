using Coder.DataAccess.Context;
using Project_Coderhouse.Entities;

namespace Coder.DataAccess.Data
{
    public static class VentaData
    {
        public static bool ObtenerVenta(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaEncontrada = context.Venta.Find(id);

                    if(ventaEncontrada != null)
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
                    Console.WriteLine($"Venta no encontrada: {ex.Message}");
                    return false;
                }
            }
        }
        public static List<Venta> ListarVentas()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                  var listaDeVentas = context.Venta.ToList();
                   return listaDeVentas;
                }
                catch (Exception ex)
                {
                    return new List<Venta>();
                }
            }
        }
        public static bool CrearVenta(Venta ventaCreada)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Venta.Add(ventaCreada);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear una venta: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool ModificarVenta(int id, Venta ventaMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaExistente = context.Venta.Find(id);

                    if(ventaExistente != null)
                    {
                        ventaExistente.Comentarios = ventaMod.Comentarios;
                        ventaExistente.IdUsuario = ventaMod.IdUsuario;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible modificar una venta: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool EliminarVenta(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var ventaExistente = context.Venta.Find(id);

                    if(ventaExistente != null)
                    {
                        context.Venta.Remove(ventaExistente);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible eliminar un producto: {ex.Message}");
                    return false;
                }
            }
        }
    }
}

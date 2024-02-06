using Coder.DataAccess.Context;
using Project_Coderhouse.Entities;

namespace Coder.DataAccess.Data
{
    public static class UsuarioData
    {
        public static bool ObtenerUsuario(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioEncontrado = context.Usuarios.FirstOrDefault(u => u.Id == id);

                    if (usuarioEncontrado != null)
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
                    return false;
                }
            }
        }

        public static List<Usuario> ListarUsuarios()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    List<Usuario> listaUsuarios = context.Usuarios.ToList();    
                    return listaUsuarios;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener la lista de usuarios: {ex.Message}");
                    return new List<Usuario>();
                }
            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No fue posible crear un usuario: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool ModificarUsuarios(int id, Usuario usuarioMod)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioExistente = context.Usuarios.Find(id);

                    if (usuarioExistente != null)
                    {
                        usuarioExistente.Nombre = usuarioMod.Nombre;
                        usuarioExistente.Apellido = usuarioMod.Apellido;
                        usuarioExistente.NombreUsuario = usuarioMod.NombreUsuario;
                        usuarioExistente.Contrasenia = usuarioMod.Contrasenia;

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
                    Console.WriteLine($"No fue posible modificar un usuario: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool EliminarUsuario(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioEncontrado = context.Usuarios.Find(id);

                    if (usuarioEncontrado != null)
                    {
                        context.Usuarios.Remove(usuarioEncontrado);
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
                    Console.WriteLine($"No fue posible eliminar el usuario: {ex.Message}");
                    return false;
                }
            }
        }
    }
}

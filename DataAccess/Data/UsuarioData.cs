using Coder.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Project_Coderhouse.Entities;

namespace Coder.DataAccess.Data
{
    public static class UsuarioData
    {
        public static Usuario ObtenerUsuario(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var usuarioEncontrado = context.Usuarios.FirstOrDefault(u => u.Id == id);

                    if(usuarioEncontrado != null)
                    {
                        Console.WriteLine($"Usuario encontrado: {usuarioEncontrado.Nombre}");
                    } else
                    {
                        Console.WriteLine($"Usuario con ID {id} no encontrado.");
                    }

                    return usuarioEncontrado;

                } catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener el usuario: {ex.Message}");
                    
                    return null;
                }
            }
        }

        public static void ListarUsuarios()
        {

        }

        public static void CrearUsuario()
        {

        }

        public static void ModificarUsuarios()
        {

        }

        public static void EliminarUsuario()
        {

        }
    }
}

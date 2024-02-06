using System.Collections.Generic;

namespace Project_Coderhouse.Entities
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ProductoVendido> ProductosVendidos { get; set; } = new HashSet<ProductoVendido>();

        public Venta() { }  

        public Venta(int id, string comentarios, int idUsuario)
        {
            Id = id;
            Comentarios = comentarios;
            IdUsuario = idUsuario;
        }
    }
}

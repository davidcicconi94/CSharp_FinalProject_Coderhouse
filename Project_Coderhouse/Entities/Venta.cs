using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Coderhouse.Models
{
    public class Venta
    {
        private int id;
        private string comentarios;
        private int idUsuario;

        public int Id { get { return id; } set { id = value; } }
        public string Comentarios { get { return comentarios; } set { comentarios = value; } }
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }

        public Venta(int id, string comentarios, int idUsuario) 
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
    }
}

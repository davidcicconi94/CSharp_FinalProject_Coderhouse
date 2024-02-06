using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Coderhouse.Entities
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }

        [ForeignKey(nameof(IdProducto))]
        public Producto? Producto { get; set; }

        [ForeignKey(nameof(IdVenta))]
        public Venta? Venta { get; set; }

    }
}

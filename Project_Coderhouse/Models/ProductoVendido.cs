using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Coderhouse.Models
{
    public class ProductoVendido
    {
        private int id;
        private int idProducto;
        private int stock;
        private int idVenta;

        public int Id { get { return id; } set { id = value; } }
        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int IdVenta { get { return idVenta; } set { idVenta = value; } }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }
    }
}

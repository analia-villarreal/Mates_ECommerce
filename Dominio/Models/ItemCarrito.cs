using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    public class ItemCarrito
    {
        public int ID { get; set; }
        public Articulo IDArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public Pedido IdPedido { get; set; }

    }
}
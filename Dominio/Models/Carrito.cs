using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    public class Carrito
    {
        public int ID { get; set; }
        public Pedido Pedido { get; set; }
        public List<ItemCarrito> elementosCarrito { get; set; }

    }
}
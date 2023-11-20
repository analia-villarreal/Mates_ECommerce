using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    public class ItemCarrito
    {
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        
    }
}
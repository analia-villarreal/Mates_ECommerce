using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    public class Articulo
    {
        public int ID { get; set; }
        public string NombreArt { get; set; }
        public string Descripcion { get; set; }
        public Categoria IDCategoria { get; set; }
        public SubCategoria IDSubCategoria { get; set; }
        public decimal Precio { get; set; }
        public string UrlImagen { get; set; }
        public bool Estado { get; set; }
    }
}
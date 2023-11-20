using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    public class Direccion
    {
        public int ID { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CP { get; set; }

        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}
using Dominio.Models;
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mates_ECommerce
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {

        private List<Articulo> listaArticulos { get; set; }

        private List<ItemCarrito> listaCarrito { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
    

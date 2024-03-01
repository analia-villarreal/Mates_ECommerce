using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Mates_ECommerce
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Session.Remove("usuario");
                Response.Redirect("Default.aspx");
            }

        }

        protected void ibtnCarrito_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Carrito.aspx", false);
        }
    }
}
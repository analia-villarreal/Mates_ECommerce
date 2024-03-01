using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio.Models;
using Negocio.Models;

namespace Mates_ECommerce
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ItemCarrito> listaCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            dgvCarrito.DataSource = Session["listaCarrito2"];
            dgvCarrito.DataBind();
            decimal total = 0;
            for (int i = 0; i < dgvCarrito.Rows.Count; i++)
            {
                total += (Convert.ToDecimal(dgvCarrito.Rows[i].Cells[2].Text) * Convert.ToDecimal(dgvCarrito.Rows[i].Cells[3].Text));
            }
            lblTotal.Text = Convert.ToString(total);
            Session.Add("totalAPagar", lblTotal.Text);

        }

        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = e.ToString();
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "ModalStock('" + "Abrir" + "');", true);
        }

        protected void imgTacho_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = sender as ImageButton;
            ItemCarrito elemento = new ItemCarrito();
            try
            {
                elemento.IDArticulo = new Articulo();
                elemento.IDArticulo.ID = Convert.ToInt32(button.CommandArgument);
                listaCarrito = (List<ItemCarrito>)Session["listaCarrito2"];
                int i = 0;
                int index = 0;
                foreach (ItemCarrito item in listaCarrito)
                {
                    if (elemento.IDArticulo.ID == item.IDArticulo.ID)
                    {
                        index = i;
                    }
                    i++;
                }
                listaCarrito.RemoveAt(index);
                Session.Add("listaCarrito2", listaCarrito);
                Response.Redirect("Carrito.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "cerrar", "ModalStock('" + "Cerrar" + "');", true);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagar.aspx");
        }



    }
}
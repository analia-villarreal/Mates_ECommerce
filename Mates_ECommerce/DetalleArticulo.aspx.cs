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
            if (!IsPostBack)
            {

               //btnAddCarrito.Enabled = false;

                Articulo art = new Articulo();
                ArticuloNegocio negocio = new ArticuloNegocio();

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    art = negocio.listar2(id);

                    NombreDetalle.InnerText = art.NombreArt;
                    DescripcionDetalle.InnerText = art.Descripcion;
                    PrecioDetalle.InnerText = art.Precio.ToString("N2");
                    Session.Add("Url_Imagen", art.UrlImagen);

                }
                else
                {

                }

                listaArticulos = negocio.Listar();
                Session.Add("listaArticulos", listaArticulos);

                if (Session["carrito"] == null)
                {
                    listaCarrito = new List<ItemCarrito>();
                    Session.Add("carrito", listaCarrito);

                }

            }

        }

        protected void btnAddCarrito_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {

                string id = Request.QueryString["id"].ToString();
                listaCarrito = (List<ItemCarrito>)Session["listaCarrito"];
                listaArticulos = (List<Articulo>)Session["listaArticulos"];

                Articulo art = new Articulo();
                art = listaArticulos.Find(x => x.ID == int.Parse(id));

                ItemCarrito item = new ItemCarrito();

                if (listaCarrito.Count() == 0)
                {
                    item.ID = listaCarrito.Count() + 1;
                    item.Articulo = art;
                    item.Cantidad = int.Parse(txtCantidad.Text);
                }

                foreach (ItemCarrito aux in listaCarrito)
                {
                    int i = 0;
                    int index = 0;

                    item.ID = listaCarrito.Count() + 1;
                    item.Articulo = art;
                    

                    if (aux.Articulo.ID == item.Articulo.ID)
                    {

                        item.Cantidad = int.Parse(txtCantidad.Text) + aux.Cantidad;

                        index = i;

                        i++;
                        listaCarrito.RemoveAt(index);
                        break;
                    }
                    else
                    {

                        item.Cantidad = int.Parse(txtCantidad.Text);
                    }
                }


                listaCarrito.Add(item);
                Session.Add("carrito", listaCarrito);


                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalAgregado();", true);


            }

        }
        
    }
}
    

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
        private List<Articulo> listaCarrito;

        private List<ItemCarrito> listaCarrito2;

        public List<Articulo> listaArticulo { get; set; }

        public Articulo articulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
               
                Articulo articulo = new Articulo();
                if (Session["listaCarrito2"] == null)
                {
                    listaCarrito = new List<Articulo>();
                    listaCarrito2 = new List<ItemCarrito>();
                    Session.Add("listaCarrito", listaCarrito);
                    Session.Add("listaCarrito2", listaCarrito2);
                }
                if (Request.QueryString["Id"] != null)
                {
                    int Id = Convert.ToInt32(this.Request.QueryString.Get(0));
                    listaCarrito = (List<Articulo>)Session["listaCarrito"];
                    listaCarrito2 = (List<ItemCarrito>)Session["listaCarrito2"];
                    if (Id != 0)
                    {
                        this.articulo = articulo;
                        Cargar(Id);
                        img.ImageUrl = articulo.UrlImagen.ToString();
                        lblNombre.Text = articulo.NombreArt;
                        lblDescripcion.Text = articulo.Descripcion;
                        lblPrecio.Text = '$' + articulo.Precio.ToString();
                        
                    }

                    Session.Add("listaCarrito", listaCarrito);
                    Session.Add("listaCarrito2", listaCarrito2);
                }
            }
        }
        private void Cargar(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.Listar();
                int i = 0;
                while (id != listaArticulo[i].ID)
                {
                    i++;
                }
                articulo.ID = listaArticulo[i].ID;
                articulo.Precio = listaArticulo[i].Precio;
                articulo.NombreArt = listaArticulo[i].NombreArt;
                articulo.Descripcion = listaArticulo[i].Descripcion;
                articulo.UrlImagen = listaArticulo[i].UrlImagen;
                               

                i = 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] == null)
            {
                Session.Add("error", "Debes seleccionar un producto.");
                //Response.Redirect("Error.aspx", false);
            }
            else
            {
              
                int Id = Convert.ToInt32(Request.QueryString["ID"].ToString());
                Articulo articulo = new Articulo();
                ItemCarrito elemento = new ItemCarrito();
                this.articulo = articulo;
                Cargar(Id);
               
                elemento.IDArticulo = new Articulo();
                elemento.IDArticulo.ID = Id;
                elemento.IDArticulo.NombreArt = articulo.NombreArt;
                if (txtCantidad.Text == "")
                {
                    elemento.Cantidad = 1;
                }
                else
                {
                    elemento.Cantidad = int.Parse(txtCantidad.Text);
                }
                
                elemento.PrecioUnitario = articulo.Precio;

 
            }

        }

 
    }

}

    

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
    public partial class AltaArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
			{
                if (!IsPostBack)
                {


                    CategoriaNegocio caNegocio = new CategoriaNegocio();
                    List<Categoria> listaCate = caNegocio.Listar();

                    ddlCategoria.DataSource = listaCate;
                    ddlCategoria.DataValueField = "ID";
                    ddlCategoria.DataTextField = "NombreCategoria";
                    ddlCategoria.DataBind();


                    SubCategoriaNegocio subNegocio = new SubCategoriaNegocio();
                    List<SubCategoria> listaSub = subNegocio.Listar();

                    ddlSubCategoria.DataSource = listaSub;
                    ddlSubCategoria.DataValueField = "ID";
                    ddlSubCategoria.DataTextField = "NombreSubcategoria";
                    ddlSubCategoria.DataBind();

                }

            }
			catch (Exception)
			{

				throw;
			}

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            Articulo art = new Articulo();

            try
            {
                art.ID = int.Parse(Request.QueryString["ID"]);
                art.NombreArt = textNombre.Text;
                art.Descripcion = textDescripcion.Text;
                art.IDCategoria = new Categoria();
                art.IDCategoria.ID = int.Parse(ddlCategoria.SelectedValue);
                art.IDSubCategoria = new SubCategoria();
                art.IDSubCategoria.ID = int.Parse(ddlSubCategoria.SelectedValue);
                art.UrlImagen = textURLImagen.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.Estado = chkActivo.Checked;

                negocio.Modificar(art);
                Response.Redirect("MensajeModificar.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                //Response.Redirect("", false);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            int ID = int.Parse(Request.QueryString["ID"]);

            negocio.BajaLogica(ID);

            Response.Redirect("ABMArticulo.aspx", false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                Articulo art = new Articulo();

                art.NombreArt = textNombre.Text;
                art.Descripcion = textDescripcion.Text;
                art.IDCategoria = new Categoria();
                art.IDCategoria.ID = int.Parse(ddlCategoria.SelectedValue);
                art.IDSubCategoria = new SubCategoria();
                art.IDSubCategoria.ID = int.Parse(ddlSubCategoria.SelectedValue);
                art.UrlImagen = textURLImagen.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.Estado = chkActivo.Checked;

                negocio.Agregar(art);
                Response.Redirect("/Contact.aspx", false);

            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                //Response.Redirect("", false);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio.Models;

namespace Negocio.Models
{
    public class ItemCarritoNegocio
    {
        public List<ItemCarrito> listar(int idVenta)
        {
            List<ItemCarrito> lista = new List<ItemCarrito>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT a.NombreArt, ic.Cantidad, ic.PrecioUnitario FROM ItemCarrito ic INNER JOIN Articulos a ON A.ID = ic.IDArticulo WHERE IdVenta =" + idVenta + "");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ItemCarrito aux = new ItemCarrito();
                    aux.IDArticulo = new Articulo();
                    aux.IDArticulo.NombreArt = (string)datos.Lector["NombreArt"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.PrecioUnitario = (decimal)datos.Lector["PrecioUnitario"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void guardar(ItemCarrito aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ItemCarrito(ID, IDArticulo, Cantidad, PrecioUnitario) VALUES(@ID, @IDArticulo,@Cantidad,@PrecioUnitario)");
                datos.setearParametros("@ID", aux.ID);
                datos.setearParametros("@IDArticulo", aux.IDArticulo.ID);
                datos.setearParametros("@Cantidad", aux.Cantidad);
                datos.setearParametros("@PrecioUnitario", aux.PrecioUnitario);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }

}

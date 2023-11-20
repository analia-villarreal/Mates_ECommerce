using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT a.ID, a.NombreArt,a.Descripcion ,c a.IDCategoria,c.NombreCategoria,a.IDSubCategoria, sb.NombreSubCategoria, a.URLImagen, a.Precio, a.Estado FROM Articulos a, Categorias c, SubCategorias sb WHERE a.IDCategoria = c.ID AND sb.ID=a.IDSubCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();

                    aux.ID = (int)datos.Lector["ID"];

                    aux.NombreArt = (string)datos.Lector["NombreArt"];

                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.IDCategoria = new Categoria();
                    aux.IDCategoria.ID = (int)datos.Lector["IDCategoria"];
                    aux.IDCategoria.NombreCategoria = (string)datos.Lector["NombreCategoria"];

                    aux.IDSubCategoria = new SubCategoria();
                    aux.IDSubCategoria.ID = (int)datos.Lector["IDSubCategoria"];
                    aux.IDSubCategoria.NombreSubCategoria = (string)datos.Lector["NombreSubCategoria"];


                    if (!(datos.Lector["URLImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["URLImagen"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Estado = (bool)datos.Lector["Estado"];

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

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(Diccionario.AGREGAR_ARTICULO);
                //datos.setearParametros("@Id", nuevo.ID);
                datos.setearParametros("@NombreArt", nuevo.NombreArt);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@IDCategoria", nuevo.IDCategoria);
                datos.setearParametros("@IDSubcategoria", nuevo.IDSubCategoria);
                datos.setearParametros("@URLImagen", nuevo.UrlImagen);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.setearParametros("@Estado", nuevo.Estado);
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

        public void Modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(Diccionario.MODIFICAR_ARTICULO);
                datos.setearParametros("@ID", art.ID);
                datos.setearParametros("@NombreArt", art.NombreArt);
                datos.setearParametros("@Descripcion", art.NombreArt);
                datos.setearParametros("@IDCategoria", art.IDCategoria.ID);
                datos.setearParametros("@IDSubcategoria", art.IDSubCategoria.ID);
                datos.setearParametros("@URLImagen", art.UrlImagen);
                datos.setearParametros("@Precio", art.Precio);
                datos.setearParametros("@Estado", art.Estado);
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

        public void BajaLogica(int id)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(Diccionario.BAJA_ARTICULO);
                datos.setearParametros("@ID", id);
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
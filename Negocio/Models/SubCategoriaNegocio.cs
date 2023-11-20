using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class SubCategoriaNegocio
    {
        public List<SubCategoria> Listar()
        {
            List<SubCategoria> lista = new List<SubCategoria>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT ID, NombreSubCategoria FROM SubCategorias");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    SubCategoria aux = new SubCategoria();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.NombreSubCategoria = (string)datos.Lector["NombreSubCategoria"];
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
    }
}

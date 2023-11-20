using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class Diccionario
    {
        public static string CONEXION_SERVER = "server=.\\SQLEXPRESS; database=MATES_DB; integrated security=true";

        public static string AGREGAR_ARTICULO = "insert into Articulos values (@NombreArt,@Descripcion,@IDCategoria,@IDSubcategoria,@URLImagen,@Precio,0)";

        public static string MODIFICAR_ARTICULO = "update Articulos set NombreArt = @NombreArt, Descripcion = @Descripcion,IDCategoria = @IDCategoria ,IDSubCategoria = @IDSubcategoria, URLImagen = @URLImagen, Precio = @Precio, Estado = @Estado where ID = @ID";

        public static string BAJA_ARTICULO = "update articulo set Estado = 1 where ID = @ID";
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    public enum Rol
    {
        ADMIN = 1,
        NORMAL = 2
    }


    public class Usuario
    {

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public Rol Rol { get; set; }
        public bool Estado { get; set; }

        public Usuario()
        {

        }
        public Usuario(string user, string pass, bool admin)
        {
            UserName = user;
            Pass = pass;
            Rol = admin ? Rol.ADMIN : Rol.NORMAL;
        }
    }



}
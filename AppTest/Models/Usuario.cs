using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTest.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public int tipoUsuario { get; set; }
        public int nombreUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string contrasena { get; set; }
    }
}
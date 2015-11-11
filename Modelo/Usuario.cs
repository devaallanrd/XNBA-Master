using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBUI.Models
{
    public class Usuario
    {
       

        public string nombre_usuario { get; set; }
        public string id { get; set; }
        public string tipo { get; set; }
        public int contraseña { get; set; }
        public int correo { get; set; }
        public int nombre { get; set; }
    }
}
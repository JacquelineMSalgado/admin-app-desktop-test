using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_application.Models
{
    class UsuarioModel
    {
        public int IDUsuario { get; set; }
        public string email { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }
        public string Estatus { get; set; }
        public string contrasenia { get; set; }
    }
}

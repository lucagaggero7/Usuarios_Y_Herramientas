using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios_BE
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string nombredeusuario;
        private string correo;
        private string contraseña;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombredeusuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios_BE
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombredeusuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public void Agregar(string aNombre,
                       string aApellido,
                       string aNombredeusuario,
                       string aCorreo,
                       string aContraseña)
        {
            Nombre = aNombre;
            Apellido = aApellido;
            Nombredeusuario = aNombredeusuario;
            Correo = aCorreo;
            Contraseña = aContraseña;
        }

    }
}

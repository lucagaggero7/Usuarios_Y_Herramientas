using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionUsuarios_BE
{
    public class Usuarios
    {
        public DataTable ListaDT { get; set; } = new DataTable();
        public int existe;
        public Usuarios()
        {
            ListaDT.TableName = "ListaUsuarios";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Apellido");
            ListaDT.Columns.Add("Nombredeusuario");
            ListaDT.Columns.Add("Correo");
            ListaDT.Columns.Add("Contraseña");

            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Usuarios.xml"))
            {
                ListaDT.ReadXml("Usuarios.xml");
            }
        }

        public void InsertUsuario(Usuario aUsuario)
        {
            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aUsuario.Nombre;
            ListaDT.Rows[NuevoRenglon]["Apellido"] = aUsuario.Apellido;
            ListaDT.Rows[NuevoRenglon]["Nombredeusuario"] = aUsuario.Nombredeusuario;
            ListaDT.Rows[NuevoRenglon]["Correo"] = aUsuario.Correo;
            ListaDT.Rows[NuevoRenglon]["Contraseña"] = aUsuario.Contraseña;

            ListaDT.WriteXml("Usuarios.xml");
        }

       
    
         

        

    }
}

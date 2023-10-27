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

        //Crea la Estructura de la Lista de usuarios
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

        //Lee el archivo Usuarios.xml si es que existe
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Usuarios.xml"))
            {
                ListaDT.ReadXml("Usuarios.xml");
            }
        }

        // Inserta un nuevo usuario en la lista de usuarios y luego escribe esta lista en el archivo Usuarios.xml
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

        //Nuevo metodo que verifica si existe el usuario y la contraseña en la lista de usuarios y devuelve al front un resultado
        //(En colaboracion de Mauri Gaggero)
        public bool ExisteUsuarioYContraseña(Usuarios listausuarios,
                                    Usuario user)
        {
            bool existe = false;
            foreach (DataRow row in listausuarios.ListaDT.Rows)
            {
                if (user.Nombredeusuario == (row["Nombredeusuario"].ToString()) && 
                    user.Contraseña == row["Contraseña"].ToString())
                {
                    existe = true;
                }
            }
            return existe;  
        }

        //Nuevo metodo que verifica si existe el nombre de usuario y devuelve al front un resultado
        public bool ExisteNombredeusuario(Usuarios listausuarios,
                                    Usuario user)
        {
            bool existe = false;
            foreach (DataRow row in listausuarios.ListaDT.Rows)
            {
                if (user.Nombredeusuario == (row["Nombredeusuario"].ToString()))
                {
                    existe = true;
                }
            }
            return existe;
        }










    }
}

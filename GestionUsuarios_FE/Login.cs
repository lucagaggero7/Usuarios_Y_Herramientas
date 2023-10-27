using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GestionUsuarios_BE;


namespace GestionUsuarios_FE
{
    public partial class Login : Form
    {
        public Usuarios ListaUsuarios { get; set; } = new Usuarios();

        int nombredeusuarioclick = 0;
        int contraseñaclick = 0;
        public int contador = 0;
        public int actualizar = 0;

        public Login()
        {
            InitializeComponent();
            //mostrar valores de la datatable de usuarios en el datagrid
            datagrid.DataSource = ListaUsuarios.ListaDT;
            datagrid.Visible = false;
            //mostrar o ocultar datagrid solo para pruebas de desarrollador
            //en caso de ser usado, descomentar el siguiente codigo
            //datagrid.Visible = true;
        }

        //Vaciar textbox de nombre de usuario (solo la primera vez que se hace click)
        private void txtNombredeusuario_Click(object sender, EventArgs e)
        {
            nombredeusuarioclick++;

            if (nombredeusuarioclick == 1)
            {
                txtNombredeusuario.Text = "";
            }
            else
            {
                return;
            }
        }
        
        //Vaciar textbox de contraseña (solo la primera vez que se hace click)
        private void txtContraseña_Click(object sender, EventArgs e)
        {
            contraseñaclick++;

            if (contraseñaclick == 1)
            {
                txtContraseña.Text = "";
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                return;
            }
        }

        //Abrir formulario para registrar nuevo usuario
        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            Registro f2 = new Registro();
            AddOwnedForm(f2);
            
            //este if verifica el estado del modo oscuro/claro de este formulario
            //para que el siguiente formulario inicie en el mismo modo que este
            if ((contador % 2) == 0)
            {
            }
            else
            {
                f2.btnModo_Click(this, null);
            }

            f2.ShowDialog();

        }
        // Iniciar sesion llamando al metodo que verifica si el usuario y la contraseña existen 
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bool existe;

            Usuario usuario = new Usuario();
            usuario.Nombredeusuario = txtNombredeusuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            Usuarios usuarios = new Usuarios();
            //llamamos al metodo que verifica si ya existe el usuario y la contraseña en la lista de usuarios
            existe = usuarios.ExisteUsuarioYContraseña(ListaUsuarios, usuario);

            //verificamos que el nombre de usuario y la contraseña existan en un usuario 
            // para permitir el login y dar paso al siguiente formulario
            if (existe)
            {
                Menu f3 = new Menu();
                f3.labelMenuinicio.Text = "Bienvenido" + " " + txtNombredeusuario.Text + " " + "porfavor seleccione la herramienta que desea utilizar";

                //este if verifica el estado del modo oscuro/claro de este formulario
                //para que el siguiente formulario inicie en el mismo modo que este
                if ((contador % 2) == 0)
                {
                }
                else
                {
                    f3.btnModo_Click(this, null);
                }
                f3.ShowDialog();
                txtNombredeusuario.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Error de Usuario y/o contraseña");
            }

        }
            // FUNCION DE MODO OSCURO
        private void btnModo_Click(object sender, EventArgs e)
        {
            contador++;
            if ((contador % 2) == 0)
            {
                btnModo.Text = "Modo Claro Activado";
                this.BackColor = Color.LightBlue;
                btnRegistrate.BackColor = Color.White;
                btnModo.BackColor = Color.White;
                btnIniciarSesion.BackColor = Color.White;
                txtNombredeusuario.BackColor = Color.White;
                txtContraseña.BackColor = Color.White;
                labelBienvenido.ForeColor = Color.Black;
                labelRegistrate.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
            }
            else
            {
                btnModo.Text = "Modo Oscuro Activado";
                this.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
                btnRegistrate.BackColor = Color.LightGray;
                btnModo.BackColor = Color.LightGray;
                btnIniciarSesion.BackColor = Color.LightGray;
                txtNombredeusuario.BackColor = Color.LightGray;
                txtContraseña.BackColor = Color.LightGray;
                labelBienvenido.ForeColor = Color.White;
                labelRegistrate.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
            }
        }
        //Ocultar caracteres contraseña
        private void txtContraseña_DoubleClick(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }
       
        //Ocultar caracteres contraseña
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

    }
}
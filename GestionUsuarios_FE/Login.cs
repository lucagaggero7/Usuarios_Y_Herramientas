using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GestionUsuarios_BE;
using GestionUsuarios_FE;


namespace GestionUsuarios_FE
{
    public partial class Login : FrmBase
    {
        //instanciar la lista de usuarios para usarla en el login
        public Usuarios ListaUsuarios { get; set; } = new Usuarios();

        //variables que cuentan los clicks de los textbox 
        int nombredeusuarioclick = 0;
        int contraseñaclick = 0;
        
        //variable que cuenta el estado del modo oscuro
        public int contadormodo;
        

        public Login()
        {
            InitializeComponent();
        }


        public void Login_Load(object sender, EventArgs e)
        {
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnRegistrate.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                btnIniciarSesion.BackColor = Color.Lavender;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombredeusuario.BackColor = Color.Lavender;
                txtContraseña.BackColor = Color.Lavender;
                labelBienvenido.ForeColor = Color.Black;
                labelRegistrate.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.DarkGray;
                txtContraseña.ForeColor = Color.DarkGray;

            }
            else
            {

                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                this.BackColor = Color.DimGray;
                PanelBarraTitulo.BackColor = Color.FromArgb(25, 25, 25);
                btnRegistrate.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                btnIniciarSesion.BackColor = Color.Lavender;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                txtNombredeusuario.BackColor = Color.Lavender;
                txtContraseña.BackColor = Color.Lavender;
                labelBienvenido.ForeColor = Color.White;
                labelRegistrate.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }

                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
            }
        }

        //Abrir formulario para registrar nuevo usuario
        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            Registro form2 = new Registro();
            form2.contadormodo = contadormodo;
            //AddOwnedForm(form2);
            this.Hide();
            form2.Show();
            

        }
     
       
        // Iniciar sesion llamando al metodo que verifica si el usuario y la contraseña existen 
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            bool existe;

            Usuario usuario = new Usuario();
            usuario.Nombredeusuario = txtNombredeusuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            Usuarios usuarios = new Usuarios();
            //llamamos al metodo que verifica si ya existe el usuario y la contraseña en la lista de usuarios
            existe = usuarios.ExisteUsuarioYContraseña(ListaUsuarios, usuario);

            //verificamos que el nombre de usuario y la contraseña existan en un usuario mediante un if
            // para permitir el login y dar paso al siguiente formulario
            if (existe)
            {
                Menu form3 = new Menu();
                
                form3.labelMenuinicio.Text = "Bienvenido" + " " + txtNombredeusuario.Text + " " + "seleccione la herramienta que desea utilizar";

                //AddOwnedForm(form3);
                form3.contadormodo = contadormodo;

                this.Hide();
                form3.Show();
                txtNombredeusuario.Text = "";
                txtContraseña.Text = "";
            }
            //en caso de que el usuario y la contraseña no existan o no coincidan
            //se muestra un mensaje de error
            else
            {
                MessageBox.Show("Error de Usuario y/o contraseña");
            }

        }
            
        
        // FUNCION DE MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            contadormodo++;
            //label1.Text = contadormodo.ToString();
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombredeusuario.BackColor = Color.Lavender;
                txtContraseña.BackColor = Color.Lavender;
                labelBienvenido.ForeColor = Color.Black;
                labelRegistrate.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }

                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
            }
            else
            {
            
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                this.BackColor = Color.DimGray;
                PanelBarraTitulo.BackColor = Color.FromArgb(25, 25, 25);
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                txtNombredeusuario.BackColor = Color.Lavender;
                txtContraseña.BackColor = Color.Lavender;
                labelBienvenido.ForeColor = Color.White;
                labelRegistrate.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }

                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
            }
        }

        //Vaciar textbox de nombre de usuario (solo la primera vez que se hace click)
        // usando la variable contador de clicks
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
        // usando la variable contador de clicks
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

        //Ocultar caracteres contraseña
        private void txtContraseña_DoubleClick(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }
       
       
        //Ocultar caracteres contraseña
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contraseñaclick++;
            txtContraseña.PasswordChar = '*';
            txtContraseña.ForeColor = Color.Black;
        }


        private void txtNombredeusuario_TextChanged(object sender, EventArgs e)
        {
            txtNombredeusuario.ForeColor = Color.Black;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
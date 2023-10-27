using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios_BE;
using Gestion_UsuariosFE;
using GestionUsuarios_FE;


namespace GestionUsuarios_FE
{
    public partial class Registro : Form
    {
        Usuario myUsuario = new Usuario();
        public int contador = 0;
        int Valorverif;
        decimal Verificacion;
        public Usuarios ListaUsuarios { get; set; } = new Usuarios();

        public Registro()
        {
            InitializeComponent();
            //mostrar valores de la datatable de usuarios en el datagrid
            datagrid.DataSource = ListaUsuarios.ListaDT;
            datagrid.Visible = false;
            //mostrar o ocultar datagrid solo para pruebas de desarrollador
            //en caso de ser usado, descomentar el siguiente codigo
            //datagrid.Visible = true;
        }

        // Crear usuario nuevo verificando que todos los campos esten completos y que la verificacion cumpla con las condiciones
        // y el nombre de usuario ingresado no exista aun
        private void btnCrear_Click(object sender, EventArgs e)
        {



            if (!(txtNombre.Text == ""))
            {
                //borro el error 
                errorNombre.SetError(txtNombre, "");
            }
            else
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }

            if (!(txtApellido.Text == ""))
            {
                //borro el error 
                errorApellido.SetError(txtApellido, "");
            }
            else
            {
                errorApellido.SetError(txtApellido, "Debe ingresar un apellido");
                txtApellido.Focus();
                return;

            }

            if (!(txtNombredeusuario.Text == ""))
            {
                //borro el error 
                errorNombredeusuario.SetError(txtNombredeusuario, "");
            }
            else
            {
                errorNombredeusuario.SetError(txtNombredeusuario, "Debe ingresar un nombre de usuario");
                txtNombredeusuario.Focus();
                return;
            }

            if (!(txtCorreo.Text == ""))
            {
                //borro el error 
                errorCorreo.SetError(txtCorreo, "");
            }
            else
            {
                errorCorreo.SetError(txtCorreo, "Debe ingresar un correo electronico");
                txtCorreo.Focus();
                return;
            }

            if (!(txtContraseña.Text == ""))
            {
                //borro el error 
                errorContraseña.SetError(txtContraseña, "");
            }
            else
            {
                errorContraseña.SetError(txtContraseña, "Debe ingresar una contraseña");
                txtContraseña.Focus();
                return;
            }

            if (!(txtVerificacion.Text == ""))
            {
                //borro el error 
                errorVerificacion.SetError(txtVerificacion, "");
            }
            else
            {
                errorVerificacion.SetError(txtVerificacion, "Debe ingresar una verificacion");
                txtVerificacion.Focus();
                return;
            }

            do
            {
                if (Decimal.TryParse(txtVerificacion.Text, out Verificacion))

                {
                    //borro el error 
                    errorVerificacion.SetError(txtVerificacion, "");
                    Valorverif = int.Parse(txtVerificacion.Text);
                }
                else
                {
                    errorVerificacion.SetError(txtVerificacion, "Ingrese un dato numerico");
                    return;
                }

                
                if (Valorverif >= 10 && Valorverif <= 15)

                {
                    //borro el error 
                    errorVerificacion.SetError(txtVerificacion, "");

                }
                else
                {
                    errorVerificacion.SetError(txtVerificacion, "Ingrese un numero entre 10 y 15");
                    return;
                }



            } while (Valorverif < 10 || Valorverif > 15);


            bool existe;

            Usuario usuario = new Usuario();
            usuario.Nombredeusuario = txtNombredeusuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            Usuarios usuarios = new Usuarios();

            //llamamos al metodo que verifica si ya existe el nombre de usuario en la lista de usuarios
            existe = usuarios.ExisteNombredeusuario(ListaUsuarios, usuario);

            //verificamos que el nombre de usuario ingresado aun no exista para poder registrar un nuevo usuario
            if (existe == false)
            {

                Usuario user = new Usuario();
                user.Agregar(txtNombre.Text,
                            txtApellido.Text,
                            txtNombredeusuario.Text,
                            txtCorreo.Text,
                            txtContraseña.Text);

                ListaUsuarios.InsertUsuario(user);
                myUsuario.Nombre = txtNombre.Text;
                myUsuario.Apellido = txtApellido.Text;
                myUsuario.Nombredeusuario = txtNombredeusuario.Text;
                myUsuario.Correo = txtCorreo.Text;
                myUsuario.Contraseña = txtContraseña.Text;
                MessageBox.Show("Usuario Registrado");
                this.Close();



                //este codigo se utiliza para actualizar el datagrid view
                // del login cuando se registra un nuevo usuario sin tener que reiniciar el programa
                //(solo usado para pruebas de desarrollador)
                //en caso de ser usado, descomentar el siguiente codigo
                //Login f1 = Owner as Login;
                //f1.datagrid.DataSource = ListaUsuarios.ListaDT;
                //f1.ListaUsuarios.ListaDT = ListaUsuarios.ListaDT;
            }
            else
            {
                MessageBox.Show("Ya existe ese nombre de usuario");
                return;
            }

        }

        // FUNCION DE MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            
            contador++;
            if ((contador % 2) == 0)
            {
                btnModo.Text = "Modo Claro Activado";
                this.BackColor = Color.LightBlue;
                btnCrear.BackColor = Color.White;
                btnModo.BackColor = Color.White;
                txtNombre.BackColor = Color.White;
                txtApellido.BackColor = Color.White;
                txtNombredeusuario.BackColor = Color.White;
                txtCorreo.BackColor = Color.White;
                txtContraseña.BackColor = Color.White;
                txtVerificacion.BackColor = Color.White;
                labelNombre.ForeColor = Color.Black;
                labelApellido.ForeColor = Color.Black;
                labelNombredeusuario.ForeColor = Color.Black;
                labelCorreo.ForeColor = Color.Black;
                labelContraseña.ForeColor = Color.Black;
                labelVerificacion.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.Black;
                txtApellido.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtVerificacion.ForeColor = Color.Black;
            }
            else
            {
                btnModo.Text = "Modo Oscuro Activado";
                this.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
                btnCrear.BackColor = Color.LightGray;
                btnModo.BackColor = Color.LightGray;
                txtNombre.BackColor = Color.LightGray;
                txtApellido.BackColor = Color.LightGray;
                txtNombredeusuario.BackColor = Color.LightGray;
                txtCorreo.BackColor = Color.LightGray;
                txtContraseña.BackColor = Color.LightGray;
                txtVerificacion.BackColor = Color.LightGray;
                labelNombre.ForeColor = Color.White;
                labelApellido.ForeColor = Color.White;
                labelNombredeusuario.ForeColor = Color.White;
                labelCorreo.ForeColor = Color.White;
                labelContraseña.ForeColor = Color.White;
                labelVerificacion.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                label1.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.Black;
                txtApellido.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtVerificacion.ForeColor = Color.Black;
            }
        }
    }
}

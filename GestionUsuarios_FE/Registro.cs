using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios_BE;
using GestionUsuarios_FE;


namespace GestionUsuarios_FE
{
    public partial class Registro : FrmBase
    {
        Usuario myUsuario = new Usuario();

        public int contadormodo = 0;
        
        int Valorverif;
        decimal Verificacion;
        public Usuarios ListaUsuarios { get; set; } = new Usuarios();

        //variables que cuentan los clicks de los textbox 
        int nombreclick = 0;
        int apellidoclick = 0;
        int nombredeusuarioclick = 0;
        int correoclick = 0;
        int contraseñaclick = 0;
        int verificacionclick = 0;


        public Registro()
        {
            InitializeComponent();
            checkOcultar.Checked = true;
        }

        //FUNCION MODO OSCURO
        private void Registro_Load(object sender, EventArgs e)
        {
            //Login f1 = Owner as Login;
            //contadormodo = f1.contadormodo;
           
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.AliceBlue;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCrear.BackColor = Color.AliceBlue;
                btnModo.BackColor = Color.AliceBlue;
                btnIniciarSesion.BackColor = Color.AliceBlue;
                btnCrear.FlatAppearance.BorderColor = Color.DarkGray;
                btnModo.FlatAppearance.BorderColor = Color.DarkGray;
                btnIniciarSesion.FlatAppearance.BorderColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombre.BackColor = Color.AliceBlue;
                txtApellido.BackColor = Color.AliceBlue;
                txtNombredeusuario.BackColor = Color.AliceBlue;
                txtCorreo.BackColor = Color.AliceBlue;
                txtContraseña.BackColor = Color.AliceBlue;
                txtVerificacion.BackColor = Color.AliceBlue;
                labelVerificacion.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                checkOcultar.ForeColor = Color.Black;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }
                if (txtCorreo.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtCorreo.ForeColor = Color.DarkGray;
                }
                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
                if (txtVerificacion.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtVerificacion.ForeColor = Color.DarkGray;
                }
            }
            else
            {
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                this.BackColor = Color.DimGray;
                PanelBarraTitulo.BackColor = Color.FromArgb(25, 25, 25);
                btnCrear.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                btnIniciarSesion.BackColor = Color.Lavender;
                txtNombre.BackColor = Color.Lavender;
                txtApellido.BackColor = Color.Lavender;
                txtNombredeusuario.BackColor = Color.Lavender;
                txtCorreo.BackColor = Color.Lavender;
                txtContraseña.BackColor = Color.Lavender;
                txtVerificacion.BackColor = Color.Lavender;
                labelVerificacion.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                checkOcultar.ForeColor = Color.White;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }
                if (txtCorreo.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtCorreo.ForeColor = Color.DarkGray;
                }
                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
                if (txtVerificacion.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtVerificacion.ForeColor = Color.DarkGray;
                }
            }
        }

        //FUNCION MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            contadormodo++;
            //Login f1 = Owner as Login;
            //f1.contadormodo = contadormodo;
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.AliceBlue;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCrear.BackColor = Color.AliceBlue;
                btnModo.BackColor = Color.AliceBlue;
                btnIniciarSesion.BackColor = Color.AliceBlue;
                btnCrear.FlatAppearance.BorderColor = Color.DarkGray;
                btnModo.FlatAppearance.BorderColor = Color.DarkGray;
                btnIniciarSesion.FlatAppearance.BorderColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombre.BackColor = Color.AliceBlue;
                txtApellido.BackColor = Color.AliceBlue;
                txtNombredeusuario.BackColor = Color.AliceBlue;
                txtCorreo.BackColor = Color.AliceBlue;
                txtContraseña.BackColor = Color.AliceBlue;
                txtVerificacion.BackColor = Color.AliceBlue;
                labelVerificacion.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                checkOcultar.ForeColor = Color.Black;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }
                if (txtCorreo.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtCorreo.ForeColor = Color.DarkGray;
                }
                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
                if (txtVerificacion.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtVerificacion.ForeColor = Color.DarkGray;
                }
            }
            else
            {
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                this.BackColor = Color.DimGray;
                PanelBarraTitulo.BackColor = Color.FromArgb(25, 25, 25);
                btnCrear.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                btnIniciarSesion.BackColor = Color.Lavender;
                txtNombre.BackColor = Color.Lavender;
                txtApellido.BackColor = Color.Lavender;
                txtNombredeusuario.BackColor = Color.Lavender;
                txtCorreo.BackColor = Color.Lavender;
                txtContraseña.BackColor = Color.Lavender;
                txtVerificacion.BackColor = Color.Lavender;
                labelVerificacion.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                checkOcultar.ForeColor = Color.White;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
                if (txtNombredeusuario.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombredeusuario.ForeColor = Color.DarkGray;
                }
                if (txtCorreo.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtCorreo.ForeColor = Color.DarkGray;
                }
                if (txtContraseña.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtContraseña.ForeColor = Color.DarkGray;
                }
                if (txtVerificacion.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtVerificacion.ForeColor = Color.DarkGray;
                }
            }
        }


        // Crear usuario nuevo verificando que todos los campos esten completos y que la verificacion cumpla con las condiciones
        // y el nombre de usuario ingresado no exista aun
        private void btnCrear_Click(object sender, EventArgs e)
        {



            if (txtNombre.Text != "" && txtNombre.Text != "Nombre" )
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

            if (txtApellido.Text != "" && txtApellido.Text != "Apellido")
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

            if (txtNombredeusuario.Text != "" && txtNombredeusuario.Text != "Nombre de usuario")
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

            if (txtCorreo.Text != "" && txtCorreo.Text != "Correo")
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

            if (txtContraseña.Text != "" && txtContraseña.Text != "Contraseña")
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
                this.ActiveControl = PanelBarraTitulo;
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

                MessageBox.Show("Usuario Registrado");

                Login form1 = new Login();
                form1.contadormodo = contadormodo;
                form1.Login_Load(this, null);
                form1.Show();
                this.Close();


                //este codigo se utiliza para actualizar la lista de usuarios
                //del formulario padre (login) cuando se registra un usuario 
                //en el formulario de registro (hijo)
                form1.ListaUsuarios.ListaDT = ListaUsuarios.ListaDT;


                //este codigo se utiliza para actualizar el datagrid view
                // del login cuando se registra un nuevo usuario sin tener que reiniciar el programa
                //(solo usado para pruebas de desarrollador)
                //en caso de ser usado, descomentar el siguiente codigo

                //f1.datagrid.DataSource = ListaUsuarios.ListaDT;

            }
            else
            {
                errorNombredeusuario.SetError(txtNombredeusuario, "El usuario ingresado ya esta en uso");
                return;
            }

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;

            if (nombreclick == 1)
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_DoubleClick(object sender, EventArgs e)
        {
            nombreclick++;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombreclick++;
            txtNombre.ForeColor = Color.Black;
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {

            apellidoclick++;
            if (apellidoclick == 1)
            {
                txtApellido.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtApellido_DoubleClick(object sender, EventArgs e)
        {
            apellidoclick++;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            apellidoclick++;
            txtApellido.ForeColor = Color.Black;
        }

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

        private void txtNombredeusuario_DoubleClick(object sender, EventArgs e)
        {
            nombredeusuarioclick++;
        }

        private void txtNombredeusuario_TextChanged(object sender, EventArgs e)
        {
            nombredeusuarioclick++;
            txtNombredeusuario.ForeColor = Color.Black;

        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            correoclick++;
            if (correoclick == 1)
            {
                txtCorreo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCorreo_DoubleClick(object sender, EventArgs e)
        {
            correoclick++;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            correoclick++;
            txtCorreo.ForeColor = Color.Black;
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            contraseñaclick++;
            if (contraseñaclick == 1)
            {
                txtContraseña.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtContraseña_DoubleClick(object sender, EventArgs e)
        {
            contraseñaclick++;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contraseñaclick++;
            txtContraseña.ForeColor = Color.Black;

            if (checkOcultar.Checked == true && txtContraseña.Text != "Contraseña")
            {
                txtContraseña.PasswordChar = '*';

            }
            else
            {
                txtContraseña.PasswordChar = '\0';
            }

        }

        private void txtVerificacion_Click(object sender, EventArgs e)
        {
            verificacionclick++;
            if (verificacionclick == 1)
            {
                txtVerificacion.Text = "";
            }
            else
            {
                return;
            }
        }
        private void txtVerificacion_TextChanged(object sender, EventArgs e)
        {
            verificacionclick++;
            txtVerificacion.ForeColor = Color.Black;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.contadormodo = contadormodo;
            form1.Login_Load(this, null);
            form1.Show();
            this.Close();

        }

        private void checkOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOcultar.Checked == true && txtContraseña.Text != "Contraseña")
            {
                txtContraseña.PasswordChar = '*';
                
            }
            else
            {
                txtContraseña.PasswordChar = '\0';
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.contadormodo = contadormodo;
            form1.Login_Load(this, null);
            form1.Show();
            this.Close();
        }

       

        
        //
        //

    }
}

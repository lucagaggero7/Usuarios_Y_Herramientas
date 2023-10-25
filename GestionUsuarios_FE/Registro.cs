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
        int valor;
        public int contador = 0;
       public Usuarios ListaUsuarios { get; set; } = new Usuarios();

        public Registro()
        {
            InitializeComponent();
            //mostrar valores de la datatable de usuarios en el datagrid
            datagrid.DataSource = ListaUsuarios.ListaDT;
            //mostrar o ocultar datagrid solo para pruebas de desarrollador
            datagrid.Visible = false;
        }
        
        // Crear usuario nuevo verificando que todos los campos esten completos y que la verificacion cumpla con las condiciones
        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorNombre.SetError(txtNombre, "");
                if (txtApellido.Text == "")
                {
                    errorApellido.SetError(txtApellido, "Debe ingresar un apellido");
                    txtApellido.Focus();
                    return;
                }
                else
                {
                    errorApellido.SetError(txtApellido, "");
                    if (txtNombredeusuario.Text == "")
                    {
                        errorNombredeusuario.SetError(txtNombredeusuario, "Debe ingresar un nombre de usuario");
                        txtNombredeusuario.Focus();
                        return;
                    }
                    else
                    {
                        errorNombredeusuario.SetError(txtNombredeusuario, "");
                        if (txtCorreo.Text == "")
                        {
                            errorCorreo.SetError(txtCorreo, "Debe ingresar un correo electronico");
                            txtCorreo.Focus();
                            return;
                        }
                        else
                        {
                            errorCorreo.SetError(txtCorreo, "");
                            if (txtContraseña.Text == "")
                            {
                                errorContraseña.SetError(txtContraseña, "Debe ingresar un contraseña");
                                txtContraseña.Focus();
                                return;
                            }
                            else
                            {
                                errorContraseña.SetError(txtContraseña, "");
                                if (txtVerificacion.Text == "")
                                {
                                    errorVerificacion.SetError(txtVerificacion, "Debe ingresar el codigo de verificacion");
                                    txtVerificacion.Focus();
                                    return;
                                }
                                else
                                {
                                    do
                                    {
                                        decimal Verificacion;
                                        if (!Decimal.TryParse(txtVerificacion.Text, out Verificacion))

                                        {
                                            errorVerificacion.SetError(txtVerificacion, "Ingrese un dato numerico");
                                            return;
                                        }
                                        else
                                        {
                                            valor = int.Parse(txtVerificacion.Text);
                                            if (valor >= 10 && valor <= 15)

                                            {
                                                
                                                Usuario user = new Usuario();
                                                user.Agregar(txtNombre.Text,
                                                            txtApellido.Text,
                                                            txtNombredeusuario.Text,
                                                            txtCorreo.Text,
                                                            txtContraseña.Text);

                                                ListaUsuarios.InsertUsuario(user);
                                                //
                                                myUsuario.Nombre = txtNombre.Text;
                                                myUsuario.Apellido = txtApellido.Text;
                                                myUsuario.Nombredeusuario = txtNombredeusuario.Text;
                                                myUsuario.Correo = txtCorreo.Text;
                                                myUsuario.Contraseña = txtContraseña.Text;
                                                MessageBox.Show("Usuario Registrado");


                                                Login f1 = Owner as Login;
                                                f1.datagrid.DataSource = ListaUsuarios.ListaDT;
                                                f1.ListaUsuarios.ListaDT = ListaUsuarios.ListaDT;
                                                this.Close();

                                                errorVerificacion.SetError(txtVerificacion, "");
                                            }
                                            else
                                            {
                                                errorVerificacion.SetError(txtVerificacion, "Verificacion humano incorrecta");
                                                return;
                                            }
                                               
                                        }

                                    } while (valor < 10 || valor > 15);
                                }
                            }
                        }
                    }
                }    
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

using SYO;
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

namespace Gestion_Usuarios
{
    public partial class Form1 : Form
    {
        Usuario myUsuario = new Usuario();
        int valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;

            }
            errorNombre.SetError(txtNombre, "");

            if (txtApellido.Text == "")
            {
                errorApellido.SetError(txtApellido, "Debe ingresar un apellido");
                txtApellido.Focus();
                return;
            }
            errorApellido.SetError(txtApellido, "");

            if (txtNombredeusuario.Text == "")
            {
                errorNombredeusuario.SetError(txtNombredeusuario, "Debe ingresar un nombre de usuario");
                txtNombredeusuario.Focus();
                return;
            }
            errorNombredeusuario.SetError(txtNombredeusuario, "");

            if (txtCorreo.Text == "")
            {
                errorCorreo.SetError(txtCorreo, "Debe ingresar un correo electronico");
                txtCorreo.Focus();
                return;
            }
            errorCorreo.SetError(txtCorreo, "");

            if (txtContraseña.Text == "")
            {
                errorContraseña.SetError(txtContraseña, "Debe ingresar un contraseña");
                txtContraseña.Focus();
                return;
            }
            errorContraseña.SetError(txtContraseña, "");

            if (txtVerificacion.Text == "")
            {
                errorVerificacion.SetError(txtVerificacion, "Debe ingresar el codigo de verificacion");
                txtVerificacion.Focus();
                return;
            }
            
            do
            {
                decimal Verificacion;
                if(!Decimal.TryParse(txtVerificacion.Text, out Verificacion))
                
                {
                    errorVerificacion.SetError(txtVerificacion,"Igrese un dato numerico");
                    return;
                }    
                
                valor = int.Parse(txtVerificacion.Text);
                if (valor >= 10 && valor <= 15)
                {
                    MessageBox.Show("Verificacion de Humano Correcta");

                    myUsuario.Nombre = txtNombre.Text;
                    myUsuario.Apellido = txtApellido.Text;
                    myUsuario.Nombredeusuario = txtNombredeusuario.Text;
                    myUsuario.Correo = txtCorreo.Text;
                    myUsuario.Contraseña = txtContraseña.Text;
                    MessageBox.Show("Registro Completado");
                    Form formulario = new Form2();
                    formulario.Show();
                }
                else
                {
                    MessageBox.Show("Verificacion de Humano Incorrecta");
                    break;
                }

            } while (valor < 10 || valor > 15);

        }


        private void txtVerificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
        }
    }
}

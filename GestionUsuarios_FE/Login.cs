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
        Registro f2 = new Registro();
        
        public Usuarios ListaUsuarios { get; set; } = new Usuarios();
        public DataTable ListaDT { get; set; } = new DataTable();


        int nombredeusuarioclick = 0;
        int contraseñaclick = 0;
        int logear = 0;
        public int contador = 0;
        public int actualizar = 0;

        

        public Login()
        {
            InitializeComponent();
            //mostrar valores de la datatable de usuarios en el datagrid
            datagrid.DataSource = ListaUsuarios.ListaDT;
            //mostrar o ocultar datagrid solo para pruebas de desarrollador
            datagrid.Visible = false;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            Registro f2 = new Registro();
            AddOwnedForm(f2);
            
            if ((contador % 2) == 0)
            {

            }
            else
            {
                f2.btnModo_Click(this, null);
            }

            f2.ShowDialog();

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ListaUsuarios.ListaDT.Rows)
            {

                if (txtNombredeusuario.Text == (row["Nombredeusuario"].ToString()))
                {
                   if(txtContraseña.Text == (row["Contraseña"].ToString()))
                    {
                        Menu f3 = new Menu();
                        if ((contador % 2) == 0)
                        {

                        }
                        else
                        {
                            f3.btnModo_Click(this, null);
                        }

                        f3.ShowDialog();
                        
                        //txtNombredeusuario.Text = "";
                        //txtContraseña.Text = "";
                        logear = 1;
                        break;
                    }
                   
                }
                else
                {
                    logear = 0;
                }    

            }

            if( logear == 0)
            {
                MessageBox.Show("Error de Usuario y/o contraseña");
            }

            


            //intentos fallidos de recorrer el datatable
            //if(ListaDT.Rows.Contains(txtNombredeusuario))
            //{
            //    Menu.Menu f3 = new Menu.Menu();
            //    f3.ShowDialog();
            //}


            //ListaUsuarios.LeerArchivo();
            //if(ListaDT.Rows.Contains(?))

            //{
            //    Menu.Menu f3 = new Menu.Menu();
            //    f3.ShowDialog();
            //}
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            // FUNCION DE MODO OSCURO
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

        private void txtContraseña_DoubleClick(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void Inicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
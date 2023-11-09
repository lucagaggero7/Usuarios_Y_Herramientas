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
using GestionUsuarios_BE;
using GestionUsuarios_FE;

namespace GestionUsuarios_FE
{
    public partial class Menu : FrmBase
    {
        //variable que cuenta el estado del modo oscuro
        public int contadormodo = 0;
        public Menu()
        {
            InitializeComponent();
            this.ActiveControl = PanelBarraTitulo;
        }


        public void Menu_Load(object sender, EventArgs e)
        {
                //Login f1 = Owner as Login;
                //contadormodo = f1.contadormodo;

                if ((contadormodo % 2) == 0)
                {
                    btnModo.Text = "Modo Claro\r\nActivado\r\n";
                    this.BackColor = Color.Lavender;
                    PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                    btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                    btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                    btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                    btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                    labelMenuinicio.ForeColor = Color.Black;
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
                    labelMenuinicio.ForeColor = Color.White;
                }
        }


        //Abre la herramienta calculadora y le da el valor del contador del formulario actual
        //para que copie el estado del modo oscuro/claro actual
        private void btnCalculadora_Click(object sender, EventArgs e)
        {

            Calculadora form4 = new Calculadora();
            //AddOwnedForm(form4);
            form4.contadormodo = contadormodo;
            this.Hide();
            form4.Show();


        }

        // FUNCION DE MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            contadormodo++;
            //Login f1 = Owner as Login;
            //f1.contadormodo = contadormodo;
            //f1.label1.Text = contadormodo.ToString();
            
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                labelMenuinicio.ForeColor = Color.Black;
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
                labelMenuinicio.ForeColor = Color.White;

            }
        }
        //Abre la herramienta reloj y le da el valor del contador del formulario actual
        //para que copie el estado del modo oscuro/claro actual
        private void btnReloj_Click(object sender, EventArgs e)
        {
            Reloj form5 = new Reloj();
            //AddOwnedForm(form5);
            form5.contadormodo = contadormodo;
            this.Hide();
            form5.Show();
        }

        //Herramienta de alarma en desarrollo...
        private void btnAlarma_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            MessageBox.Show("Mas funciones muy pronto");
        }

        //Herramienta de temporizador en desarrollo...
        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            MessageBox.Show("Mas funciones muy pronto");
        }

       
        //Boton para cerrar la aplicacion en Barra Superior
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            Login form1 = new Login();
            
            form1.contadormodo = contadormodo;
            form1.Login_Load(this, null);
            form1.Show();
            this.Close();
        }

        //Boton para minimizar la aplicacion en Barra Superior
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
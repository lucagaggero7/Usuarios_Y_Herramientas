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

namespace GestionUsuarios_FE
{
    public partial class Reloj : FrmBase
    {
        private Timer ti;
        public int contadormodo = 0;


        public Reloj()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        public void Reloj_Load(object sender, EventArgs e)
        {
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

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
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

            }
        }


        //escribe en el texto del label la hora actual
        private void eventoTimer(object ob, EventArgs evt)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // FUNCION DE MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {

            contadormodo++;

            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n  ";
                this.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

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
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

            }
        }


        //Boton para cerrar la aplicacion en Barra Superior
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu f3 = new Menu();
            //f3.Menu_Load(this, e);
            //f3.Show();

            Menu form3 = new Menu();
            form3.contadormodo = contadormodo;
            form3.Menu_Load(this, null);
            form3.Show();
            this.Close();

        }

        //Boton para minimizar la aplicacion en Barra Superior
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
    }

}


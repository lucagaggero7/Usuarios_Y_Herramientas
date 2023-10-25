using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios_FE
{
    public partial class Reloj : Form
    {

        private Timer ti;
        public int contador = 0;
        public Reloj()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }
        
        

        private void Reloj_Load(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void btnModo_Click(object sender, EventArgs e)
        {
            // FUNCION DE MODO OSCURO
            contador++;

            if ((contador % 2) == 0)
            {
                btnModo.Text = "Modo Claro Activado";
                this.BackColor = Color.LightBlue;
                btnModo.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

            }
            else
            {
                btnModo.Text = "Modo Oscuro Activado";
                this.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
                btnModo.BackColor = Color.LightGray;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

            }
        }
    }
}

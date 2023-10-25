using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios_BE;
using GestionUsuarios_FE;

namespace GestionUsuarios_FE
{
    public partial class Menu : Form
    {
        public int contador = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
           
            Calculadora f4 = new Calculadora();
            if ((contador % 2) == 0)
            {
               
            }
            else
            {
                f4.buttonModo_Click(this, null);
            }

            f4.ShowDialog();


        }

        public void btnModo_Click(object sender, EventArgs e)
        {
            // FUNCION DE MODO OSCURO
            contador++;
            //Inicio.Inicio f1 = new Inicio.Inicio();
            //f1.contador = contador;

            if ((contador % 2) == 0)
            {
                btnModo.Text = "Modo Claro Activado";
                this.BackColor = Color.LightBlue;
                btnModo.BackColor = Color.White;
                btnAlarma.BackColor = Color.White;
                btnCalculadora.BackColor = Color.White;
                btnReloj.BackColor = Color.White;
                btnTemporizador.BackColor = Color.White;
                labelMenuinicio.ForeColor = Color.Black;
            }
            else
            {
                btnModo.Text = "Modo Oscuro Activado";
                this.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
                btnModo.BackColor = Color.LightGray;
                btnAlarma.BackColor = Color.LightGray;
                btnCalculadora.BackColor = Color.LightGray;
                btnReloj.BackColor = Color.LightGray;
                btnTemporizador.BackColor = Color.LightGray;
                labelMenuinicio.ForeColor = Color.White;

            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnReloj_Click(object sender, EventArgs e)
        {
           Reloj f5 = new Reloj();
            if ((contador % 2) == 0)
            {

            }
            else
            {
                f5.btnModo_Click(this, null);
            }
            f5.Show();
        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mas funciones muy pronto");
        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mas funciones muy pronto");
        }
    }
}
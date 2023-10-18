using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4

    }
    public partial class Calculadora : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        public int contador = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = numero;
            }
            else
            {
                textBox1.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Error Matematico");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;


        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(textBox1.Text);
            lblHistorial.Text = textBox1.Text + operador;
            textBox1.Text = "0";
        }
        private void buttonMas_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(textBox1.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                textBox1.Text = Convert.ToString(resultado);
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblHistorial.Text = "";
        }

        public void buttonModo_Click(object sender, EventArgs e)
        {
            contador++;
            if ((contador % 2) == 0)
            {
                buttonModo.Text = "Modo Claro Activado";
                this.BackColor = Color.LightBlue;
                button0.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                buttonMas.BackColor = Color.White;
                buttonMenos.BackColor = Color.White;
                buttonMultiplicacion.BackColor = Color.White;
                buttonDividir.BackColor = Color.White;
                buttonIgual.BackColor = Color.White;
                buttonBorrar.BackColor = Color.White;
                buttonModo.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                lblHistorial.BackColor = Color.White;
            }
            else
            {
                buttonModo.Text = "Modo Oscuro Activado";
                this.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
                button0.BackColor = Color.LightGray;
                button1.BackColor = Color.LightGray;
                button2.BackColor = Color.LightGray;
                button3.BackColor = Color.LightGray;
                button4.BackColor = Color.LightGray;
                button5.BackColor = Color.LightGray;
                button6.BackColor = Color.LightGray;
                button7.BackColor = Color.LightGray;
                button8.BackColor = Color.LightGray;
                button9.BackColor = Color.LightGray;
                buttonMas.BackColor = Color.LightGray;
                buttonMenos.BackColor = Color.LightGray;
                buttonMultiplicacion.BackColor = Color.LightGray;
                buttonDividir.BackColor = Color.LightGray;
                buttonIgual.BackColor = Color.LightGray;
                buttonBorrar.BackColor = Color.LightGray;
                buttonModo.BackColor = Color.LightGray;
                textBox1.BackColor = Color.LightGray;
                lblHistorial.BackColor = Color.LightGray;

            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
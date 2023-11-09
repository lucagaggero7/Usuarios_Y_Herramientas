using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionUsuarios_FE
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4

    }
    public partial class Calculadora : FrmBase
    {
        //variables de diseño
        public int borderRadius = 20;
        public int borderSize = 2;
        public Color borderColor = Color.Indigo;

        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        public int contadormodo = 0;
        public bool clicknumeros;
        public Calculadora()
        {
            InitializeComponent();
        }

        //Funcion de modo oscuro
        public void Calculadora_Load(object sender, EventArgs e)
        {
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.SteelBlue;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                textBox1.BackColor = Color.Lavender;
                lblHistorial.BackColor = Color.Lavender;
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
                textBox1.BackColor = Color.Lavender;
                lblHistorial.BackColor = Color.Lavender;

            }
        }


        private void btnModo_Click(object sender, EventArgs e)
        {
            contadormodo++;
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.SteelBlue;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                textBox1.BackColor = Color.Lavender;
                lblHistorial.BackColor = Color.Lavender;
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
                textBox1.BackColor = Color.Lavender;
                lblHistorial.BackColor = Color.Lavender;

            }
        }

        //Lee el numero ingresado por el usuario en el textbox
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

        //Ejecuta una operacion dependiendo del operador que el usuario selecciona y devuelve un resultado
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

        //Agrega el numero cero al textbox
        private void button0_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        //Agrega el numero uno al textbox
        private void button1_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("1");
        }

        //Agrega el numero dos al textbox
        private void button2_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("2");
        }

        //Agrega el numero tres al textbox
        private void button3_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("3");
        }

        //Agrega el numero cuatro al textbox
        private void button4_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("4");
        }

        //Agrega el numero cinco al textbox
        private void button5_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("5");
        }

        //Agrega el numero seis al textbox
        private void button6_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("6");
        }

        //Agrega el numero siete al textbox
        private void button7_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("7");
        }

        //Agrega el numero ocho al textbox
        private void button8_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("8");
        }

        //Agrega el numero nueve al textbox
        private void button9_Click(object sender, EventArgs e)
        {
            clicknumeros = true;
            LeerNumero("9");
        }

        //Obtiene el valor de resultado en el textbox y escribe el historial en su respectivo label
        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(textBox1.Text);
            lblHistorial.Text = textBox1.Text + operador;
            textBox1.Text = "0";
        }

        //convierte al operador en "+"
        private void buttonMas_Click(object sender, EventArgs e)
        {
            if (clicknumeros == true)
            {
                operador = Operacion.Suma;
                ObtenerValor("+");
            }
            else
            {
                return;
            }

        }

        //Obtiene el resultado de la operacion, vuelve los dos valores a cero y escribe el resultado en el textbox
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (clicknumeros == true)
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
            else
            {
                return;
            }    
        }

        //convierte al operador en "-"
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (clicknumeros == true)
            {
                operador = Operacion.Resta;
                ObtenerValor("-");
            }
            else
            {
                return;
            }
        }

        //convierte al operador en "x"
        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (clicknumeros == true)
            {
                operador = Operacion.Multiplicacion;
                ObtenerValor("x");
            }
            else
            {
                return;
            }
        }

        //convierte al operador en "/"
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (clicknumeros == true)
            {
                operador = Operacion.Division;
                ObtenerValor("/");
            }
            else
            {
                return;
            }
        }

        //Borra todo el contenido del textbox y el historial
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (clicknumeros == true)
            {
                textBox1.Text = "0";
                lblHistorial.Text = "";
            }
            else
            {
                return;
            }
        }

        //Boton para cerrar la aplicacion en Barra Superior
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu f3 = new Menu();
            //f3.Menu_Load(this, e);
            //f3.Show();

            Menu form3 = new Menu ();
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

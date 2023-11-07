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
    public partial class Calculadora : Form
    {
        //variables de diseño
        public int borderRadius = 20;
        public int borderSize = 2;
        public Color borderColor = Color.Indigo;

        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        public int contadormodo = 0;
        public Calculadora()
        {
            InitializeComponent();
            //Estructurar el formulario quitando el borde superior original
            this.FormBorderStyle = FormBorderStyle.None;
            //Agregar un padding que suplemente al padding original
            this.Padding = new Padding(borderSize);
            //dar color en comun al nuevo panel y al formulario original
            this.PanelBarraTitulo.BackColor = borderColor;
            this.BackColor = borderColor;
            this.PanelContenedor.BackColor = Color.Lavender;

            this.ActiveControl = PanelContenedor;
        }

        //Funcion de modo oscuro
        public void Calculadora_Load(object sender, EventArgs e)
        {
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                borderColor = Color.Indigo;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.White;
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
                textBox1.BackColor = Color.White;
                lblHistorial.BackColor = Color.White;
            }
            else
            {
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                borderColor = Color.Black;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.FromArgb(25, 25, 25);
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.LightGray;
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
                textBox1.BackColor = Color.LightGray;
                lblHistorial.BackColor = Color.LightGray;

            }
        }


        private void btnModo_Click(object sender, EventArgs e)
        {
            contadormodo++;
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                borderColor = Color.Indigo;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.White;
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
                textBox1.BackColor = Color.White;
                lblHistorial.BackColor = Color.White;
            }
            else
            {
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                borderColor = Color.Black;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.FromArgb(25, 25, 25);
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.LightGray;
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
                textBox1.BackColor = Color.LightGray;
                lblHistorial.BackColor = Color.LightGray;

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
            LeerNumero("1");
        }

        //Agrega el numero dos al textbox
        private void button2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        //Agrega el numero tres al textbox
        private void button3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        //Agrega el numero cuatro al textbox
        private void button4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        //Agrega el numero cinco al textbox
        private void button5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        //Agrega el numero seis al textbox
        private void button6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        //Agrega el numero siete al textbox
        private void button7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        //Agrega el numero ocho al textbox
        private void button8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        //Agrega el numero nueve al textbox
        private void button9_Click(object sender, EventArgs e)
        {
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
            operador = Operacion.Suma;
            ObtenerValor("+");

        }

        //Obtiene el resultado de la operacion, vuelve los dos valores a cero y escribe el resultado en el textbox
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

        //convierte al operador en "-"
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        //convierte al operador en "x"
        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        //convierte al operador en "/"
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        //Borra todo el contenido del textbox y el historial
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblHistorial.Text = "";
        }


        //Metodos para poder mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }


        //Metodos privados
        //Metodo que da curvatura al contorno de los rectangulos
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        //

        //Metodo que dibuja los bordes del formulario utilizando funciones como Graphics, Pen y Matrix
        private void RegionFormYBordes(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        //

        //Metodo que dibuja los bordes de los controles utilizando funciones como Graphics, Pen y Matrix
        private void RegionControlesYBordes(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        //

        //Metodo que da forma al contorno de dibujo que luego es llamado para dibujar cada esquina del borde 
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {

            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        //Declara variables de color para las esquinas de borde
        private struct FormBoundsColors
        {
            public Color ColorArribaIzquierda;
            public Color ColorArribaDerecha;
            public Color ColorAbajoIzquierda;
            public Color ColorAbajoDerecha;
        }
        //

        //Dibuja los colores de las esquinas de bordes usando las variables de color respectivas
        private FormBoundsColors ObtenerColorEsquinas()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Arriba a la izquierda
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                //graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.ColorArribaIzquierda = bmp.GetPixel(0, 0);
                //Arriba a la derecha
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                //graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.ColorArribaDerecha = bmp.GetPixel(0, 0);
                //Abajo a la izquierda
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                //graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.ColorAbajoIzquierda = bmp.GetPixel(0, 0);
                //Abajo a la derecha
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                //graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.ColorAbajoDerecha = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        //
        //

        //Metodos de evento
        //Metodo que pinta el fondo del control
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            //Suaviza los bordes externos
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var colorContorno = ObtenerColorEsquinas();

            //Arriba izquierda
            DrawPath(rectForm, e.Graphics, colorContorno.ColorArribaIzquierda);

            //Arriba derecha
            Rectangle rectArribaDerecha = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectArribaDerecha, e.Graphics, colorContorno.ColorArribaDerecha);

            //Abajo Izquierda
            Rectangle rectAbajoIzquierda = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectAbajoIzquierda, e.Graphics, colorContorno.ColorAbajoIzquierda);

            //Abajo Derecha
            Rectangle rectAbajoDerecha = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectAbajoDerecha, e.Graphics, colorContorno.ColorAbajoDerecha);
        }
        //

        //Dibuja las formas y bordes en el formulario llamando al metodo RegionFormYBordes
        private void Calculadora_Paint(object sender, PaintEventArgs e)
        {
            RegionFormYBordes(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        //Dibuja las formas y bordes en los controles llamando al metodo RegionControlesYBordes
        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {
            RegionControlesYBordes(PanelContenedor, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        //Metodos que redibujan el formulario cuando este se carga o se vuelve a activar
        private void Calculadora_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Calculadora_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Calculadora_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //


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
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }



}

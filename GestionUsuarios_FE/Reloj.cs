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
    public partial class Reloj : Form
    {
        //variables de diseño
        public int borderRadius = 20;
        public int borderSize = 2;
        public Color borderColor = Color.Indigo;



        private Timer ti;
        public int contadormodo = 0;



        public Reloj()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
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

        public void Reloj_Load(object sender, EventArgs e)
        {
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro";
                borderColor = Color.Indigo;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

            }
            else
            {
                btnModo.Text = "Modo Oscuro";
                borderColor = Color.Black;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.FromArgb(25, 25, 25);
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.LightGray;
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
                btnModo.Text = "Modo Claro";
                borderColor = Color.Indigo;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

            }
            else
            {
                btnModo.Text = "Modo Oscuro";
                borderColor = Color.Black;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.FromArgb(25, 25, 25);
                PanelBarraTitulo.BackColor = borderColor;
                btnModo.BackColor = Color.LightGray;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

            }
        }


        //Metodos para poder mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Reloj_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
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
        private void Reloj_Paint(object sender, PaintEventArgs e)
        {
            RegionFormYBordes(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        //Dibuja las formas y bordes en los controles llamando al metodo RegionControlesYBordes
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            RegionControlesYBordes(PanelContenedor, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        //Metodos que redibujan el formulario cuando este se carga o se vuelve a activar
        private void Reloj_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Reloj_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Reloj_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //


        //Boton para cerrar la aplicacion en Barra Superior
        private void btnCerrar_Click_1(object sender, EventArgs e)
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


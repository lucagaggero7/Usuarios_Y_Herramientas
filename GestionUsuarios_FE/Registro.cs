using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios_BE;
using GestionUsuarios_FE;


namespace GestionUsuarios_FE
{
    public partial class Registro : Form
    {
        //variables de diseño
        public int borderRadius = 20;
        public int borderSize = 2;
        public Color borderColor = Color.Indigo;


        Usuario myUsuario = new Usuario();

        public int contadormodo = 0;
        int Valorverif;
        decimal Verificacion;
        public Usuarios ListaUsuarios { get; set; } = new Usuarios();

        //variables que cuentan los clicks de los textbox 
        int nombreclick = 0;
        int apellidoclick = 0;
        int nombredeusuarioclick = 0;
        int correoclick = 0;
        int contraseñaclick = 0;


        public Registro()
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
            //mostrar valores de la datatable de usuarios en el datagrid
            //
            datagrid.DataSource = ListaUsuarios.ListaDT;
            datagrid.Visible = false;
            //mostrar o ocultar datagrid solo para pruebas de desarrollador
            //en caso de ser usado, descomentar el siguiente codigo
            //datagrid.Visible = true;
        }

        //FUNCION MODO OSCURO
        private void Registro_Load(object sender, EventArgs e)
        {
            //Login f1 = Owner as Login;
            //contadormodo = f1.contadormodo;

            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro";
                borderColor = Color.Indigo;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = borderColor;
                btnCrear.BackColor = Color.White;
                btnModo.BackColor = Color.White;
                btnIniciarSesion.BackColor = Color.White;
                txtNombre.BackColor = Color.White;
                txtApellido.BackColor = Color.White;
                txtNombredeusuario.BackColor = Color.White;
                txtCorreo.BackColor = Color.White;
                txtContraseña.BackColor = Color.White;
                txtVerificacion.BackColor = Color.White;
                labelVerificacion.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.Black;
                txtApellido.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtVerificacion.ForeColor = Color.Black;
            }
            else
            {
                btnModo.Text = "Modo Oscuro";
                borderColor = Color.Black;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.FromArgb(25, 25, 25);
                PanelBarraTitulo.BackColor = borderColor;
                btnCrear.BackColor = Color.LightGray;
                btnModo.BackColor = Color.LightGray;
                btnIniciarSesion.BackColor = Color.LightGray;
                txtNombre.BackColor = Color.LightGray;
                txtApellido.BackColor = Color.LightGray;
                txtNombredeusuario.BackColor = Color.LightGray;
                txtCorreo.BackColor = Color.LightGray;
                txtContraseña.BackColor = Color.LightGray;
                txtVerificacion.BackColor = Color.LightGray;
                labelVerificacion.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.Black;
                txtApellido.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtVerificacion.ForeColor = Color.Black;
            }
        }

        //FUNCION MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            contadormodo++;
            //Login f1 = Owner as Login;
            //f1.contadormodo = contadormodo;
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro";
                borderColor = Color.Indigo;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.Lavender;
                PanelBarraTitulo.BackColor = borderColor;
                btnCrear.BackColor = Color.White;
                btnModo.BackColor = Color.White;
                btnIniciarSesion.BackColor = Color.White;
                txtNombre.BackColor = Color.White;
                txtApellido.BackColor = Color.White;
                txtNombredeusuario.BackColor = Color.White;
                txtCorreo.BackColor = Color.White;
                txtContraseña.BackColor = Color.White;
                txtVerificacion.BackColor = Color.White;
                labelVerificacion.ForeColor = Color.Black;
                btnModo.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.Black;
                txtApellido.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtVerificacion.ForeColor = Color.Black;
            }
            else
            {
                btnModo.Text = "Modo Oscuro";
                borderColor = Color.Black;
                this.BackColor = borderColor;
                PanelContenedor.BackColor = Color.FromArgb(25, 25, 25);
                PanelBarraTitulo.BackColor = borderColor;
                btnCrear.BackColor = Color.LightGray;
                btnModo.BackColor = Color.LightGray;
                btnIniciarSesion.BackColor = Color.LightGray;
                txtNombre.BackColor = Color.LightGray;
                txtApellido.BackColor = Color.LightGray;
                txtNombredeusuario.BackColor = Color.LightGray;
                txtCorreo.BackColor = Color.LightGray;
                txtContraseña.BackColor = Color.LightGray;
                txtVerificacion.BackColor = Color.LightGray;
                labelVerificacion.ForeColor = Color.White;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.Black;
                txtApellido.ForeColor = Color.Black;
                txtNombredeusuario.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtVerificacion.ForeColor = Color.Black;
            }
        }


        // Crear usuario nuevo verificando que todos los campos esten completos y que la verificacion cumpla con las condiciones
        // y el nombre de usuario ingresado no exista aun
        private void btnCrear_Click(object sender, EventArgs e)
        {



            if (txtNombre.Text != "" && txtNombre.Text != "Nombre" )
            {
                //borro el error 
                errorNombre.SetError(txtNombre, "");
            }
            else
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text != "" && txtApellido.Text != "Apellido")
            {
                //borro el error 
                errorApellido.SetError(txtApellido, "");
            }
            else
            {
                errorApellido.SetError(txtApellido, "Debe ingresar un apellido");
                txtApellido.Focus();
                return;

            }

            if (txtNombredeusuario.Text != "" && txtNombredeusuario.Text != "Nombre de usuario")
            {
                //borro el error 
                errorNombredeusuario.SetError(txtNombredeusuario, "");
            }
            else
            {
                errorNombredeusuario.SetError(txtNombredeusuario, "Debe ingresar un nombre de usuario");
                txtNombredeusuario.Focus();
                return;
            }

            if (txtCorreo.Text != "" && txtCorreo.Text != "Correo")
            {
                //borro el error 
                errorCorreo.SetError(txtCorreo, "");
            }
            else
            {
                errorCorreo.SetError(txtCorreo, "Debe ingresar un correo electronico");
                txtCorreo.Focus();
                return;
            }

            if (txtContraseña.Text != "" && txtContraseña.Text != "Contraseña")
            {
                //borro el error 
                errorContraseña.SetError(txtContraseña, "");
            }
            else
            {
                errorContraseña.SetError(txtContraseña, "Debe ingresar una contraseña");
                txtContraseña.Focus();
                return;
            }

            if (!(txtVerificacion.Text == ""))
            {
                //borro el error 
                errorVerificacion.SetError(txtVerificacion, "");
            }
            else
            {
                errorVerificacion.SetError(txtVerificacion, "Debe ingresar una verificacion");
                txtVerificacion.Focus();
                return;
            }

            do
            {
                if (Decimal.TryParse(txtVerificacion.Text, out Verificacion))

                {
                    //borro el error 
                    errorVerificacion.SetError(txtVerificacion, "");
                    Valorverif = int.Parse(txtVerificacion.Text);
                }
                else
                {
                    errorVerificacion.SetError(txtVerificacion, "Ingrese un dato numerico");
                    return;
                }


                if (Valorverif >= 10 && Valorverif <= 15)

                {
                    //borro el error 
                    errorVerificacion.SetError(txtVerificacion, "");

                }
                else
                {
                    errorVerificacion.SetError(txtVerificacion, "Ingrese un numero entre 10 y 15");
                    return;
                }



            } while (Valorverif < 10 || Valorverif > 15);


            bool existe;

            Usuario usuario = new Usuario();
            usuario.Nombredeusuario = txtNombredeusuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            Usuarios usuarios = new Usuarios();

            //llamamos al metodo que verifica si ya existe el nombre de usuario en la lista de usuarios
            existe = usuarios.ExisteNombredeusuario(ListaUsuarios, usuario);

            //verificamos que el nombre de usuario ingresado aun no exista para poder registrar un nuevo usuario
            if (existe == false)
            {

                Usuario user = new Usuario();
                user.Agregar(txtNombre.Text,
                            txtApellido.Text,
                            txtNombredeusuario.Text,
                            txtCorreo.Text,
                            txtContraseña.Text);

                ListaUsuarios.InsertUsuario(user);

                MessageBox.Show("Usuario Registrado");

                Login form1 = new Login();
                form1.contadormodo = contadormodo;
                form1.Login_Load(this, null);
                form1.Show();
                this.Close();


                //este codigo se utiliza para actualizar la lista de usuarios
                //del formulario padre (login) cuando se registra un usuario 
                //en el formulario de registro (hijo)
                form1.ListaUsuarios.ListaDT = ListaUsuarios.ListaDT;


                //este codigo se utiliza para actualizar el datagrid view
                // del login cuando se registra un nuevo usuario sin tener que reiniciar el programa
                //(solo usado para pruebas de desarrollador)
                //en caso de ser usado, descomentar el siguiente codigo

                //f1.datagrid.DataSource = ListaUsuarios.ListaDT;

            }
            else
            {
                MessageBox.Show("Ya existe ese nombre de usuario");
                return;
            }

        }

        //Metodos para poder mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Registro_MouseDown(object sender, MouseEventArgs e)
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
        private void Registro_Paint(object sender, PaintEventArgs e)
        {
            RegionFormYBordes(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        //Dibuja las formas y bordes en los controles llamando al metodo RegionControlesYBordes
        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {
            RegionControlesYBordes(PanelContenedor, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        //Metodos que anulan la posibilidad de cambiar el tamaño del formulario
        private void Registro_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Registro_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Registro_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //

        //Boton para cerrar la aplicacion en Barra Superior
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {

            Login form1 = new Login();
            form1.contadormodo = contadormodo;
            form1.Login_Load(this, null);
            form1.Show();
            this.Close();

        }

        //Boton para minimizar la aplicacion en Barra Superior
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;

            if (nombreclick == 1)
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_DoubleClick(object sender, EventArgs e)
        {
            nombreclick++;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombreclick++;
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {

            apellidoclick++;
            if (apellidoclick == 1)
            {
                txtApellido.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtApellido_DoubleClick(object sender, EventArgs e)
        {
            apellidoclick++;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            apellidoclick++;
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

        private void txtNombredeusuario_DoubleClick(object sender, EventArgs e)
        {
            nombredeusuarioclick++;
        }

        private void txtNombredeusuario_TextChanged(object sender, EventArgs e)
        {
            nombredeusuarioclick++;

        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            correoclick++;
            if (correoclick == 1)
            {
                txtCorreo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCorreo_DoubleClick(object sender, EventArgs e)
        {
            correoclick++;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            correoclick++;
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            contraseñaclick++;
            if (contraseñaclick == 1)
            {
                txtContraseña.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtContraseña_DoubleClick(object sender, EventArgs e)
        {
            contraseñaclick++;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contraseñaclick++;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.contadormodo = contadormodo;
            form1.Login_Load(this, null);
            form1.Show();
            this.Close();

        }
        //
        //

    }
}

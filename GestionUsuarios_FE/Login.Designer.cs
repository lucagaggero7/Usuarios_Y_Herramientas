using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GestionUsuarios_FE
{
    public partial class Login
    {
 
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModo = new System.Windows.Forms.Button();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.labelRegistrate = new System.Windows.Forms.Label();
            this.txtNombredeusuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.PanelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.White;
            this.btnModo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModo.Location = new System.Drawing.Point(23, 65);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(110, 33);
            this.btnModo.TabIndex = 32;
            this.btnModo.Text = "Modo Claro";
            this.btnModo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(184, 117);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBienvenido.Size = new System.Drawing.Size(165, 25);
            this.labelBienvenido.TabIndex = 33;
            this.labelBienvenido.Text = "BIENVENIDO";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(189, 249);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(156, 37);
            this.btnIniciarSesion.TabIndex = 34;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrate.Location = new System.Drawing.Point(189, 389);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(156, 36);
            this.btnRegistrate.TabIndex = 36;
            this.btnRegistrate.Text = "CREAR CUENTA ";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // labelRegistrate
            // 
            this.labelRegistrate.AutoSize = true;
            this.labelRegistrate.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelRegistrate.Location = new System.Drawing.Point(185, 370);
            this.labelRegistrate.Name = "labelRegistrate";
            this.labelRegistrate.Size = new System.Drawing.Size(163, 16);
            this.labelRegistrate.TabIndex = 38;
            this.labelRegistrate.Text = "¿No tienes una cuenta?";
            // 
            // txtNombredeusuario
            // 
            this.txtNombredeusuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredeusuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombredeusuario.Location = new System.Drawing.Point(188, 171);
            this.txtNombredeusuario.Name = "txtNombredeusuario";
            this.txtNombredeusuario.Size = new System.Drawing.Size(157, 21);
            this.txtNombredeusuario.TabIndex = 39;
            this.txtNombredeusuario.Text = "Nombre de usuario";
            this.txtNombredeusuario.Click += new System.EventHandler(this.txtNombredeusuario_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContraseña.Location = new System.Drawing.Point(188, 207);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 21);
            this.txtContraseña.TabIndex = 40;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.DoubleClick += new System.EventHandler(this.txtContraseña_DoubleClick);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(433, 136);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(240, 150);
            this.datagrid.TabIndex = 41;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Lavender;
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Controls.Add(this.PanelBarraTitulo);
            this.PanelContenedor.Controls.Add(this.btnIniciarSesion);
            this.PanelContenedor.Controls.Add(this.labelRegistrate);
            this.PanelContenedor.Controls.Add(this.datagrid);
            this.PanelContenedor.Controls.Add(this.btnRegistrate);
            this.PanelContenedor.Controls.Add(this.btnModo);
            this.PanelContenedor.Controls.Add(this.txtContraseña);
            this.PanelContenedor.Controls.Add(this.labelBienvenido);
            this.PanelContenedor.Controls.Add(this.txtNombredeusuario);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(549, 472);
            this.PanelContenedor.TabIndex = 42;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.Indigo;
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(549, 50);
            this.PanelBarraTitulo.TabIndex = 0;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(449, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(499, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(549, 472);
            this.Controls.Add(this.PanelContenedor);
            this.Name = "Login";
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResizeEnd += new System.EventHandler(this.Login_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.Label labelRegistrate;
        public System.Windows.Forms.TextBox txtNombredeusuario;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.DataGridView datagrid;
        private Panel PanelContenedor;
        private Panel PanelBarraTitulo;
        private Button btnMinimizar;
        private Button btnCerrar;
        public Label label1;
    }

}
namespace GestionUsuarios_FE
{
    partial class Login
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
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.White;
            this.btnModo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModo.Location = new System.Drawing.Point(27, 24);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(132, 33);
            this.btnModo.TabIndex = 32;
            this.btnModo.Text = "Modo Claro Activado";
            this.btnModo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(317, 88);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(180, 30);
            this.labelBienvenido.TabIndex = 33;
            this.labelBienvenido.Text = "BIENVENIDO";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(322, 228);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(160, 37);
            this.btnIniciarSesion.TabIndex = 34;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrate.Location = new System.Drawing.Point(322, 369);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(160, 36);
            this.btnRegistrate.TabIndex = 36;
            this.btnRegistrate.Text = "REGISTRATE";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // labelRegistrate
            // 
            this.labelRegistrate.AutoSize = true;
            this.labelRegistrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrate.Location = new System.Drawing.Point(322, 349);
            this.labelRegistrate.Name = "labelRegistrate";
            this.labelRegistrate.Size = new System.Drawing.Size(159, 17);
            this.labelRegistrate.TabIndex = 38;
            this.labelRegistrate.Text = "¿No tienes una cuenta?";
            // 
            // txtNombredeusuario
            // 
            this.txtNombredeusuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombredeusuario.Location = new System.Drawing.Point(325, 153);
            this.txtNombredeusuario.Name = "txtNombredeusuario";
            this.txtNombredeusuario.Size = new System.Drawing.Size(157, 20);
            this.txtNombredeusuario.TabIndex = 39;
            this.txtNombredeusuario.Text = "Nombre de usuario";
            this.txtNombredeusuario.Click += new System.EventHandler(this.txtNombredeusuario_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContraseña.Location = new System.Drawing.Point(325, 188);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(157, 20);
            this.txtContraseña.TabIndex = 40;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.DoubleClick += new System.EventHandler(this.txtContraseña_DoubleClick);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(548, 58);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(240, 150);
            this.datagrid.TabIndex = 41;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombredeusuario);
            this.Controls.Add(this.labelRegistrate);
            this.Controls.Add(this.btnRegistrate);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.btnModo);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
using System.Drawing;

namespace GestionUsuarios_FE
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnReloj = new System.Windows.Forms.Button();
            this.btnTemporizador = new System.Windows.Forms.Button();
            this.btnAlarma = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.labelMenuinicio = new System.Windows.Forms.Label();
            this.btnModo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.PanelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReloj
            // 
            this.btnReloj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloj.Location = new System.Drawing.Point(43, 163);
            this.btnReloj.Name = "btnReloj";
            this.btnReloj.Size = new System.Drawing.Size(134, 55);
            this.btnReloj.TabIndex = 0;
            this.btnReloj.Text = "RELOJ";
            this.btnReloj.UseVisualStyleBackColor = true;
            this.btnReloj.Click += new System.EventHandler(this.btnReloj_Click);
            // 
            // btnTemporizador
            // 
            this.btnTemporizador.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemporizador.Location = new System.Drawing.Point(223, 163);
            this.btnTemporizador.Name = "btnTemporizador";
            this.btnTemporizador.Size = new System.Drawing.Size(154, 55);
            this.btnTemporizador.TabIndex = 1;
            this.btnTemporizador.Text = "TEMPORIZADOR";
            this.btnTemporizador.UseVisualStyleBackColor = true;
            this.btnTemporizador.Click += new System.EventHandler(this.btnTemporizador_Click);
            // 
            // btnAlarma
            // 
            this.btnAlarma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarma.Location = new System.Drawing.Point(418, 163);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.Size = new System.Drawing.Size(134, 55);
            this.btnAlarma.TabIndex = 2;
            this.btnAlarma.Text = "ALARMA";
            this.btnAlarma.UseVisualStyleBackColor = true;
            this.btnAlarma.Click += new System.EventHandler(this.btnAlarma_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Location = new System.Drawing.Point(599, 163);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(146, 55);
            this.btnCalculadora.TabIndex = 3;
            this.btnCalculadora.Text = "CALCULADORA";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // labelMenuinicio
            // 
            this.labelMenuinicio.AutoSize = true;
            this.labelMenuinicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuinicio.Location = new System.Drawing.Point(39, 120);
            this.labelMenuinicio.Name = "labelMenuinicio";
            this.labelMenuinicio.Size = new System.Drawing.Size(0, 16);
            this.labelMenuinicio.TabIndex = 4;
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.White;
            this.btnModo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModo.Location = new System.Drawing.Point(23, 56);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(110, 33);
            this.btnModo.TabIndex = 32;
            this.btnModo.Text = "Modo Claro";
            this.btnModo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(445, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(630, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Lavender;
            this.PanelContenedor.Controls.Add(this.PanelBarraTitulo);
            this.PanelContenedor.Controls.Add(this.btnModo);
            this.PanelContenedor.Controls.Add(this.labelMenuinicio);
            this.PanelContenedor.Controls.Add(this.pictureBox4);
            this.PanelContenedor.Controls.Add(this.btnReloj);
            this.PanelContenedor.Controls.Add(this.pictureBox3);
            this.PanelContenedor.Controls.Add(this.btnTemporizador);
            this.PanelContenedor.Controls.Add(this.pictureBox2);
            this.PanelContenedor.Controls.Add(this.btnAlarma);
            this.PanelContenedor.Controls.Add(this.pictureBox1);
            this.PanelContenedor.Controls.Add(this.btnCalculadora);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(801, 350);
            this.PanelContenedor.TabIndex = 37;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint_1);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.Indigo;
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(801, 50);
            this.PanelBarraTitulo.TabIndex = 37;
            this.PanelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarraTitulo_Paint);
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(701, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
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
            this.btnCerrar.Location = new System.Drawing.Point(751, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(801, 350);
            this.Controls.Add(this.PanelContenedor);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResizeEnd += new System.EventHandler(this.Menu_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Menu_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReloj;
        private System.Windows.Forms.Button btnTemporizador;
        private System.Windows.Forms.Button btnAlarma;
        private System.Windows.Forms.Button btnCalculadora;
        public System.Windows.Forms.Label labelMenuinicio;
        public System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
﻿using System;
using System.Drawing;

namespace GestionUsuarios_FE
{
    partial class Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombredeusuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombredeusuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtVerificacion = new System.Windows.Forms.TextBox();
            this.labelVerificacion = new System.Windows.Forms.Label();
            this.errorVerificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnModo = new System.Windows.Forms.Button();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombredeusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.PanelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(184, 83);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(206, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "CREAR USUARIO";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(176, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.DoubleClick += new System.EventHandler(this.txtNombre_DoubleClick);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(176, 175);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(218, 23);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.Click += new System.EventHandler(this.txtApellido_Click);
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.DoubleClick += new System.EventHandler(this.txtApellido_DoubleClick);
            // 
            // txtNombredeusuario
            // 
            this.txtNombredeusuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredeusuario.Location = new System.Drawing.Point(176, 224);
            this.txtNombredeusuario.Name = "txtNombredeusuario";
            this.txtNombredeusuario.Size = new System.Drawing.Size(218, 23);
            this.txtNombredeusuario.TabIndex = 2;
            this.txtNombredeusuario.Text = "Nombre de usuario";
            this.txtNombredeusuario.Click += new System.EventHandler(this.txtNombredeusuario_Click);
            this.txtNombredeusuario.TextChanged += new System.EventHandler(this.txtNombredeusuario_TextChanged);
            this.txtNombredeusuario.DoubleClick += new System.EventHandler(this.txtNombredeusuario_DoubleClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(176, 275);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(218, 23);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Click += new System.EventHandler(this.txtCorreo_Click);
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            this.txtCorreo.DoubleClick += new System.EventHandler(this.txtCorreo_DoubleClick);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(176, 326);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(218, 23);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.DoubleClick += new System.EventHandler(this.txtContraseña_DoubleClick);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(176, 448);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(111, 36);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "REGISTRATE";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorNombredeusuario
            // 
            this.errorNombredeusuario.ContainerControl = this;
            // 
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            // 
            // txtVerificacion
            // 
            this.txtVerificacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificacion.Location = new System.Drawing.Point(176, 398);
            this.txtVerificacion.Name = "txtVerificacion";
            this.txtVerificacion.Size = new System.Drawing.Size(46, 23);
            this.txtVerificacion.TabIndex = 5;
            // 
            // labelVerificacion
            // 
            this.labelVerificacion.AutoSize = true;
            this.labelVerificacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerificacion.Location = new System.Drawing.Point(173, 376);
            this.labelVerificacion.Name = "labelVerificacion";
            this.labelVerificacion.Size = new System.Drawing.Size(247, 16);
            this.labelVerificacion.TabIndex = 14;
            this.labelVerificacion.Text = "Introduzca un numero entre 10 y 15";
            // 
            // errorVerificacion
            // 
            this.errorVerificacion.ContainerControl = this;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(482, 83);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(240, 150);
            this.datagrid.TabIndex = 32;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Lavender;
            this.PanelContenedor.Controls.Add(this.btnModo);
            this.PanelContenedor.Controls.Add(this.PanelBarraTitulo);
            this.PanelContenedor.Controls.Add(this.datagrid);
            this.PanelContenedor.Controls.Add(this.labelTitulo);
            this.PanelContenedor.Controls.Add(this.labelVerificacion);
            this.PanelContenedor.Controls.Add(this.txtVerificacion);
            this.PanelContenedor.Controls.Add(this.btnCrear);
            this.PanelContenedor.Controls.Add(this.txtContraseña);
            this.PanelContenedor.Controls.Add(this.txtCorreo);
            this.PanelContenedor.Controls.Add(this.txtNombre);
            this.PanelContenedor.Controls.Add(this.txtNombredeusuario);
            this.PanelContenedor.Controls.Add(this.txtApellido);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(815, 510);
            this.PanelContenedor.TabIndex = 33;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint_1);
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.White;
            this.btnModo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModo.Location = new System.Drawing.Point(12, 56);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(110, 33);
            this.btnModo.TabIndex = 34;
            this.btnModo.Text = "Modo Claro";
            this.btnModo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.Indigo;
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(815, 50);
            this.PanelBarraTitulo.TabIndex = 33;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(715, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(765, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(815, 510);
            this.Controls.Add(this.PanelContenedor);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Activated += new System.EventHandler(this.Registro_Activated);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResizeEnd += new System.EventHandler(this.Registro_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Registro_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Registro_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombredeusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombredeusuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorNombredeusuario;
        private System.Windows.Forms.ErrorProvider errorCorreo;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.Label labelVerificacion;
        private System.Windows.Forms.TextBox txtVerificacion;
        private System.Windows.Forms.ErrorProvider errorVerificacion;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModo;
    }
}


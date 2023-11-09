using System.Drawing;

namespace GestionUsuarios_FE
{
    partial class Calculadora
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMas = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.btnModo = new System.Windows.Forms.Button();
            this.PanelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.Location = new System.Drawing.Point(435, 0);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(393, 0);
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.Size = new System.Drawing.Size(477, 34);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Location = new System.Drawing.Point(154, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 32);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(115, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(178, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(242, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(115, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 42);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(178, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 42);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Location = new System.Drawing.Point(242, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 42);
            this.button6.TabIndex = 18;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lavender;
            this.button7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Location = new System.Drawing.Point(115, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 42);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lavender;
            this.button8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Location = new System.Drawing.Point(178, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 42);
            this.button8.TabIndex = 20;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lavender;
            this.button9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.Location = new System.Drawing.Point(242, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 42);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Lavender;
            this.button0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button0.Location = new System.Drawing.Point(115, 382);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(48, 42);
            this.button0.TabIndex = 22;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonMas
            // 
            this.buttonMas.BackColor = System.Drawing.Color.Lavender;
            this.buttonMas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMas.Location = new System.Drawing.Point(306, 274);
            this.buttonMas.Name = "buttonMas";
            this.buttonMas.Size = new System.Drawing.Size(48, 42);
            this.buttonMas.TabIndex = 23;
            this.buttonMas.Text = "+";
            this.buttonMas.UseVisualStyleBackColor = false;
            this.buttonMas.Click += new System.EventHandler(this.buttonMas_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.Lavender;
            this.buttonIgual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonIgual.Location = new System.Drawing.Point(178, 382);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(48, 42);
            this.buttonIgual.TabIndex = 24;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.White;
            this.lblHistorial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHistorial.Location = new System.Drawing.Point(30, 469);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 18);
            this.lblHistorial.TabIndex = 25;
            // 
            // buttonMenos
            // 
            this.buttonMenos.BackColor = System.Drawing.Color.Lavender;
            this.buttonMenos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenos.Location = new System.Drawing.Point(306, 219);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(48, 42);
            this.buttonMenos.TabIndex = 26;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = false;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.BackColor = System.Drawing.Color.Lavender;
            this.buttonMultiplicacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicacion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMultiplicacion.Location = new System.Drawing.Point(306, 328);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(48, 42);
            this.buttonMultiplicacion.TabIndex = 27;
            this.buttonMultiplicacion.Text = "x";
            this.buttonMultiplicacion.UseVisualStyleBackColor = false;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.BackColor = System.Drawing.Color.Lavender;
            this.buttonDividir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDividir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonDividir.Location = new System.Drawing.Point(306, 382);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(48, 42);
            this.buttonDividir.TabIndex = 28;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = false;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.Lavender;
            this.buttonBorrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonBorrar.Location = new System.Drawing.Point(242, 382);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(48, 42);
            this.buttonBorrar.TabIndex = 29;
            this.buttonBorrar.Text = "C";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.Lavender;
            this.btnModo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnModo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnModo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo.ForeColor = System.Drawing.Color.Black;
            this.btnModo.Location = new System.Drawing.Point(12, 56);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(127, 38);
            this.btnModo.TabIndex = 34;
            this.btnModo.Text = "Modo Claro\r\nActivado\r\n";
            this.btnModo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(477, 516);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonMenos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonMas);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.button9, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.Controls.SetChildIndex(this.button0, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.buttonMas, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.buttonIgual, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.lblHistorial, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.buttonMenos, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.buttonMultiplicacion, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.buttonDividir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.buttonBorrar, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.btnModo, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMas;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button btnModo;
    }
}
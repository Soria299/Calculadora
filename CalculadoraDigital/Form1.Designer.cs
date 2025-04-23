namespace CalculadoraDigital
{
    partial class Form1
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
            this.bttnBorrar = new System.Windows.Forms.Button();
            this.bttnResultado = new System.Windows.Forms.Button();
            this.bttnDivision = new System.Windows.Forms.Button();
            this.bttnMultiplicacion = new System.Windows.Forms.Button();
            this.bttnRestar = new System.Windows.Forms.Button();
            this.bttnSuma = new System.Windows.Forms.Button();
            this.bttn9 = new System.Windows.Forms.Button();
            this.bttn6 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.bttn8 = new System.Windows.Forms.Button();
            this.bttn5 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn0 = new System.Windows.Forms.Button();
            this.bttn7 = new System.Windows.Forms.Button();
            this.bttn4 = new System.Windows.Forms.Button();
            this.bttn1 = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnBorrar
            // 
            this.bttnBorrar.Location = new System.Drawing.Point(165, 165);
            this.bttnBorrar.Name = "bttnBorrar";
            this.bttnBorrar.Size = new System.Drawing.Size(50, 23);
            this.bttnBorrar.TabIndex = 57;
            this.bttnBorrar.Text = "C";
            this.bttnBorrar.UseVisualStyleBackColor = true;
            this.bttnBorrar.Click += new System.EventHandler(this.bttnBorrar_Click);
            // 
            // bttnResultado
            // 
            this.bttnResultado.Location = new System.Drawing.Point(109, 165);
            this.bttnResultado.Name = "bttnResultado";
            this.bttnResultado.Size = new System.Drawing.Size(50, 23);
            this.bttnResultado.TabIndex = 56;
            this.bttnResultado.Text = "=";
            this.bttnResultado.UseVisualStyleBackColor = true;
            this.bttnResultado.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // bttnDivision
            // 
            this.bttnDivision.Location = new System.Drawing.Point(221, 165);
            this.bttnDivision.Name = "bttnDivision";
            this.bttnDivision.Size = new System.Drawing.Size(50, 23);
            this.bttnDivision.TabIndex = 55;
            this.bttnDivision.Text = "/";
            this.bttnDivision.UseVisualStyleBackColor = true;
            this.bttnDivision.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // bttnMultiplicacion
            // 
            this.bttnMultiplicacion.Location = new System.Drawing.Point(221, 136);
            this.bttnMultiplicacion.Name = "bttnMultiplicacion";
            this.bttnMultiplicacion.Size = new System.Drawing.Size(50, 23);
            this.bttnMultiplicacion.TabIndex = 54;
            this.bttnMultiplicacion.Text = "x";
            this.bttnMultiplicacion.UseVisualStyleBackColor = true;
            this.bttnMultiplicacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // bttnRestar
            // 
            this.bttnRestar.Location = new System.Drawing.Point(221, 107);
            this.bttnRestar.Name = "bttnRestar";
            this.bttnRestar.Size = new System.Drawing.Size(50, 23);
            this.bttnRestar.TabIndex = 53;
            this.bttnRestar.Text = "-";
            this.bttnRestar.UseVisualStyleBackColor = true;
            this.bttnRestar.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // bttnSuma
            // 
            this.bttnSuma.Location = new System.Drawing.Point(221, 78);
            this.bttnSuma.Name = "bttnSuma";
            this.bttnSuma.Size = new System.Drawing.Size(50, 23);
            this.bttnSuma.TabIndex = 52;
            this.bttnSuma.Text = "+";
            this.bttnSuma.UseVisualStyleBackColor = true;
            this.bttnSuma.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // bttn9
            // 
            this.bttn9.Location = new System.Drawing.Point(165, 136);
            this.bttn9.Name = "bttn9";
            this.bttn9.Size = new System.Drawing.Size(50, 23);
            this.bttn9.TabIndex = 51;
            this.bttn9.Text = "9";
            this.bttn9.UseVisualStyleBackColor = true;
            this.bttn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn6
            // 
            this.bttn6.Location = new System.Drawing.Point(165, 107);
            this.bttn6.Name = "bttn6";
            this.bttn6.Size = new System.Drawing.Size(50, 23);
            this.bttn6.TabIndex = 50;
            this.bttn6.Text = "6";
            this.bttn6.UseVisualStyleBackColor = true;
            this.bttn6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn3
            // 
            this.bttn3.Location = new System.Drawing.Point(165, 78);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(50, 23);
            this.bttn3.TabIndex = 49;
            this.bttn3.Text = "3";
            this.bttn3.UseVisualStyleBackColor = true;
            this.bttn3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn8
            // 
            this.bttn8.Location = new System.Drawing.Point(109, 136);
            this.bttn8.Name = "bttn8";
            this.bttn8.Size = new System.Drawing.Size(50, 23);
            this.bttn8.TabIndex = 48;
            this.bttn8.Text = "8";
            this.bttn8.UseVisualStyleBackColor = true;
            this.bttn8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn5
            // 
            this.bttn5.Location = new System.Drawing.Point(109, 107);
            this.bttn5.Name = "bttn5";
            this.bttn5.Size = new System.Drawing.Size(50, 23);
            this.bttn5.TabIndex = 47;
            this.bttn5.Text = "5";
            this.bttn5.UseVisualStyleBackColor = true;
            this.bttn5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn2
            // 
            this.bttn2.Location = new System.Drawing.Point(109, 78);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(50, 23);
            this.bttn2.TabIndex = 46;
            this.bttn2.Text = "2";
            this.bttn2.UseVisualStyleBackColor = true;
            this.bttn2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn0
            // 
            this.bttn0.Location = new System.Drawing.Point(53, 165);
            this.bttn0.Name = "bttn0";
            this.bttn0.Size = new System.Drawing.Size(50, 23);
            this.bttn0.TabIndex = 45;
            this.bttn0.Text = "0";
            this.bttn0.UseVisualStyleBackColor = true;
            this.bttn0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn7
            // 
            this.bttn7.Location = new System.Drawing.Point(53, 136);
            this.bttn7.Name = "bttn7";
            this.bttn7.Size = new System.Drawing.Size(50, 23);
            this.bttn7.TabIndex = 44;
            this.bttn7.Text = "7";
            this.bttn7.UseVisualStyleBackColor = true;
            this.bttn7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn4
            // 
            this.bttn4.Location = new System.Drawing.Point(53, 107);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(50, 23);
            this.bttn4.TabIndex = 43;
            this.bttn4.Text = "4";
            this.bttn4.UseVisualStyleBackColor = true;
            this.bttn4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // bttn1
            // 
            this.bttn1.Location = new System.Drawing.Point(53, 78);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(50, 23);
            this.bttn1.TabIndex = 42;
            this.bttn1.Text = "1";
            this.bttn1.UseVisualStyleBackColor = true;
            this.bttn1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(68, 41);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(188, 20);
            this.Pantalla.TabIndex = 41;
            this.Pantalla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pantalla_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 231);
            this.Controls.Add(this.bttnBorrar);
            this.Controls.Add(this.bttnResultado);
            this.Controls.Add(this.bttnDivision);
            this.Controls.Add(this.bttnMultiplicacion);
            this.Controls.Add(this.bttnRestar);
            this.Controls.Add(this.bttnSuma);
            this.Controls.Add(this.bttn9);
            this.Controls.Add(this.bttn6);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn8);
            this.Controls.Add(this.bttn5);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttn0);
            this.Controls.Add(this.bttn7);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.bttn1);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnBorrar;
        private System.Windows.Forms.Button bttnResultado;
        private System.Windows.Forms.Button bttnDivision;
        private System.Windows.Forms.Button bttnMultiplicacion;
        private System.Windows.Forms.Button bttnRestar;
        private System.Windows.Forms.Button bttnSuma;
        private System.Windows.Forms.Button bttn9;
        private System.Windows.Forms.Button bttn6;
        private System.Windows.Forms.Button bttn3;
        private System.Windows.Forms.Button bttn8;
        private System.Windows.Forms.Button bttn5;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button bttn0;
        private System.Windows.Forms.Button bttn7;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.TextBox Pantalla;
    }
}


namespace Laboratorio123
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxSemiperimetro = new System.Windows.Forms.TextBox();
            this.textBoxAreaTriangulo = new System.Windows.Forms.TextBox();
            this.buttonSemiperimetro = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la longitud del lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa la longitud del lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa la longitud del lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area del Triangulo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBoxSemiperimetro
            // 
            this.textBoxSemiperimetro.Location = new System.Drawing.Point(248, 267);
            this.textBoxSemiperimetro.Name = "textBoxSemiperimetro";
            this.textBoxSemiperimetro.Size = new System.Drawing.Size(120, 20);
            this.textBoxSemiperimetro.TabIndex = 8;
            // 
            // textBoxAreaTriangulo
            // 
            this.textBoxAreaTriangulo.Location = new System.Drawing.Point(248, 317);
            this.textBoxAreaTriangulo.Name = "textBoxAreaTriangulo";
            this.textBoxAreaTriangulo.Size = new System.Drawing.Size(120, 20);
            this.textBoxAreaTriangulo.TabIndex = 9;
            // 
            // buttonSemiperimetro
            // 
            this.buttonSemiperimetro.Location = new System.Drawing.Point(71, 193);
            this.buttonSemiperimetro.Name = "buttonSemiperimetro";
            this.buttonSemiperimetro.Size = new System.Drawing.Size(142, 34);
            this.buttonSemiperimetro.TabIndex = 0;
            this.buttonSemiperimetro.Text = "Semiperimetro";
            this.buttonSemiperimetro.UseVisualStyleBackColor = true;
            this.buttonSemiperimetro.Click += new System.EventHandler(this.buttonSemiperimetro_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(241, 193);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(137, 34);
            this.buttonArea.TabIndex = 10;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(397, 193);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(140, 34);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(558, 193);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(140, 34);
            this.buttonSalida.TabIndex = 12;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonSemiperimetro);
            this.Controls.Add(this.textBoxAreaTriangulo);
            this.Controls.Add(this.textBoxSemiperimetro);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxSemiperimetro;
        private System.Windows.Forms.TextBox textBoxAreaTriangulo;
        private System.Windows.Forms.Button buttonSemiperimetro;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSalida;
    }
}


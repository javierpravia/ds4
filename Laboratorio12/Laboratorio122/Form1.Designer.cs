namespace Laboratorio122
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            labelNota1 = new Label();
            labelNota2 = new Label();
            labelNota3 = new Label();
            label5 = new Label();
            buttonCalcProm = new Button();
            buttonReset = new Button();
            buttonSalir = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(359, 57);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(88, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nota Promedio";
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(183, 108);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(66, 15);
            labelNota1.TabIndex = 1;
            labelNota1.Text = "NOTA No.1";
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(183, 152);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(66, 15);
            labelNota2.TabIndex = 2;
            labelNota2.Text = "NOTA No.2";
            // 
            // labelNota3
            // 
            labelNota3.AutoSize = true;
            labelNota3.Location = new Point(183, 199);
            labelNota3.Name = "labelNota3";
            labelNota3.Size = new Size(66, 15);
            labelNota3.TabIndex = 3;
            labelNota3.Text = "NOTA No.3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 333);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Nota Promedio";
            // 
            // buttonCalcProm
            // 
            buttonCalcProm.Location = new Point(168, 236);
            buttonCalcProm.Name = "buttonCalcProm";
            buttonCalcProm.Size = new Size(142, 33);
            buttonCalcProm.TabIndex = 5;
            buttonCalcProm.Text = "Promedio";
            buttonCalcProm.UseVisualStyleBackColor = true;
            buttonCalcProm.Click += buttonCalcProm_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(336, 236);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(142, 33);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(514, 236);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(142, 33);
            buttonSalir.TabIndex = 7;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 10;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(336, 330);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(218, 23);
            textBoxResult.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalcProm);
            Controls.Add(label5);
            Controls.Add(labelNota3);
            Controls.Add(labelNota2);
            Controls.Add(labelNota1);
            Controls.Add(labelTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelNota1;
        private Label labelNota2;
        private Label labelNota3;
        private Label label5;
        private Button buttonCalcProm;
        private Button buttonReset;
        private Button buttonSalir;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxResult;
    }
}

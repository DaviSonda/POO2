namespace DaviSonegoA1
{
    partial class FracaoView
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
            lbl1 = new Label();
            lbl2 = new Label();
            num1 = new TextBox();
            den1 = new TextBox();
            num2 = new TextBox();
            den2 = new TextBox();
            btnSoma = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(89, 21);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(51, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Fração 1";
            lbl1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(89, 163);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(51, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Fração 2";
            // 
            // num1
            // 
            num1.Location = new Point(147, 61);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 2;
            num1.KeyPress += num1_KeyPress;
            // 
            // den1
            // 
            den1.Location = new Point(147, 105);
            den1.Name = "den1";
            den1.Size = new Size(100, 23);
            den1.TabIndex = 3;
            den1.KeyPress += den1_KeyPress;
            // 
            // num2
            // 
            num2.Location = new Point(147, 202);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 4;
            num2.KeyPress += num2_KeyPress;
            // 
            // den2
            // 
            den2.Location = new Point(147, 246);
            den2.Name = "den2";
            den2.Size = new Size(100, 23);
            den2.TabIndex = 5;
            den2.KeyPress += den2_KeyPress;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(517, 32);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 6;
            btnSoma.Text = "Somar";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(656, 32);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 7;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(517, 95);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(656, 95);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 9;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(517, 254);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 11;
            label2.Text = "Numerador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 12;
            label3.Text = "Denominador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 205);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 13;
            label4.Text = "Numerador";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 249);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 14;
            label5.Text = "Denominador";
            // 
            // FracaoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSoma);
            Controls.Add(den2);
            Controls.Add(num2);
            Controls.Add(den1);
            Controls.Add(num1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "FracaoView";
            Text = "Calculadora de Frações";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox num1;
        private TextBox den1;
        private TextBox num2;
        private TextBox den2;
        private Button btnSoma;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblResultado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
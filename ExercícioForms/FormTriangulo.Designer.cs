namespace ExercícioForms
{
    partial class FormTriangulo
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
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lado1 = new System.Windows.Forms.Label();
            this.lado2 = new System.Windows.Forms.Label();
            this.lado3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(71, 115);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(108, 23);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "Verificar Tipo";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lado1
            // 
            this.lado1.AutoSize = true;
            this.lado1.Location = new System.Drawing.Point(42, 12);
            this.lado1.Name = "lado1";
            this.lado1.Size = new System.Drawing.Size(46, 13);
            this.lado1.TabIndex = 1;
            this.lado1.Text = "Lado 1: ";
            this.lado1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lado2
            // 
            this.lado2.AutoSize = true;
            this.lado2.Location = new System.Drawing.Point(42, 44);
            this.lado2.Name = "lado2";
            this.lado2.Size = new System.Drawing.Size(46, 13);
            this.lado2.TabIndex = 2;
            this.lado2.Text = "Lado 2: ";
            // 
            // lado3
            // 
            this.lado3.AutoSize = true;
            this.lado3.Location = new System.Drawing.Point(42, 73);
            this.lado3.Name = "lado3";
            this.lado3.Size = new System.Drawing.Size(46, 13);
            this.lado3.TabIndex = 3;
            this.lado3.Text = "Lado 3: ";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(95, 9);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 4;
            this.txtLado1.TextChanged += new System.EventHandler(this.txtLado1_TextChanged);
            this.txtLado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado1_KeyPress);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(95, 37);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 5;
            this.txtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado2_KeyPress);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(95, 73);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 6;
            this.txtLado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLado3_KeyPress);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(335, 44);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(55, 13);
            this.resultado.TabIndex = 7;
            this.resultado.Text = "Resultado";
            this.resultado.Visible = false;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // FormTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 187);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lado3);
            this.Controls.Add(this.lado2);
            this.Controls.Add(this.lado1);
            this.Controls.Add(this.btnVerifica);
            this.Name = "FormTriangulo";
            this.Text = "Triangulo";
            this.Load += new System.EventHandler(this.FormTriangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lado1;
        private System.Windows.Forms.Label lado2;
        private System.Windows.Forms.Label lado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label resultado;
    }
}
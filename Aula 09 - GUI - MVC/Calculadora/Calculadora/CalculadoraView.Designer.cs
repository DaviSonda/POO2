namespace Calculadora
{
    partial class CalculadoraView
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtValor1 = new System.Windows.Forms.TextBox();
      this.txtValor2 = new System.Windows.Forms.TextBox();
      this.btnSoma = new System.Windows.Forms.Button();
      this.btnSubtracao = new System.Windows.Forms.Button();
      this.btnMultiplicacao = new System.Windows.Forms.Button();
      this.btnDivisao = new System.Windows.Forms.Button();
      this.txtResultado = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 77);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Valor 1:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(215, 77);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Valor 2:";
      // 
      // txtValor1
      // 
      this.txtValor1.Location = new System.Drawing.Point(73, 74);
      this.txtValor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtValor1.MaxLength = 4;
      this.txtValor1.Name = "txtValor1";
      this.txtValor1.Size = new System.Drawing.Size(108, 22);
      this.txtValor1.TabIndex = 1;
      // 
      // txtValor2
      // 
      this.txtValor2.Location = new System.Drawing.Point(291, 74);
      this.txtValor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtValor2.MaxLength = 4;
      this.txtValor2.Name = "txtValor2";
      this.txtValor2.Size = new System.Drawing.Size(108, 22);
      this.txtValor2.TabIndex = 2;
      // 
      // btnSoma
      // 
      this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSoma.Location = new System.Drawing.Point(16, 134);
      this.btnSoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnSoma.Name = "btnSoma";
      this.btnSoma.Size = new System.Drawing.Size(80, 41);
      this.btnSoma.TabIndex = 3;
      this.btnSoma.Text = "+";
      this.btnSoma.UseVisualStyleBackColor = true;
      this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
      // 
      // btnSubtracao
      // 
      this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSubtracao.Location = new System.Drawing.Point(117, 134);
      this.btnSubtracao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnSubtracao.Name = "btnSubtracao";
      this.btnSubtracao.Size = new System.Drawing.Size(80, 41);
      this.btnSubtracao.TabIndex = 4;
      this.btnSubtracao.Text = "-";
      this.btnSubtracao.UseVisualStyleBackColor = true;
      this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
      // 
      // btnMultiplicacao
      // 
      this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMultiplicacao.Location = new System.Drawing.Point(218, 134);
      this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnMultiplicacao.Name = "btnMultiplicacao";
      this.btnMultiplicacao.Size = new System.Drawing.Size(80, 41);
      this.btnMultiplicacao.TabIndex = 5;
      this.btnMultiplicacao.Text = "*";
      this.btnMultiplicacao.UseVisualStyleBackColor = true;
      this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
      // 
      // btnDivisao
      // 
      this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDivisao.Location = new System.Drawing.Point(319, 134);
      this.btnDivisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnDivisao.Name = "btnDivisao";
      this.btnDivisao.Size = new System.Drawing.Size(80, 41);
      this.btnDivisao.TabIndex = 6;
      this.btnDivisao.Text = "/";
      this.btnDivisao.UseVisualStyleBackColor = true;
      this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
      // 
      // txtResultado
      // 
      this.txtResultado.Location = new System.Drawing.Point(16, 29);
      this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtResultado.MaxLength = 2;
      this.txtResultado.Name = "txtResultado";
      this.txtResultado.ReadOnly = true;
      this.txtResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtResultado.Size = new System.Drawing.Size(398, 22);
      this.txtResultado.TabIndex = 8;
      this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 16);
      this.label3.TabIndex = 9;
      this.label3.Text = "Resultado";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(427, 188);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtResultado);
      this.Controls.Add(this.btnDivisao);
      this.Controls.Add(this.btnMultiplicacao);
      this.Controls.Add(this.btnSubtracao);
      this.Controls.Add(this.btnSoma);
      this.Controls.Add(this.txtValor2);
      this.Controls.Add(this.txtValor1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Calculadora";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
    }
}


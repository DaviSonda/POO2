namespace Convercoes
{
    partial class ConverterView
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.coeficiente = new System.Windows.Forms.ComboBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(249, 73);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // coeficiente
            // 
            this.coeficiente.FormattingEnabled = true;
            this.coeficiente.Location = new System.Drawing.Point(53, 29);
            this.coeficiente.Name = "coeficiente";
            this.coeficiente.Size = new System.Drawing.Size(121, 21);
            this.coeficiente.TabIndex = 1;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(53, 119);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(121, 20);
            this.valor.TabIndex = 2;
            this.valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_KeyPress);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(461, 73);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(50, 13);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "resultado";
            this.resultado.Visible = false;
            // 
            // ConverterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 198);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.coeficiente);
            this.Controls.Add(this.btnConverter);
            this.Name = "ConverterView";
            this.Text = "ConverterView";
            this.Load += new System.EventHandler(this.ConverterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.ComboBox coeficiente;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label resultado;
    }
}
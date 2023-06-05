namespace ExercícioForms
{
    partial class FormJokenpo
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.cbJokenpo = new System.Windows.Forms.ComboBox();
            this.cbJokenpo2 = new System.Windows.Forms.ComboBox();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(208, 68);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(156, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbJokenpo
            // 
            this.cbJokenpo.FormattingEnabled = true;
            this.cbJokenpo.Location = new System.Drawing.Point(60, 34);
            this.cbJokenpo.Name = "cbJokenpo";
            this.cbJokenpo.Size = new System.Drawing.Size(121, 21);
            this.cbJokenpo.TabIndex = 1;
            // 
            // cbJokenpo2
            // 
            this.cbJokenpo2.FormattingEnabled = true;
            this.cbJokenpo2.Location = new System.Drawing.Point(60, 103);
            this.cbJokenpo2.Name = "cbJokenpo2";
            this.cbJokenpo2.Size = new System.Drawing.Size(121, 21);
            this.cbJokenpo2.TabIndex = 2;
            // 
            // lblVencedor
            // 
            this.lblVencedor.AutoSize = true;
            this.lblVencedor.Location = new System.Drawing.Point(412, 68);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(35, 13);
            this.lblVencedor.TabIndex = 3;
            this.lblVencedor.Text = "label1";
            this.lblVencedor.Visible = false;
            this.lblVencedor.Click += new System.EventHandler(this.lblVencedor_Click);
            // 
            // FormJokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 200);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.cbJokenpo2);
            this.Controls.Add(this.cbJokenpo);
            this.Controls.Add(this.btnJogar);
            this.Name = "FormJokenpo";
            this.Text = "Jokenpo";
            this.Load += new System.EventHandler(this.FormJokenpo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.ComboBox cbJokenpo;
        private System.Windows.Forms.ComboBox cbJokenpo2;
        private System.Windows.Forms.Label lblVencedor;
    }
}
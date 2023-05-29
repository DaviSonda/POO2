namespace ExercícioForms
{
    partial class FormPlanetas
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
            this.cbPlaneta = new System.Windows.Forms.ComboBox();
            this.inptPeso = new System.Windows.Forms.TextBox();
            this.btnPeso = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planeta";
            // 
            // cbPlaneta
            // 
            this.cbPlaneta.FormattingEnabled = true;
            this.cbPlaneta.Location = new System.Drawing.Point(109, 110);
            this.cbPlaneta.Name = "cbPlaneta";
            this.cbPlaneta.Size = new System.Drawing.Size(121, 21);
            this.cbPlaneta.TabIndex = 2;
            this.cbPlaneta.SelectedIndexChanged += new System.EventHandler(this.cbPlaneta_SelectedIndexChanged);
            // 
            // inptPeso
            // 
            this.inptPeso.Location = new System.Drawing.Point(109, 45);
            this.inptPeso.Name = "inptPeso";
            this.inptPeso.Size = new System.Drawing.Size(100, 20);
            this.inptPeso.TabIndex = 3;
            this.inptPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inptPeso_KeyPress);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(59, 180);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(171, 23);
            this.btnPeso.TabIndex = 4;
            this.btnPeso.Text = "Verificar Peso no Planeta";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(476, 75);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "label3";
            this.lblPeso.Visible = false;
            // 
            // FormPlanetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.inptPeso);
            this.Controls.Add(this.cbPlaneta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPlanetas";
            this.Text = "Planetas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPlaneta;
        private System.Windows.Forms.TextBox inptPeso;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}
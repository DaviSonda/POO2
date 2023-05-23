namespace ExercícioForms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTriangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCalculaTriangulo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlanetas = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoPlanetaToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuPesoPlanetas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJokenpo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCalculaJokenpo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTriangulo,
            this.menuPlanetas,
            this.menuJokenpo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTriangulo
            // 
            this.menuTriangulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.menuCalculaTriangulo});
            this.menuTriangulo.Name = "menuTriangulo";
            this.menuTriangulo.Size = new System.Drawing.Size(73, 20);
            this.menuTriangulo.Text = "Triangulos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuCalculaTriangulo
            // 
            this.menuCalculaTriangulo.Name = "menuCalculaTriangulo";
            this.menuCalculaTriangulo.Size = new System.Drawing.Size(165, 22);
            this.menuCalculaTriangulo.Text = "Calcula Triangulo";
            this.menuCalculaTriangulo.Click += new System.EventHandler(this.menuCalculaTriangulo_Click);
            // 
            // menuPlanetas
            // 
            this.menuPlanetas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesoPlanetaToolStripMenuItem,
            this.menuPesoPlanetas});
            this.menuPlanetas.Name = "menuPlanetas";
            this.menuPlanetas.Size = new System.Drawing.Size(63, 20);
            this.menuPlanetas.Text = "Planetas";
            // 
            // pesoPlanetaToolStripMenuItem
            // 
            this.pesoPlanetaToolStripMenuItem.Name = "pesoPlanetaToolStripMenuItem";
            this.pesoPlanetaToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // menuPesoPlanetas
            // 
            this.menuPesoPlanetas.Name = "menuPesoPlanetas";
            this.menuPesoPlanetas.Size = new System.Drawing.Size(180, 22);
            this.menuPesoPlanetas.Text = "Peso planeta";
            this.menuPesoPlanetas.Click += new System.EventHandler(this.menuPesoPlanetas_Click);
            // 
            // menuJokenpo
            // 
            this.menuJokenpo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuCalculaJokenpo});
            this.menuJokenpo.Name = "menuJokenpo";
            this.menuJokenpo.Size = new System.Drawing.Size(63, 20);
            this.menuJokenpo.Text = "Jokenpo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // menuCalculaJokenpo
            // 
            this.menuCalculaJokenpo.Name = "menuCalculaJokenpo";
            this.menuCalculaJokenpo.Size = new System.Drawing.Size(180, 22);
            this.menuCalculaJokenpo.Text = "Jogar";
            this.menuCalculaJokenpo.Click += new System.EventHandler(this.menuCalculaJokenpo_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTriangulo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuCalculaTriangulo;
        private System.Windows.Forms.ToolStripMenuItem menuPlanetas;
        private System.Windows.Forms.ToolStripSeparator pesoPlanetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPesoPlanetas;
        private System.Windows.Forms.ToolStripMenuItem menuJokenpo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCalculaJokenpo;
    }
}


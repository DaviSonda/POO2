namespace UI1Aula
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
            this.menuOpcoes = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuSepara1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro});
            this.menuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(800, 24);
            this.menuOpcoes.TabIndex = 0;
            this.menuOpcoes.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuVendedores,
            this.ItemMenuSepara1,
            this.itemMenuSair});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "&Cadastro";
            this.menuCadastro.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // itemMenuVendedores
            // 
            this.itemMenuVendedores.Name = "itemMenuVendedores";
            this.itemMenuVendedores.Size = new System.Drawing.Size(135, 22);
            this.itemMenuVendedores.Text = "&Vendedores";
            this.itemMenuVendedores.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // ItemMenuSepara1
            // 
            this.ItemMenuSepara1.Name = "ItemMenuSepara1";
            this.ItemMenuSepara1.Size = new System.Drawing.Size(132, 6);
            // 
            // itemMenuSair
            // 
            this.itemMenuSair.Name = "itemMenuSair";
            this.itemMenuSair.Size = new System.Drawing.Size(135, 22);
            this.itemMenuSair.Text = "&Sair";
            this.itemMenuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuOpcoes);
            this.MainMenuStrip = this.menuOpcoes;
            this.Name = "FormPrincipal";
            this.Text = "UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuOpcoes.ResumeLayout(false);
            this.menuOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem itemMenuVendedores;
        private System.Windows.Forms.ToolStripSeparator ItemMenuSepara1;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSair;
    }
}


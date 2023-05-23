namespace Vendedores2
{
    partial class FrmPrincipal
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
      this.menuPrincipal = new System.Windows.Forms.MenuStrip();
      this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
      this.itemVendedores = new System.Windows.Forms.ToolStripMenuItem();
      this.itemSepara1 = new System.Windows.Forms.ToolStripSeparator();
      this.itemSair = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPrincipal.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuPrincipal
      // 
      this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros});
      this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
      this.menuPrincipal.Name = "menuPrincipal";
      this.menuPrincipal.Size = new System.Drawing.Size(507, 28);
      this.menuPrincipal.TabIndex = 0;
      this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuPrincipal_ItemClicked);
      // 
      // menuCadastros
      // 
      this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVendedores,
            this.itemSepara1,
            this.itemSair});
      this.menuCadastros.Name = "menuCadastros";
      this.menuCadastros.Size = new System.Drawing.Size(88, 24);
      this.menuCadastros.Text = "Cadastros";
      // 
      // itemVendedores
      // 
      this.itemVendedores.Name = "itemVendedores";
      this.itemVendedores.Size = new System.Drawing.Size(224, 26);
      this.itemVendedores.Text = "Vendedores";
      this.itemVendedores.Click += new System.EventHandler(this.itemVendedores_Click);
      // 
      // itemSepara1
      // 
      this.itemSepara1.Name = "itemSepara1";
      this.itemSepara1.Size = new System.Drawing.Size(221, 6);
      // 
      // itemSair
      // 
      this.itemSair.Name = "itemSair";
      this.itemSair.Size = new System.Drawing.Size(224, 26);
      this.itemSair.Text = "Sair";
      this.itemSair.Click += new System.EventHandler(this.itemSair_Click);
      // 
      // FrmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(507, 380);
      this.Controls.Add(this.menuPrincipal);
      this.MainMenuStrip = this.menuPrincipal;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FrmPrincipal";
      this.Text = "Vendedores";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.FrmPrincipal_Load);
      this.menuPrincipal.ResumeLayout(false);
      this.menuPrincipal.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem itemVendedores;
        private System.Windows.Forms.ToolStripSeparator itemSepara1;
        private System.Windows.Forms.ToolStripMenuItem itemSair;
    }
}


namespace Vendedores2
{
    partial class FrmVendedor
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
      this.btnConsultar = new System.Windows.Forms.Button();
      this.dgvVendedores = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCidade = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtVendas = new System.Windows.Forms.TextBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
      this.SuspendLayout();
      // 
      // btnConsultar
      // 
      this.btnConsultar.Location = new System.Drawing.Point(364, 251);
      this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(100, 28);
      this.btnConsultar.TabIndex = 8;
      this.btnConsultar.Text = "Consultar";
      this.btnConsultar.UseVisualStyleBackColor = true;
      this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
      // 
      // dgvVendedores
      // 
      this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvVendedores.Location = new System.Drawing.Point(17, 15);
      this.dgvVendedores.Margin = new System.Windows.Forms.Padding(4);
      this.dgvVendedores.Name = "dgvVendedores";
      this.dgvVendedores.RowHeadersWidth = 51;
      this.dgvVendedores.Size = new System.Drawing.Size(568, 270);
      this.dgvVendedores.TabIndex = 9;
      this.dgvVendedores.Visible = false;
      this.dgvVendedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellDoubleClick);
      this.dgvVendedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVendedores_KeyDown);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 20);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Código:";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(83, 15);
      this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
      this.txtCodigo.MaxLength = 4;
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(132, 22);
      this.txtCodigo.TabIndex = 1;
      this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
      this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 76);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Nome:";
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(83, 71);
      this.txtNome.Margin = new System.Windows.Forms.Padding(4);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(481, 22);
      this.txtNome.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 133);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 16);
      this.label3.TabIndex = 6;
      this.label3.Text = "Cidade:";
      // 
      // txtCidade
      // 
      this.txtCidade.Location = new System.Drawing.Point(83, 128);
      this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
      this.txtCidade.Name = "txtCidade";
      this.txtCidade.Size = new System.Drawing.Size(476, 22);
      this.txtCidade.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 190);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 16);
      this.label4.TabIndex = 8;
      this.label4.Text = "Vendas:";
      // 
      // txtVendas
      // 
      this.txtVendas.Location = new System.Drawing.Point(83, 185);
      this.txtVendas.Margin = new System.Windows.Forms.Padding(4);
      this.txtVendas.Name = "txtVendas";
      this.txtVendas.Size = new System.Drawing.Size(132, 22);
      this.txtVendas.TabIndex = 4;
      this.txtVendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendas_KeyPress);
      // 
      // btnGravar
      // 
      this.btnGravar.Location = new System.Drawing.Point(132, 251);
      this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(100, 28);
      this.btnGravar.TabIndex = 6;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = true;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.Location = new System.Drawing.Point(16, 251);
      this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(100, 28);
      this.btnNovo.TabIndex = 5;
      this.btnNovo.Text = "Novo";
      this.btnNovo.UseVisualStyleBackColor = true;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Location = new System.Drawing.Point(248, 251);
      this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(100, 28);
      this.btnExcluir.TabIndex = 7;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnSair
      // 
      this.btnSair.Location = new System.Drawing.Point(480, 251);
      this.btnSair.Margin = new System.Windows.Forms.Padding(4);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(100, 28);
      this.btnSair.TabIndex = 10;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // FrmVendedor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 304);
      this.Controls.Add(this.dgvVendedores);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.txtVendas);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtCidade);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtCodigo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnConsultar);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmVendedor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Vendedores";
      this.Load += new System.EventHandler(this.FrmVendedor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
    }
}
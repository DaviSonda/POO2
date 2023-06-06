namespace UsuariosMVC
{
  partial class UsuariosViews
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
      this.grdUsuarios = new System.Windows.Forms.ListView();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.grpDetails = new System.Windows.Forms.GroupBox();
      this.grbSex = new System.Windows.Forms.GroupBox();
      this.rdFeminino = new System.Windows.Forms.RadioButton();
      this.rdMasculino = new System.Windows.Forms.RadioButton();
      this.txtDepartamento = new System.Windows.Forms.TextBox();
      this.lblDepartment = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.lblID = new System.Windows.Forms.Label();
      this.txtSobrenome = new System.Windows.Forms.TextBox();
      this.lblLastName = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnGravar = new System.Windows.Forms.Button();
      this.grpDetails.SuspendLayout();
      this.grbSex.SuspendLayout();
      this.SuspendLayout();
      // 
      // grdUsuarios
      // 
      this.grdUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.grdUsuarios.FullRowSelect = true;
      this.grdUsuarios.GridLines = true;
      this.grdUsuarios.HideSelection = false;
      this.grdUsuarios.Location = new System.Drawing.Point(0, 200);
      this.grdUsuarios.Margin = new System.Windows.Forms.Padding(4);
      this.grdUsuarios.Name = "grdUsuarios";
      this.grdUsuarios.Size = new System.Drawing.Size(1000, 365);
      this.grdUsuarios.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.grdUsuarios.TabIndex = 40;
      this.grdUsuarios.UseCompatibleStateImageBehavior = false;
      this.grdUsuarios.View = System.Windows.Forms.View.Details;
      this.grdUsuarios.SelectedIndexChanged += new System.EventHandler(this.grdUsers_SelectedIndexChanged);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Location = new System.Drawing.Point(855, 58);
      this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(129, 28);
      this.btnExcluir.TabIndex = 37;
      this.btnExcluir.Text = "&Excluir";
      this.btnExcluir.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // grpDetails
      // 
      this.grpDetails.Controls.Add(this.grbSex);
      this.grpDetails.Controls.Add(this.txtDepartamento);
      this.grpDetails.Controls.Add(this.lblDepartment);
      this.grpDetails.Controls.Add(this.txtID);
      this.grpDetails.Controls.Add(this.lblID);
      this.grpDetails.Controls.Add(this.txtSobrenome);
      this.grpDetails.Controls.Add(this.lblLastName);
      this.grpDetails.Controls.Add(this.txtNome);
      this.grpDetails.Controls.Add(this.lblFirstName);
      this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.grpDetails.Location = new System.Drawing.Point(16, 7);
      this.grpDetails.Margin = new System.Windows.Forms.Padding(4);
      this.grpDetails.Name = "grpDetails";
      this.grpDetails.Padding = new System.Windows.Forms.Padding(4);
      this.grpDetails.Size = new System.Drawing.Size(819, 177);
      this.grpDetails.TabIndex = 39;
      this.grpDetails.TabStop = false;
      this.grpDetails.Text = "Registrar Novo Usuário";
      // 
      // grbSex
      // 
      this.grbSex.Controls.Add(this.rdFeminino);
      this.grbSex.Controls.Add(this.rdMasculino);
      this.grbSex.ForeColor = System.Drawing.SystemColors.MenuText;
      this.grbSex.Location = new System.Drawing.Point(28, 97);
      this.grbSex.Margin = new System.Windows.Forms.Padding(4);
      this.grbSex.Name = "grbSex";
      this.grbSex.Padding = new System.Windows.Forms.Padding(4);
      this.grbSex.Size = new System.Drawing.Size(414, 66);
      this.grbSex.TabIndex = 29;
      this.grbSex.TabStop = false;
      this.grbSex.Text = "Sexo";
      // 
      // rdFeminino
      // 
      this.rdFeminino.Location = new System.Drawing.Point(228, 23);
      this.rdFeminino.Margin = new System.Windows.Forms.Padding(4);
      this.rdFeminino.Name = "rdFeminino";
      this.rdFeminino.Size = new System.Drawing.Size(139, 30);
      this.rdFeminino.TabIndex = 5;
      this.rdFeminino.Text = "Feminino";
      // 
      // rdMasculino
      // 
      this.rdMasculino.Location = new System.Drawing.Point(76, 23);
      this.rdMasculino.Margin = new System.Windows.Forms.Padding(4);
      this.rdMasculino.Name = "rdMasculino";
      this.rdMasculino.Size = new System.Drawing.Size(118, 30);
      this.rdMasculino.TabIndex = 4;
      this.rdMasculino.Text = "Masculino";
      // 
      // txtDepartamento
      // 
      this.txtDepartamento.Location = new System.Drawing.Point(519, 22);
      this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4);
      this.txtDepartamento.Name = "txtDepartamento";
      this.txtDepartamento.Size = new System.Drawing.Size(275, 22);
      this.txtDepartamento.TabIndex = 27;
      // 
      // lblDepartment
      // 
      this.lblDepartment.Location = new System.Drawing.Point(423, 23);
      this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDepartment.Name = "lblDepartment";
      this.lblDepartment.Size = new System.Drawing.Size(97, 21);
      this.lblDepartment.TabIndex = 28;
      this.lblDepartment.Text = "Departamento:";
      // 
      // txtID
      // 
      this.txtID.Location = new System.Drawing.Point(105, 22);
      this.txtID.Margin = new System.Windows.Forms.Padding(4);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(290, 22);
      this.txtID.TabIndex = 5;
      // 
      // lblID
      // 
      this.lblID.Location = new System.Drawing.Point(67, 21);
      this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(29, 24);
      this.lblID.TabIndex = 25;
      this.lblID.Text = "ID:";
      // 
      // txtSobrenome
      // 
      this.txtSobrenome.Location = new System.Drawing.Point(519, 67);
      this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
      this.txtSobrenome.Name = "txtSobrenome";
      this.txtSobrenome.Size = new System.Drawing.Size(291, 22);
      this.txtSobrenome.TabIndex = 4;
      // 
      // lblLastName
      // 
      this.lblLastName.Location = new System.Drawing.Point(436, 74);
      this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(84, 18);
      this.lblLastName.TabIndex = 23;
      this.lblLastName.Text = "Sobrenome:";
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(104, 67);
      this.txtNome.Margin = new System.Windows.Forms.Padding(4);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(291, 22);
      this.txtNome.TabIndex = 1;
      // 
      // lblFirstName
      // 
      this.lblFirstName.Location = new System.Drawing.Point(39, 67);
      this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(57, 22);
      this.lblFirstName.TabIndex = 19;
      this.lblFirstName.Text = "Nome:";
      // 
      // btnNovo
      // 
      this.btnNovo.Location = new System.Drawing.Point(855, 23);
      this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(129, 28);
      this.btnNovo.TabIndex = 36;
      this.btnNovo.Text = "&Novo ";
      this.btnNovo.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnGravar
      // 
      this.btnGravar.Location = new System.Drawing.Point(855, 142);
      this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(129, 28);
      this.btnGravar.TabIndex = 38;
      this.btnGravar.Text = "&Gravar";
      this.btnGravar.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // UsuariosViews
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1000, 565);
      this.Controls.Add(this.grdUsuarios);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.grpDetails);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.btnGravar);
      this.Name = "UsuariosViews";
      this.Text = "Usuários Ativos";
      this.Load += new System.EventHandler(this.FrmUsuarios_Load);
      this.grpDetails.ResumeLayout(false);
      this.grpDetails.PerformLayout();
      this.grbSex.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.ListView grdUsuarios;
    internal System.Windows.Forms.Button btnExcluir;
    internal System.Windows.Forms.GroupBox grpDetails;
    private System.Windows.Forms.GroupBox grbSex;
    internal System.Windows.Forms.RadioButton rdFeminino;
    internal System.Windows.Forms.RadioButton rdMasculino;
    internal System.Windows.Forms.TextBox txtDepartamento;
    internal System.Windows.Forms.Label lblDepartment;
    internal System.Windows.Forms.TextBox txtID;
    internal System.Windows.Forms.Label lblID;
    internal System.Windows.Forms.TextBox txtSobrenome;
    internal System.Windows.Forms.Label lblLastName;
    internal System.Windows.Forms.TextBox txtNome;
    internal System.Windows.Forms.Label lblFirstName;
    internal System.Windows.Forms.Button btnNovo;
    internal System.Windows.Forms.Button btnGravar;
  }
}


namespace UsuariosMVC
{
  partial class FrmUsuarios
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
      this.grdUsers = new System.Windows.Forms.ListView();
      this.btnRemove = new System.Windows.Forms.Button();
      this.grpDetails = new System.Windows.Forms.GroupBox();
      this.grbSex = new System.Windows.Forms.GroupBox();
      this.rdFamele = new System.Windows.Forms.RadioButton();
      this.rdMale = new System.Windows.Forms.RadioButton();
      this.txtDepartment = new System.Windows.Forms.TextBox();
      this.lblDepartment = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.lblID = new System.Windows.Forms.Label();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.lblLastName = new System.Windows.Forms.Label();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnRegister = new System.Windows.Forms.Button();
      this.grpDetails.SuspendLayout();
      this.grbSex.SuspendLayout();
      this.SuspendLayout();
      // 
      // grdUsers
      // 
      this.grdUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.grdUsers.FullRowSelect = true;
      this.grdUsers.GridLines = true;
      this.grdUsers.HideSelection = false;
      this.grdUsers.Location = new System.Drawing.Point(0, 200);
      this.grdUsers.Margin = new System.Windows.Forms.Padding(4);
      this.grdUsers.Name = "grdUsers";
      this.grdUsers.Size = new System.Drawing.Size(1000, 365);
      this.grdUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.grdUsers.TabIndex = 40;
      this.grdUsers.UseCompatibleStateImageBehavior = false;
      this.grdUsers.View = System.Windows.Forms.View.Details;
      this.grdUsers.SelectedIndexChanged += new System.EventHandler(this.grdUsers_SelectedIndexChanged);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(855, 58);
      this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(129, 28);
      this.btnRemove.TabIndex = 37;
      this.btnRemove.Text = "&Excluir";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // grpDetails
      // 
      this.grpDetails.Controls.Add(this.grbSex);
      this.grpDetails.Controls.Add(this.txtDepartment);
      this.grpDetails.Controls.Add(this.lblDepartment);
      this.grpDetails.Controls.Add(this.txtID);
      this.grpDetails.Controls.Add(this.lblID);
      this.grpDetails.Controls.Add(this.txtLastName);
      this.grpDetails.Controls.Add(this.lblLastName);
      this.grpDetails.Controls.Add(this.txtFirstName);
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
      this.grbSex.Controls.Add(this.rdFamele);
      this.grbSex.Controls.Add(this.rdMale);
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
      // rdFamele
      // 
      this.rdFamele.Location = new System.Drawing.Point(228, 23);
      this.rdFamele.Margin = new System.Windows.Forms.Padding(4);
      this.rdFamele.Name = "rdFamele";
      this.rdFamele.Size = new System.Drawing.Size(139, 30);
      this.rdFamele.TabIndex = 5;
      this.rdFamele.Text = "Feminino";
      // 
      // rdMale
      // 
      this.rdMale.Location = new System.Drawing.Point(76, 23);
      this.rdMale.Margin = new System.Windows.Forms.Padding(4);
      this.rdMale.Name = "rdMale";
      this.rdMale.Size = new System.Drawing.Size(118, 30);
      this.rdMale.TabIndex = 4;
      this.rdMale.Text = "Masculino";
      // 
      // txtDepartment
      // 
      this.txtDepartment.Location = new System.Drawing.Point(519, 22);
      this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
      this.txtDepartment.Name = "txtDepartment";
      this.txtDepartment.Size = new System.Drawing.Size(275, 22);
      this.txtDepartment.TabIndex = 27;
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
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(519, 67);
      this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(291, 22);
      this.txtLastName.TabIndex = 4;
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
      // txtFirstName
      // 
      this.txtFirstName.Location = new System.Drawing.Point(104, 67);
      this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(291, 22);
      this.txtFirstName.TabIndex = 1;
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
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(855, 23);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(129, 28);
      this.btnAdd.TabIndex = 36;
      this.btnAdd.Text = "&Novo ";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(855, 142);
      this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(129, 28);
      this.btnRegister.TabIndex = 38;
      this.btnRegister.Text = "&Gravar";
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // FrmUsuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1000, 565);
      this.Controls.Add(this.grdUsers);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.grpDetails);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnRegister);
      this.Name = "FrmUsuarios";
      this.Text = "Usuários Ativos";
      this.Load += new System.EventHandler(this.FrmUsuarios_Load);
      this.grpDetails.ResumeLayout(false);
      this.grpDetails.PerformLayout();
      this.grbSex.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.ListView grdUsers;
    internal System.Windows.Forms.Button btnRemove;
    internal System.Windows.Forms.GroupBox grpDetails;
    private System.Windows.Forms.GroupBox grbSex;
    internal System.Windows.Forms.RadioButton rdFamele;
    internal System.Windows.Forms.RadioButton rdMale;
    internal System.Windows.Forms.TextBox txtDepartment;
    internal System.Windows.Forms.Label lblDepartment;
    internal System.Windows.Forms.TextBox txtID;
    internal System.Windows.Forms.Label lblID;
    internal System.Windows.Forms.TextBox txtLastName;
    internal System.Windows.Forms.Label lblLastName;
    internal System.Windows.Forms.TextBox txtFirstName;
    internal System.Windows.Forms.Label lblFirstName;
    internal System.Windows.Forms.Button btnAdd;
    internal System.Windows.Forms.Button btnRegister;
  }
}


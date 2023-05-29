using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
  public partial class FrmUsuarios : Form, IUsuariosView
  {
    UsuariosController _controller;
    public FrmUsuarios()
    {
      InitializeComponent();
    }

    private void FrmUsuarios_Load(object sender, EventArgs e)
    {

    }

    /////////////////////////////////////////////
   
      public void SetController(UsuariosController controller)
      {
        _controller = controller;
      }

      public void ClearGrid()
      {
        // Define columns in grid
        this.grdUsers.Columns.Clear();

        this.grdUsers.Columns.Add("Id", 150, HorizontalAlignment.Left);
        this.grdUsers.Columns.Add("Nome", 150, HorizontalAlignment.Left);
        this.grdUsers.Columns.Add("Sobrenome", 150, HorizontalAlignment.Left);
        this.grdUsers.Columns.Add("Departamento", 150, HorizontalAlignment.Left);
        this.grdUsers.Columns.Add("Sexo", 50, HorizontalAlignment.Left);

        // Add rows to grid
        this.grdUsers.Items.Clear();
      }

      public void AddUserToGrid(Usuario usr)
      {
        ListViewItem parent;
        parent = this.grdUsers.Items.Add(usr.ID);
        parent.SubItems.Add(usr.Nome);
        parent.SubItems.Add(usr.Sobrenome);
        parent.SubItems.Add(usr.Departamento);
        parent.SubItems.Add(Enum.GetName(typeof(Usuario.SexoPessoa), usr.Sexo));
      }

      public void UpdateGridWithChangedUser(Usuario usr)
      {
        ListViewItem rowToUpdate = null;

        foreach (ListViewItem row in this.grdUsers.Items)
        {
          if (row.Text == usr.ID)
          {
            rowToUpdate = row;
          }
        }

        if (rowToUpdate != null)
        {
          rowToUpdate.Text = usr.ID;
          rowToUpdate.SubItems[1].Text = usr.Nome;
          rowToUpdate.SubItems[2].Text = usr.Sobrenome;
          rowToUpdate.SubItems[3].Text = usr.Departamento;
          rowToUpdate.SubItems[4].Text = Enum.GetName(typeof(Usuario.SexoPessoa), usr.Sexo);
        }
      }

      public void RemoveUserFromGrid(Usuario usr)
      {

        ListViewItem rowToRemove = null;

        foreach (ListViewItem row in this.grdUsers.Items)
        {
          if (row.Text == usr.ID)
          {
            rowToRemove = row;
          }
        }

        if (rowToRemove != null)
        {
          this.grdUsers.Items.Remove(rowToRemove);
          this.grdUsers.Focus();
        }
      }

      public string GetIdOfSelectedUserInGrid()
      {
        if (this.grdUsers.SelectedItems.Count > 0)
          return this.grdUsers.SelectedItems[0].Text;
        else
          return "";
      }

      public void SetSelectedUserInGrid(Usuario usr)
      {
        foreach (ListViewItem row in this.grdUsers.Items)
        {
          if (row.Text == usr.ID)
          {
            row.Selected = true;
          }
        }
      }

      public string FirstName
      {
        get { return this.txtFirstName.Text; }
        set { this.txtFirstName.Text = value; }
      }

      public string LastName
      {
        get { return this.txtLastName.Text; }
        set { this.txtLastName.Text = value; }
      }

      public string ID
      {
        get { return this.txtID.Text; }
        set { this.txtID.Text = value; }
      }


      public string Department
      {
        get { return this.txtDepartment.Text; }
        set { this.txtDepartment.Text = value; }
      }

      public Usuario.SexoPessoa Sex
      {
        get
        {
          if (this.rdMale.Checked)
            return Usuario.SexoPessoa.Masculino;
          else
            return Usuario.SexoPessoa.Feminino;
        }
        set
        {
          if (value == Usuario.SexoPessoa.Masculino)
            this.rdMale.Checked = true;
          else
            this.rdFamele.Checked = true;
        }
      }

      public bool CanModifyID
      {
        set { this.txtID.Enabled = value; }
      }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      this._controller.AddNewUser();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      this._controller.RemoveUser();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      this._controller.Save();
    }

    private void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.grdUsers.SelectedItems.Count > 0)
        this._controller.SelectedUserChanged(this.grdUsers.SelectedItems[0].Text);
    }
  }
}

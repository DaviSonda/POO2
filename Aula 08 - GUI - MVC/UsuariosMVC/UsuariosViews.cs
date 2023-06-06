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
  public partial class UsuariosViews : Form, IUsuariosView
  {
    UsuariosController controller;
    public UsuariosViews()
    {
      InitializeComponent();
    }

    private void FrmUsuarios_Load(object sender, EventArgs e)
    {

    }

    /////////////////////////////////////////////
    // Implementação da Interface
      public void SetController(UsuariosController _controller)
      {
        controller = _controller;
      }

      public void LimpaGrade()
      {
        // Define as colunas da grade
        this.grdUsuarios.Columns.Clear();

        this.grdUsuarios.Columns.Add("Id", 150, HorizontalAlignment.Left);
        this.grdUsuarios.Columns.Add("Nome", 150, HorizontalAlignment.Left);
        this.grdUsuarios.Columns.Add("Sobrenome", 150, HorizontalAlignment.Left);
        this.grdUsuarios.Columns.Add("Departamento", 150, HorizontalAlignment.Left);
        this.grdUsuarios.Columns.Add("Sexo", 50, HorizontalAlignment.Left);

        // Adiciona linha na grade
        this.grdUsuarios.Items.Clear();
      }

      public void AdicionaUsuarioGrade(Usuario usuario)
      {
        ListViewItem parent;
        parent = this.grdUsuarios.Items.Add(usuario.ID);
        parent.SubItems.Add(usuario.Nome);
        parent.SubItems.Add(usuario.Sobrenome);
        parent.SubItems.Add(usuario.Departamento);
        parent.SubItems.Add(Enum.GetName(typeof(Usuario.SexoPessoa), usuario.Sexo));
      }

      public void AtualizaGradeComUsuarioModificado(Usuario usuario)
      {
        ListViewItem linhaParaAtualizar = null;

        foreach (ListViewItem linha in this.grdUsuarios.Items)
        {
          if (linha.Text == usuario.ID)
          {
          linhaParaAtualizar = linha;
          }
        }

        if (linhaParaAtualizar != null)
        {
            linhaParaAtualizar.Text = usuario.ID;
            linhaParaAtualizar.SubItems[1].Text = usuario.Nome;
            linhaParaAtualizar.SubItems[2].Text = usuario.Sobrenome;
            linhaParaAtualizar.SubItems[3].Text = usuario.Departamento;
            linhaParaAtualizar.SubItems[4].Text = Enum.GetName(typeof(Usuario.SexoPessoa), usuario.Sexo);
        }
      }

      public void RemoveUsuarioDaGrade(Usuario usuario)
      {

        ListViewItem linhaRemover = null;

        foreach (ListViewItem linha in this.grdUsuarios.Items)
        {
          if (linha.Text == usuario.ID)
          {
          linhaRemover = linha;
          }
        }

        if (linhaRemover != null)
        {
          this.grdUsuarios.Items.Remove(linhaRemover);
          this.grdUsuarios.Focus();
        }
      }

      public string GetIdUsuarioSelecionadoNaGrade()
      {
        if (this.grdUsuarios.SelectedItems.Count > 0)
          return this.grdUsuarios.SelectedItems[0].Text;
        else
          return "";
      }

      public void SetUsuarioSelecionadoGrade(Usuario usuario)
      {
        foreach (ListViewItem linha in this.grdUsuarios.Items)
        {
          if (linha.Text == usuario.ID)
          {
            linha.Selected = true;
          }
        }
      }

      public string Nome
      {
        get { return this.txtNome.Text; }
        set { this.txtNome.Text = value; }
      }

      public string Sobrenome
      {
        get { return this.txtSobrenome.Text; }
        set { this.txtSobrenome.Text = value; }
      }

      public string ID
      {
        get { return this.txtID.Text; }
        set { this.txtID.Text = value; }
      }


      public string Departamento
      {
        get { return this.txtDepartamento.Text; }
        set { this.txtDepartamento.Text = value; }
      }

      public Usuario.SexoPessoa Sexo
      {
        get
        {
          if (this.rdMasculino.Checked)
            return Usuario.SexoPessoa.Masculino;
          else
            return Usuario.SexoPessoa.Feminino;
        }
        set
        {
          if (value == Usuario.SexoPessoa.Masculino)
            this.rdMasculino.Checked = true;
          else
            this.rdFeminino.Checked = true;
        }
      }

      public bool PodeModificarId
      {
        set { this.txtID.Enabled = value; }
      }
    //****************************************************************
    private void btnAdd_Click(object sender, EventArgs e)
    {
      this.controller.AddNovoUsuario();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      this.controller.ExcluiUsuario();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      this.controller.Salvar();
    }

    private void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.grdUsuarios.SelectedItems.Count > 0)
        this.controller.SelectedUserChanged(this.grdUsuarios.SelectedItems[0].Text);
    }
  }
}

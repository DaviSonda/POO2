using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
  public class UsuariosController
  {
    IUsuariosView view;
    IList usuarios;
    Usuario usuarioSelecionado;

    public UsuariosController(IUsuariosView _view, IList _users)
    {
      view = _view;
      usuarios = _users;
      view.SetController(this);
    }

    public IList Usuarios
    {
      get { return ArrayList.ReadOnly(usuarios); }
    }

    private void atualizaDadosView(Usuario usuario)
    {
      view.Nome = usuario.Nome;
      view.Sobrenome = usuario.Sobrenome;
      view.ID = usuario.ID;
      view.Departamento = usuario.Departamento;
      view.Sexo = usuario.Sexo;
    }

    private void atualizaUsuario(Usuario usuario)
    {
      usuario.Nome = view.Nome;
      usuario.Sobrenome = view.Sobrenome;
      usuario.ID = view.ID;
      usuario.Departamento = view.Departamento;
      usuario.Sexo = view.Sexo;
    }


    public void LoadView()
    {
      view.LimpaGrade();
      foreach (Usuario usr in usuarios)
        view.AdicionaUsuarioGrade(usr);

      view.SetUsuarioSelecionadoGrade((Usuario)usuarios[0]);

    }

    public void SelectedUserChanged(string selectedUserId)
    {
      foreach (Usuario usr in this.usuarios)
      {
        if (usr.ID == selectedUserId)
        {
          usuarioSelecionado = usr;
          atualizaDadosView(usr);
          view.SetUsuarioSelecionadoGrade(usr);
          this.view.PodeModificarId = false;
          break;
        }
      }
    }


    public void AddNovoUsuario()
    {
      usuarioSelecionado = new Usuario(""/* nome */,
                               "" /* sobrenome */,
                               ""  /* id */,
                               "" /* departamento */,
                               Usuario.SexoPessoa.Masculino /* sexo */);

      this.atualizaDadosView(usuarioSelecionado);
      this.view.PodeModificarId = true;
    }

    public void ExcluiUsuario()
    {
      string id = this.view.GetIdUsuarioSelecionadoNaGrade();
      Usuario userToRemove = null;

      if (id != "")
      {
        foreach (Usuario usr in this.usuarios)
        {
          if (usr.ID == id)
          {
            userToRemove = usr;
            break;
          }
        }

        if (userToRemove != null)
        {
          int newSelectedIndex = this.usuarios.IndexOf(userToRemove);
          this.usuarios.Remove(userToRemove);
          this.view.RemoveUsuarioDaGrade(userToRemove);

          if (newSelectedIndex > -1 && newSelectedIndex < usuarios.Count)
          {
            this.view.SetUsuarioSelecionadoGrade((Usuario)usuarios[newSelectedIndex]);
          }
        }
      }
    }

    public void Salvar()
    {
      atualizaUsuario(usuarioSelecionado);
      if (!this.usuarios.Contains(usuarioSelecionado))
      {
        // Adiciona novo usuario
        this.usuarios.Add(usuarioSelecionado);
        this.view.AdicionaUsuarioGrade(usuarioSelecionado);
      }
      else
      {
        // Atualiza existente
        this.view.AtualizaGradeComUsuarioModificado(usuarioSelecionado);
      }
      view.SetUsuarioSelecionadoGrade(usuarioSelecionado);
      this.view.PodeModificarId = false;

    }
  }
}
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
    IUsuariosView _view;
    IList _usuarios;
    Usuario _selectedUser;

    public UsuariosController(IUsuariosView view, IList users)
    {
      _view = view;
      _usuarios = users;
      view.SetController(this);
    }

    public IList Users
    {
      get { return ArrayList.ReadOnly(_usuarios); }
    }

    private void updateViewDetailValues(Usuario usr)
    {
      _view.FirstName = usr.Nome;
      _view.LastName = usr.Sobrenome;
      _view.ID = usr.ID;
      _view.Department = usr.Departamento;
      _view.Sex = usr.Sexo;
    }

    private void updateUserWithViewValues(Usuario usr)
    {
      usr.Nome = _view.FirstName;
      usr.Sobrenome = _view.LastName;
      usr.ID = _view.ID;
      usr.Departamento = _view.Department;
      usr.Sexo = _view.Sex;
    }


    public void LoadView()
    {
      _view.ClearGrid();
      foreach (Usuario usr in _usuarios)
        _view.AddUserToGrid(usr);

      _view.SetSelectedUserInGrid((Usuario)_usuarios[0]);

    }

    public void SelectedUserChanged(string selectedUserId)
    {
      foreach (Usuario usr in this._usuarios)
      {
        if (usr.ID == selectedUserId)
        {
          _selectedUser = usr;
          updateViewDetailValues(usr);
          _view.SetSelectedUserInGrid(usr);
          this._view.CanModifyID = false;
          break;
        }
      }
    }


    public void AddNewUser()
    {
      _selectedUser = new Usuario(""/*firstname*/,
                               "" /*lastname*/,
                               ""  /*id*/,
                               "" /*department*/,
                               Usuario.SexoPessoa.Masculino /*sex*/);

      this.updateViewDetailValues(_selectedUser);
      this._view.CanModifyID = true;
    }

    public void RemoveUser()
    {
      string id = this._view.GetIdOfSelectedUserInGrid();
      Usuario userToRemove = null;

      if (id != "")
      {
        foreach (Usuario usr in this._usuarios)
        {
          if (usr.ID == id)
          {
            userToRemove = usr;
            break;
          }
        }

        if (userToRemove != null)
        {
          int newSelectedIndex = this._usuarios.IndexOf(userToRemove);
          this._usuarios.Remove(userToRemove);
          this._view.RemoveUserFromGrid(userToRemove);

          if (newSelectedIndex > -1 && newSelectedIndex < _usuarios.Count)
          {
            this._view.SetSelectedUserInGrid((Usuario)_usuarios[newSelectedIndex]);
          }
        }
      }
    }

    public void Save()
    {
      updateUserWithViewValues(_selectedUser);
      if (!this._usuarios.Contains(_selectedUser))
      {
        // Add new user
        this._usuarios.Add(_selectedUser);
        this._view.AddUserToGrid(_selectedUser);
      }
      else
      {
        // Update existing
        this._view.UpdateGridWithChangedUser(_selectedUser);
      }
      _view.SetSelectedUserInGrid(_selectedUser);
      this._view.CanModifyID = false;

    }
  }
}
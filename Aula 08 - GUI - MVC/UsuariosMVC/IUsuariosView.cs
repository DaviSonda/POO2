using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
  public interface IUsuariosView
  {
    void SetController(UsuariosController controller);
    void ClearGrid();
    void AddUserToGrid(Usuario user);
    void UpdateGridWithChangedUser(Usuario user);
    void RemoveUserFromGrid(Usuario user);
    string GetIdOfSelectedUserInGrid();
    void SetSelectedUserInGrid(Usuario user);

    string FirstName { get; set; }
    string LastName { get; set; }
    string ID { get; set; }
    string Department { get; set; }
    Usuario.SexoPessoa Sex { get; set; }
    bool CanModifyID { set; }
  }
}

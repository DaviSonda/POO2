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
    void LimpaGrade();
    void AdicionaUsuarioGrade(Usuario usuario);
    void AtualizaGradeComUsuarioModificado(Usuario usuario);
    void RemoveUsuarioDaGrade(Usuario usuario);
    string GetIdUsuarioSelecionadoNaGrade();
    void SetUsuarioSelecionadoGrade(Usuario usuario);

    string Nome { get; set; }
    string Sobrenome { get; set; }
    string ID { get; set; }
    string Departamento { get; set; }
    Usuario.SexoPessoa Sexo { get; set; }
    bool PodeModificarId { set; }
  }
}

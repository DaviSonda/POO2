using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
  public class Usuario
  {
    private string id;
    private string nome;
    private string sobrenome;
    private string departamento;
    private SexoPessoa sexo;

    public Usuario(string _nome, string _sobrenome, string _id, string _depto, SexoPessoa _sexo)
    {
      nome = _nome;
      sobrenome = _sobrenome;
      id = _id;
      departamento = _depto;
      sexo = _sexo;
    }
    public string Nome
    {
      get { return nome; }
      set
      {
        nome = value;
      }
    }
    public enum SexoPessoa
    {
      Masculino = 1,
      Feminino = 2
    }
    public string Sobrenome
    {
      get { return sobrenome; }
      set
      {
        sobrenome = value;
      }
    }
    public string ID
    {
      get { return id; }
      set
      {
        id = value;
      }
    }
    public string Departamento
    {
      get { return departamento; }
      set { departamento = value; }
    }
    public SexoPessoa Sexo
    {
      get { return sexo; }
      set { sexo = value; }
    }
  }
}


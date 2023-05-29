using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
  public class Usuario
  {
    public Usuario(string nome, string sobrenome, string id, string depto, SexoPessoa sexo)
    {
      Nome = nome;
      Sobrenome = sobrenome;
      ID = id;
      Departamento = depto;
      Sexo = sexo;
    }
    public enum SexoPessoa
    {
      Masculino = 1,
      Feminino = 2
    }

    private string _Nome;
    public string Nome
    {
      get { return _Nome; }
      set
      {
        if (value.Length > 50)
          Console.WriteLine("Erro! Nome deve ter menos de 51 caracteres!");
        else
          _Nome = value;
      }
    }

    private string _Sobrenome;
    public string Sobrenome
    {
      get { return _Sobrenome; }
      set
      {
        if (value.Length > 50)
          Console.WriteLine("Erro! Sobrenome deve ter menos de 51 caracteres!");
        else
          _Sobrenome = value;
      }
    }

    private string _ID;
    public string ID
    {
      get { return _ID; }
      set
      {
        if (value.Length > 9)
          Console.WriteLine("Erro! ID deve ter menos de 10 caracteres!");
        else
          _ID = value;
      }
    }

    private string _Departamento;
    public string Departamento
    {
      get { return _Departamento; }
      set { _Departamento = value; }
    }

    private SexoPessoa _Sexo;
    public SexoPessoa Sexo
    {
      get { return _Sexo; }
      set { _Sexo = value; }
    }
  }
}


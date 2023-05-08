using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Pessoa
  {
    private string nome;
    private int idade;
    public Pessoa()
    {
      nome = "";
      idade = 0;
    }
    public Pessoa(string _nome, int _idade)
    {
      nome = _nome;
      idade = _idade;
    }
    public string Nome {
      get { return nome; }
      set { nome = value; }
    }
    public int Idade {
      get { return idade; }
      set { idade = value; }
    }

    public override string ToString()
    {
      return nome + ", " + idade;
    }
  }
}

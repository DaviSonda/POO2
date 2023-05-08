using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Aluno
  {
    private int matricula;
    private string nome;
    private string cidade;
    private string curso;

    public Aluno()
    {
      matricula = 0;
      nome = "";
      cidade = "";
      curso = "";
    }
    public Aluno(int matricula, string nome, string cidade, string curso)
    {
      this.matricula = matricula;
      this.nome = nome;
      this.cidade = cidade;
      this.curso = curso;
    }
    public int Matricula
    {
      get { return matricula; }
      set { matricula = value; }
    }
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }
    public string Cidade
    {
      get { return cidade; }
      set { cidade = value; }
    }
    public string Curso
    {
      get { return curso; }
      set { curso = value; }
    }
    public override string ToString()
    {
      string res = "[" + matricula + "," + nome + "," + cidade + "," + curso + "]";
      return res;
    }
  }
}

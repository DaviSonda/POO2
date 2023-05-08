using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Exemplo05
  {
    IList<Aluno> lista;
    public Exemplo05()
    {
      lista = new List<Aluno>{
          new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "TADS"),
          new Aluno(456, "Elisa da Silva", "Farroupilha", "TADS"),
          new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"),
          new Aluno(777, "Gabriela Machado", "Caxias do Sul", "TADS"),
          new Aluno(888, "Marina Viola", "Flores da Cunha", "Computação"),
          new Aluno(999, "Luciana Veira", "Flores da Cunha", "Computação"),
          new Aluno(722, "Jorge Luiz", "Caxias do Sul", "TADS"),
          new Aluno(833, "Sandra Regina", "Flores da Cunha", "Computação")
      };
    }
    public void ConsultaCurso(string _curso)
    {
      var consulta = from aluno in lista
                     where aluno.Curso.Equals(_curso)
                     select aluno;

      foreach (Aluno aluno in consulta)
      {
        Console.WriteLine(aluno.ToString());
      }
    }

    public void ConsultaCursoCidade(string _curso, string _cidade)
    {
      var consulta = from aluno in lista
                     where aluno.Curso.Equals(_curso) && aluno.Cidade.Equals(_cidade)
                     orderby aluno.Nome ascending
                     select aluno;

      foreach (Aluno aluno in consulta)
      {
        Console.WriteLine(aluno.ToString());
      }
    }

    public void ConsultaGrupoCidade()
    {
      var consulta = from aluno in lista
                     group aluno by aluno.Cidade;

      foreach (var cidadeGrupo in consulta)
      {
        Console.WriteLine(cidadeGrupo.Key);
        foreach (Aluno aluno in cidadeGrupo)
        {
          Console.WriteLine(" {0} {1}", aluno.Nome, aluno.Curso);
        }
        Console.WriteLine();
      }
    }
    public void ConsultaGrupoAlunos()
    {
      var consulta = from aluno in lista
                     group aluno by aluno.Curso into grupoAlunos
                     orderby grupoAlunos.Key
                     select grupoAlunos;

      foreach (var cursoGrupo in consulta)
      {
        Console.WriteLine(cursoGrupo.Key);
        foreach (Aluno aluno in cursoGrupo)
        {
          Console.WriteLine(" {0} {1}", aluno.Nome, aluno.Cidade);
        }
        Console.WriteLine();
      }
    }

    public void ConsultaAlunosCentro()
    {
      IList<Centros> centros = new List<Centros>();
      centros.Add(new Centros("CCET 1", "Computação"));
      centros.Add(new Centros("CCET 2", "TADS"));
      

      var join = from aluno in lista
                 join centro in centros on aluno.Curso equals centro.Curso
                 orderby centro.Centro
                 select new { NomeAluno = aluno.Nome, NomeCentro = centro.Centro, NomeCurso = aluno.Curso };

      foreach (var item in join)
      {
        Console.WriteLine("{0} {1}", item.NomeAluno, item.NomeCentro);
      }
    }
  }
}

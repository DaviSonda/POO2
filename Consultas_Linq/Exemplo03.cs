using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Exemplo03
  {
    IList<Pessoa> pessoas;
    public Exemplo03()
    {
     pessoas = new List<Pessoa> {
                                  new Pessoa("João", 30),
                                  new Pessoa("Maria", 25),
                                  new Pessoa("Pedro", 35),
                                  new Pessoa("Ana",20)
              };
    }
    public void Consulta(){
      var resultado = from pessoa in pessoas
                      where pessoa.Idade > 25
                      orderby pessoa.Nome
                      select pessoa;

      foreach(var item in resultado)
      {
        Console.WriteLine(item.ToString());
      }
    }
    public void ConsultaMaior(int _maior)
    {
      List<Pessoa> pessoasMaisIdade = pessoas.Where(p => p.Idade > _maior).ToList();
      
      foreach (var item in pessoasMaisIdade)
      {
        Console.WriteLine(item.ToString());
      }
    }
  }
}

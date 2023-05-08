using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Exemplo02
  {
    List<string> palavras;
    public Exemplo02()
    {
      palavras = new List<string> { "banana", "maçã", "abacaxi", "laranja" };
      
    }
    public void Consulta()
    {
      var resultado = from palavra in palavras
                      orderby palavra
                      select palavra;

      foreach(var item in resultado )
      {
        Console.WriteLine(item);
      }
    }

    public void ConsultaCrescente()
    {
      palavras.Sort((a, b) => a.CompareTo(b));
      foreach (var item in palavras)
      {
        Console.WriteLine(item);
      }
    }
    public void ConsultaDecrescente()
    {
      palavras.Sort((a, b) => b.CompareTo(a));
      foreach (var item in palavras)
      {
        Console.WriteLine(item);
      }
    }

    public void ConsultaPalavra(string _palavra)
    {
      bool contemPal = palavras.Any(pal => pal == _palavra);
      
      if(contemPal == true)
      {
        Console.WriteLine("Lista contém a palavra {0}",_palavra);
      }
      else
      {
        Console.WriteLine("Lista não contém a palavra {0}", _palavra);
      }
    }
  }
}

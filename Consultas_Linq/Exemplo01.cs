using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Exemplo01
  {
    List<int> numeros;
    public Exemplo01()
    {
      numeros = new List<int> { 2, 4, 6, 8, 10 };
    }

    public void Consulta(int num)
    {
      var resultado = from numero in numeros
                      where numero > num
                      select numero;

      foreach(var res in resultado)
      {
        Console.WriteLine(res);
      }
    }
   
    public void ConsultaPares()
    {
      List<int> pares = numeros.Where(n => n % 2 == 0).ToList();
      foreach (var res in pares)
      {
        Console.WriteLine(res);
      }
    }

    public void ConsultaNumeros(int num)
    {
      List<int> resultado = numeros.Where(n => n > num).ToList();
      foreach (var res in resultado)
      {
        Console.WriteLine(res);
      }
    }

    public void ConsultaMultiplicados(int _mult)
    { 
      List<int> numerosMultiplicados = numeros.Select(n => n * _mult).ToList();
      foreach (var res in numerosMultiplicados)
      {
        Console.WriteLine(res);
      }
    }
    public void ConsultaMedia()
    {
      double media = numeros.Average(n => n);
      foreach (var res in numeros)
      {
        Console.WriteLine(res);
      }
      Console.WriteLine("Media= {0}", media);
    }

  }
}

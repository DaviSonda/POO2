using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Exemplo04
  {
    IList<Produto> produtos;

    public Exemplo04()
    {
       produtos = new List<Produto> {
              new Produto("Arroz", 3.50m, "Alimentos"),
              new Produto("Feijão", 5.00m, "Alimentos"),
              new Produto("Camisa", 29.90m, "Vestuário"),
              new Produto("Calça",59.90m,"Vestuário")
          };
    }
    public void Consulta()
    {
      var produtosPorCategoria = from produto in produtos
                                 group produto by produto.Categoria into grupo
                                 select new
                                 {
                                   Categoria = grupo.Key,
                                   Produtos = grupo.ToList()
                                 };

      foreach (var grupo in produtosPorCategoria)
      {
        Console.WriteLine(grupo.Categoria);
        foreach (var produto in grupo.Produtos)
        {
          Console.WriteLine($"\t{produto.Descricao} - R$ {produto.Preco}");
        }
      }

    }
  }
}

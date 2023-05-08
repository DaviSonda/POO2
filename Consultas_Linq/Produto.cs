using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class Produto:IEnumerable<Produto>
  {
    private string descricao;
    private decimal preco;
    private string categoria;
    public Produto() {
      descricao = "";
      preco = 0;
      categoria = "";
    }
    public Produto(string _descricao, decimal _preco, string _categoria)
    {
      descricao = _descricao;
      preco = _preco;
      categoria = _categoria;
    }
    public string Descricao {
      get { return descricao; }
      set { descricao = value; }
    }

    public decimal Preco
    {
      get { return preco; }
      set { preco = value; }
    }
    public string Categoria
    {
      get { return categoria; }
      set { categoria = value; }
    }

    public IEnumerator<Produto> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      return descricao + ", " + categoria + "," + preco;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
  }
}

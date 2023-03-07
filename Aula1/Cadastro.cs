using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Cadastro
    {
        public Produto[] produtos;
        public Cadastro() {
            produtos = new Produto[10];
        }
        
        public Produto IncluiDados(Produto p)
        {
            produtos.Append(p);
            return p;
        }
    }
}

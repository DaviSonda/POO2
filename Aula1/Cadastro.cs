using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Cadastro
    {
        private Produto[] produtos;
        private int pos = 0;
        private const int TAM = 5;

        public Cadastro()
        {
            produtos = new Produto[10];
        }

        public void InsereDados(int cod, string desc, double valor)
        {
            if (pos < TAM)
            {
                Produto p = new Produto(cod, desc, valor);
                produtos[pos] = p;
                pos++;
            }
        }
        public void InsereDados(Produto p)
        {
            if (pos < TAM)
            {
                produtos[pos] = p;
                pos++;
            }
        }

        public int Tamanho() { return pos; }

        public Produto GetProduto(int posicao)
        {
            Produto p = null;
            if (posicao >= 0 && posicao < pos)
            {
                p = produtos[posicao];
            }
            return p;
        }
    }
}

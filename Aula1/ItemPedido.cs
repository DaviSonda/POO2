using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class ItemPedido
    {
        private Produto produto;
        private int quantidade;
        public ItemPedido() {
            this.produto = new Produto();
            this.quantidade = 0;
        }

        public ItemPedido(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }
        public ItemPedido(int cod, string descricao, double valor, int quantidade)
        {
            this.produto = new Produto
            {
                Codigo = cod,
                Descricao = descricao,
                Valor = valor,
            };
            this.quantidade = quantidade;
        }

        public Produto Produto { get { return produto; } set { produto = value; } }
        public int Quantidade { get { return quantidade; } set { quantidade = value; } }

        public override string ToString()
        {
            return "\nProduto: " + produto.ToString() + "\n\nQuantidade: " + quantidade;
        }

        public double ValorTotal()
        {
            return produto.Valor * quantidade;
        }
    }
}

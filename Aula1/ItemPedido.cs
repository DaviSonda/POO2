using Aula1.Enums;
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
        private Data data = new Data();
        public ItemPedido()
        {
            this.produto = new Produto();
            this.quantidade = 0;
        }

        public ItemPedido(Produto produto, int quantidade)
        {
            if (produto.GetType() == typeof(ProdutoAlimentar))
            {
                ProdutoAlimentar pa = produto as ProdutoAlimentar;
                ValidadeEnum validade = data.ValidadeData(pa.DataValidade);
                produto = VerificarValidade(validade, pa);
            }
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
            return "\nProduto: \n" + produto.ToString() + "\n\nQuantidade: " + quantidade;
        }

        public double ValorTotal()
        {
            return produto.Valor * quantidade;
        }

        private ProdutoAlimentar VerificarValidade(ValidadeEnum val, ProdutoAlimentar prod)
        {
            switch (val)
            {
                case ValidadeEnum.Vencido:
                    throw new Exception("\nVocê não pode adicionar um produto fora de validade ao pedido");
                case ValidadeEnum.VenceEmBreve:
                    Console.WriteLine("\nProduto adicionado com 30% de desconto por estar perto do prazo de validade");
                    prod.Valor = prod.Reajuste(OperacaoEnum.Remover, 30);
                    return prod;
                case ValidadeEnum.Ok:
                    return prod;
                default:
                    return prod;
            }
        }
    }
}

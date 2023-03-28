using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Pedido
    {
        private List<ItemPedido> itens;
        private EntradaDados entrada;

        public Pedido()
        {
            itens = new List<ItemPedido>();
            entrada = new EntradaDados();
        }

        public void InsereItem(ItemPedido item)
        {
            itens.Add(item);
        }

        public int Tamanho()
        {
            return itens.Count;
        }

        public ItemPedido GetItemPedido(int pos)
        {
            ItemPedido itemPed = null;
            if ((pos >= 0) && (pos < itens.Count))
            {
                itemPed = itens.ElementAt(pos);
            }
            return itemPed;
        }

        public void RemoverProduto(int codigo)
        {
            ItemPedido remover = null;
            itens.ForEach(it =>
            {
                if (it.Produto.Codigo == codigo)
                {
                    remover = it;
                }
            });
            if (remover != null)
            {
                itens.Remove(remover);
                Console.WriteLine("\nProduto: " + codigo + " deletado do pedido com sucesso");
            } else
            {
                NotFound();
            }
        }

        public void AlterarQuantidadeProduto(int codigo)
        {
            ItemPedido alterar = null;
            itens.ForEach(it =>
            {
                if (it.Produto.Codigo == codigo)
                {
                    alterar = it;
                }
            });
            if (alterar != null)
            {
                alterar.Quantidade = entrada.LeInteiro("Digite a nova quantidade desse produto no pedido");
                Console.WriteLine("\nProduto: " + codigo + " deletado do pedido com sucesso");
            }
            else
            {
                NotFound();
            }
        }

        public void InformaValorTotal()
        {
            double valorTotal = 0;
            itens.ForEach(it =>
            {
                valorTotal += it.Produto.Valor * it.Quantidade;
            });
            Console.WriteLine("\nO valor total do pedido é: " + valorTotal);
        }

        public void NotFound()
        {
            Console.WriteLine("\nNão foi encontrado nenhum produto com esse código no pedido");
        }
    }
}

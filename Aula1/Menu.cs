using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Menu
    {
        EntradaDados entrada;
        Produto p;
        Cadastro cad;
        double media;
        Pedido pedido;
        ItemPedido itemPedido;
        public Menu()
        {
            entrada = new EntradaDados();
            cad = new Cadastro();
            pedido = new Pedido();
        }

        private void Opcoes()
        {
            Console.WriteLine("\n1 - Inserir dados");
            Console.WriteLine("\n2 - Escrever dados");
            Console.WriteLine("\n3 - Escrever média de valores");
            Console.WriteLine("\n4 - Aumentar valores acima da média");
            Console.WriteLine("\n5 - Ordenar pela descrição");
            Console.WriteLine("\n6 - Listar produtos abaixo da média");
            Console.WriteLine("\n7 - Excluir produto");
            Console.WriteLine("\n8 - Editar produto");
            Console.WriteLine("\n9 - Insere item no pedido");
            Console.WriteLine("\n10 - Lista pedido");
            Console.WriteLine("\n11 - Deletar produto do pedido");
            Console.WriteLine("\n12 - Alterar quantidade de produto no pedido");
            Console.WriteLine("\n13 - Listar valor total do pedido");
            Console.WriteLine("\n0 - Sair");
        }

        private int MostraOpcoes()
        {
            Opcoes();
            return entrada.LeInteiro("\nInforme a sua opção:");
        }

        public void MenuOpcoes()
        {
            int opc = MostraOpcoes();

            while (opc != 0)
            {
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        LeProduto();
                        break;
                    case 2:
                        EscreveDados();
                        break;
                    case 3:
                        EscreveMedia();
                        break;
                    case 4:
                        IncrementaValoresAcimaDaMedia();
                        break;
                    case 5:
                        cad.OrdenaProdutosAlfabeticamente();
                        break;
                    case 6:
                        EscreveProdutosAbaixoDaMedia();
                        break;
                    case 7:
                        ExcluiProduto();
                        break;
                    case 8:
                        EditarProduto();
                        break;
                    case 9:
                        LeItemPedido();
                        break;
                    case 10:
                        ImprimePedido();
                        break;
                    case 11:
                        DeletarProdutoPedido();
                        break;
                    case 12:
                        AlteraQuantidadeProdutoPedido();
                        break;
                    case 13:
                        ValorTotalPedido();
                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida");
                        break;
                }
                opc = MostraOpcoes();
            }

        }

        private void AlteraQuantidadeProdutoPedido()
        {
            pedido.AlterarQuantidadeProduto(entrada.LeInteiro("Digite o código do produto a ser alterado no pedido"));
        }

        private void ValorTotalPedido()
        {
            pedido.InformaValorTotal();
        }
        
        private void DeletarProdutoPedido()
        {
            pedido.RemoverProduto(entrada.LeInteiro("Digite o código do produto a ser retirado do pedido"));
        }
        private void EditarProduto()
        {
            cad.EditarProduto(entrada.LeInteiro("Digite o código do produto a ser editado"));
        }
        private void ExcluiProduto()
        {
            cad.ExcluiProduto(entrada.LeInteiro("Digite o código do produto a ser excluído"));
        }

        private void LeProduto()
        {
            p = new Produto
            {
                Codigo = entrada.LeInteiro("Digite o código do produto:"),
                Descricao = entrada.LeString("Digite o nome do produto:"),
                Valor = entrada.LeDouble("Digite o valor do produto:")
            };
            cad.InsereDados(p);
        }

        private void EscreveDados()
        {
            for (int i = 0; i < cad.Tamanho(); i++)
            {
                Console.WriteLine("\n" + cad.GetProduto(i).ToString());
            }

        }

        private void EscreveMedia()
        {
            if(cad.Tamanho() <= 0)
            {
                Console.WriteLine("\nDeve existir valores para ser gerada uma média");
                return;
            }
            Console.WriteLine("\nA média de valor dos produtos é: " + MediaValoresProdutos());
        }

        private double MediaValoresProdutos()
        {
            int tam = cad.Tamanho();
            double total = 0;
            for (int i = 0; i < tam; i++)
            {
                total += cad.GetProduto(i).Valor;
            }
            media = total / tam;
            return media;
        }

        private void IncrementaValoresAcimaDaMedia()
        {
            MediaValoresProdutos();
            double porcentagem = entrada.LeDouble("Digite a porcentagem para reajuste: ");
            for (int i = 0; i < cad.Tamanho(); i++)
            {
                Produto p = cad.GetProduto(i);
                if(p.Valor >= media)
                {
                    p.Reajuste(OperacaoEnum.Adicionar, porcentagem);
                }
            }
        }

        private void EscreveProdutosAbaixoDaMedia()
        {
            MediaValoresProdutos();
            for (int i = 0; i < cad.Tamanho(); i++)
            {
                Produto p = cad.GetProduto(i);
                if (p.Valor < media)
                {
                    Console.WriteLine("\n" + p.ToString());
                }
            }

        }

        private void LeItemPedido()
        {
            int codigo = entrada.LeInteiro("Informe o código do produto:");
            Produto p = cad.GetProdutoByCodigo(codigo);
            int qtde = 0;

            if (p == null)
            {
                Console.WriteLine("\nCódigo não encontrado no cadastro de produtos");
            }
            else
            {
                qtde = entrada.LeInteiro("Informe a quantidade itens:");
                itemPedido = new ItemPedido(p, qtde);
                pedido.InsereItem(itemPedido);
            }
        }
        private void ImprimePedido()
        {
            for (int i = 0; i < pedido.Tamanho(); i++)
            {
                Console.WriteLine(pedido.GetItemPedido(i).ToString());
            }
        }
    }
}

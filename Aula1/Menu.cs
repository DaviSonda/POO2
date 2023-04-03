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
        ProdutoDigital pd;
        ProdutoAlimentar pa;
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
            Console.WriteLine("\n1 - Inserir produto digital");
            Console.WriteLine("\n2 - Inserir produto alimentar");
            Console.WriteLine("\n3 - Escrever dados");
            Console.WriteLine("\n4 - Escrever média de valores");
            Console.WriteLine("\n5 - Aumentar valores acima da média");
            Console.WriteLine("\n6 - Ordenar pela descrição");
            Console.WriteLine("\n7 - Listar produtos abaixo da média");
            Console.WriteLine("\n8 - Excluir produto");
            Console.WriteLine("\n9 - Editar produto");
            Console.WriteLine("\n10 - Insere item no pedido");
            Console.WriteLine("\n11 - Lista pedido");
            Console.WriteLine("\n12 - Deletar produto do pedido");
            Console.WriteLine("\n13 - Alterar quantidade de produto no pedido");
            Console.WriteLine("\n14 - Listar valor total do pedido");
            Console.WriteLine("\n15 - Inserir data e validar");
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
                        LeProdutoDigital();
                        break;
                    case 2:
                        LeProdutoAlimentar();
                        break;
                    case 3:
                        EscreveDados();
                        break;
                    case 4:
                        EscreveMedia();
                        break;
                    case 5:
                        IncrementaValoresAcimaDaMedia();
                        break;
                    case 6:
                        cad.OrdenaProdutosAlfabeticamente();
                        break;
                    case 7:
                        EscreveProdutosAbaixoDaMedia();
                        break;
                    case 8:
                        ExcluiProduto();
                        break;
                    case 9:
                        EditarProduto();
                        break;
                    case 10:
                        LeItemPedido();
                        break;
                    case 11:
                        ImprimePedido();
                        break;
                    case 12:
                        DeletarProdutoPedido();
                        break;
                    case 13:
                        AlteraQuantidadeProdutoPedido();
                        break;
                    case 14:
                        ValorTotalPedido();
                        break;
                    case 15:
                        ArmazenaValidaData();
                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida");
                        break;
                }
                opc = MostraOpcoes();
            }

        }

        private void ArmazenaValidaData()
        {

            Data d = new Data(entrada.LeInteiro("Digite o dia"),
                entrada.LeInteiro("Digite o mês"),
                entrada.LeInteiro("Digite o ano")
            );
            Console.WriteLine(d.ToString());
            Boolean b = d.DataValida(d);
            if (b)
            {
                Console.WriteLine("\nData válida");
            }
            else
            {
                Console.WriteLine("\nData inválida");
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

        private void LeProdutoDigital()
        {
            pd = new ProdutoDigital
            {
                TamanhoArquivo = entrada.LeInteiro("Digite o tamanho do arquivo"),
                VersaoProduto = entrada.LeInteiro("Digite a versão do produto"),
                Codigo = entrada.LeInteiro("Digite o código do produto:"),
                Descricao = entrada.LeString("Digite o nome do produto:"),
                Valor = entrada.LeDouble("Digite o valor do produto:"),

            };
            cad.InsereDados(pd);
        }

        private void LeProdutoAlimentar()
        {
            pa = new ProdutoAlimentar
            {
                DataFabricacao = entrada.LeInteiro("Digite o tamanho do arquivo"),
                DataValidade = entrada.LeInteiro("Digite o tamanho do arquivo"),
                Codigo = entrada.LeInteiro("Digite o código do produto:"),
                Descricao = entrada.LeString("Digite o nome do produto:"),
                Valor = entrada.LeDouble("Digite o valor do produto:"),

            };
            cad.InsereDados(pd);
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
            if (cad.Tamanho() <= 0)
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
                if (p.Valor >= media)
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

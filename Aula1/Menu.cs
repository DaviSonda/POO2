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
        public Menu()
        {
            entrada = new EntradaDados();
            cad = new Cadastro();
        }

        private void Opcoes()
        {
            Console.WriteLine("\n1 - Inserir dados");
            Console.WriteLine("\n2 - Escrever dados");
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
                    default:
                        Console.WriteLine("\nOpção Inválida");
                        break;
                }
                opc = MostraOpcoes();
            }

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
    }
}

using Imc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class Menu
    {
        EntradaDados entrada;
        Cadastro cad;
        public Menu()
        {
            entrada = new EntradaDados();
            cad = new Cadastro();
        }

        private void Opcoes()
        {
            Console.WriteLine("\n1 - Inserir polinomio");
            Console.WriteLine("\n2 - Listar polinomio");
            Console.WriteLine("\n3 - Buscar polinomio por nome");
            Console.WriteLine("\n4 - Somar dois polinomios");
            Console.WriteLine("\n5 - Calcula polinomio");
            Console.WriteLine("\n0 - Sair");
        }

        public void MenuOpcoes()
        {
            Opcoes();
            int opc = entrada.LeInteiro("\nInforme a sua opção:");
            switch (opc)
            {
                case 0:
                    break;
                case 1:
                    InserePolinomio();
                    break;
                case 2:
                    ImprimePolinomios(null);
                    break;
                case 3:
                    ImprimePolinomios(entrada.LeString("\nNome do polinomio"));
                    break;
                case 4:
                    CalculaPolinomios(entrada.LeString("\nNome do primeiro polinomio"), entrada.LeString("\nNome do segundo polinomio"));
                    break;
                case 5:
                    CalculaPolinomio(entrada.LeInteiro("\nValor de x"));
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida");
                    break;
            }
            if (opc != 0)
            {
                MenuOpcoes();
            }
        }

        private void InserePolinomio()
        {
        }

        private void ImprimePolinomios(string nome)
        {
            cad.ImprimePolinomios(nome);
        }

        private void CalculaPolinomios(string n1, string n2)
        {
            cad.FiltraSituacaoIdade(situacao, idade);
        }

        private void CalculaPolinomio(int valor)
        {
            cad.FiltraSituacaoIdade(situacao, idade);
        }
    }
}
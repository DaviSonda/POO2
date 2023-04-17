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
        public Menu()
        {
            entrada = new EntradaDados();
        }

        private void Opcoes()
        {
            Console.WriteLine("\n1 - Inserir atleta");
            Console.WriteLine("\n2 - Excluir atleta");
            Console.WriteLine("\n3 - Listar atletas");
            Console.WriteLine("\n4 - Buscar atleta por nome");
            Console.WriteLine("\n5 - Filtrar por situação e idade mínima");
            Console.WriteLine("\n6 - Excluir por situação");
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
                    InsereAtleta();
                    break;
                case 2:
                    ExcluiAtleta(entrada.LeString("\nNome do atleta"));
                    break;
                case 3:
                    ImprimeAtletas(null);
                    break;
                case 4:
                    ImprimeAtletas(entrada.LeString("\nNome do atleta"));
                    break;
                case 5:
                    FiltraAtletas(entrada.LeString("\nSituação do atleta"), entrada.LeInteiro("\nIdade do atleta"));
                    break;
                case 6:
                    ExcluiAtleta(entrada.LeString("\nSituação do atleta"));
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

        private void InsereAtleta()
        {

        }

        private void ExcluiAtleta(string filtro)
        {
        }

        private void ImprimeAtletas(string nome)
        {
        }

        private void FiltraAtletas(string situacao, int idade)
        {

        }
    }
}

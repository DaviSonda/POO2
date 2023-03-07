using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        Produto p;
        EntradaDados entradaDados;

        public Program()
        {
            entradaDados = new EntradaDados();
            p = new Produto
            {
                Codigo = entradaDados.LeInteiro("Digite o código do produto:"),
                Descricao = entradaDados.LeString("Digite o nome do produto:"),
                Valor = entradaDados.LeDouble("Digite o valor do produto:")
            };
            var c = new Cadastro();
            c.IncluiDados(p);
            Console.WriteLine("\nPré Reajuste: " + p.ToString());
            p.Reajuste(OperacaoEnum.Adicionar, 40);
            Console.WriteLine("\nPós Reajuste: " + p.ToString());
            p.Reajuste(OperacaoEnum.Remover, 50);
            Console.WriteLine("\nPós Segundo Reajuste: " + p.ToString());

        }

        static void Main(string[] args)
        {
            Program tst = new Program();
            Console.ReadLine();
        }
    }
}

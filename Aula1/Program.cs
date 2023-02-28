using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto(1, "teste", 7.5);
            Console.WriteLine("\nPré Reajuste: " + prod.Valor);
            prod.Reajuste(40);
            Console.WriteLine("\nPós Reajuste: " + prod.Valor);
        }
    }
}

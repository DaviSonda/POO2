using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
  class Program
  {
    Colecoes colecoes;
    public Program()
    {
      colecoes = new Colecoes();
      Menu();
    }
    private void OpcoesMenu()
    {
      Console.WriteLine();
      Console.WriteLine("A- Dictionary");
      Console.WriteLine("B- SortedDictionary");
      Console.WriteLine("C- SortedList");
      Console.WriteLine("D- List");
      Console.WriteLine("E- LinkedList");
      Console.WriteLine("F- HashSet");
      Console.WriteLine("T- SortedSet");
      Console.WriteLine("G- Stack");
      Console.WriteLine("H- Queue");
      Console.WriteLine("I- Ordena a Lista por Nome");
      Console.WriteLine("J- Ordena a Lista por Curso");
      Console.WriteLine("K- Consulta a Lista");
      Console.WriteLine("L- Consulta a Lista");
      Console.WriteLine("M- Consulta a Lista");
      Console.WriteLine("N- Consulta a Lista");
      Console.WriteLine("O- Consulta a Lista");
      Console.WriteLine("S- Sair");
      Console.WriteLine("\nSua Opção: ");
    }
    private void Menu()
    {

      OpcoesMenu();
       var opc = Console.ReadKey().Key;
        while (opc != ConsoleKey.S)
        {
                switch (opc)
                {
                    case ConsoleKey.A:
                        colecoes.Dicionario();
                        break;
                    case ConsoleKey.B:
                        colecoes.SortedDicionario();
                        break;
                    case ConsoleKey.C:
                        colecoes.SortedLista();
                        break;
                    case ConsoleKey.D:
                        colecoes.Lista();
                        break;
                    case ConsoleKey.E:
                        colecoes.ListaLigada();
                        break;
                    case ConsoleKey.F:
                        colecoes.HashSet();
                        break;
                    case ConsoleKey.T:
                        colecoes.SortedSet();
                        break;
                    case ConsoleKey.G:
                        colecoes.Pilha();
                        break;
                    case ConsoleKey.H:
                        colecoes.Fila();
                        break;
                    case ConsoleKey.I:
                        colecoes.OrdenaLista();
                        break;
                    case ConsoleKey.J:
                        colecoes.OrdenaListaCurso();
                        break;
                    case ConsoleKey.K:
                        colecoes.ConsultaLista();
                        break;
                    case ConsoleKey.L:
                        colecoes.ConsultaLista2();
                        break;
                    case ConsoleKey.M:
                        colecoes.ConsultaLista3();
                        break;
                    case ConsoleKey.N:
                        colecoes.ConsultaLista4();
                        break;
                    case ConsoleKey.O:
                        colecoes.ConsultaLista5();
                        break;
                }
                OpcoesMenu();
                opc = Console.ReadKey().Key;
       }
      }
        static void Main(string[] args)
        {
            Program teste = new Program();
        }
    }
}

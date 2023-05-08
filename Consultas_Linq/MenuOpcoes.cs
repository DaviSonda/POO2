using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Linq
{
  public class MenuOpcoes
  {
    public MenuOpcoes()
    {
      Menu();
    }

    private void OpcoesMenu()
    {
      Console.WriteLine();
      Console.WriteLine("A - Números maiores que 5");
      Console.WriteLine("B - Ordenação de lista de palavras");
      Console.WriteLine("C - Filtrar e ordenar uma lista de pessoa");
      Console.WriteLine("D - Filtar e agrupar produtos");
      Console.WriteLine("E - Filtrar por curso");
      Console.WriteLine("F - Filtrar por curso e cidade");
      Console.WriteLine("G - Agrupar por cidade");
      Console.WriteLine("H - Agrupar por curso");
      Console.WriteLine("I - Agrupar por centro");
      Console.WriteLine("******************************************");
      Console.WriteLine("J - Lambda - Números maiores que 5");
      Console.WriteLine("K - Lambda - Números pares");
      Console.WriteLine("L - Lambda - Ordenação crescente de palavras");
      Console.WriteLine("M - Lambda - Ordenação decrescente de palavras");
      Console.WriteLine("N - Lambda - Números multiplicados por 5");
      Console.WriteLine("O - Lambda - Média dos números");
      Console.WriteLine("P - Lambda - Consulta uma palavra");
      Console.WriteLine("Q - Lambda - Pessoas com mais de 30 anos");

      Console.WriteLine("S - Sair");
      Console.WriteLine("\nSua Opção: ");
    }
    private void Menu()
    {

      OpcoesMenu();
      var opc = Console.ReadKey().Key;
      Console.WriteLine("\n");
      while (opc != ConsoleKey.S)
      {
        switch (opc)
        {
          case ConsoleKey.A:
            Exemplo01 ex01 = new Exemplo01();
            ex01.Consulta(5);
            break;
          case ConsoleKey.B:
            Exemplo02 ex02 = new Exemplo02();
            ex02.Consulta();
            break;
          case ConsoleKey.C:
            Exemplo03 ex03 = new Exemplo03();
            ex03.Consulta();
            break;
          case ConsoleKey.D:
            Exemplo04 ex04 = new Exemplo04();
            ex04.Consulta();
            break;
          case ConsoleKey.E:
            Exemplo05 ex051 = new Exemplo05();
            ex051.ConsultaCurso("Computação");
            break;
          case ConsoleKey.F:
            Exemplo05 ex052 = new Exemplo05();
            ex052.ConsultaCursoCidade("Computação","Flores da Cunha");
            break;
          case ConsoleKey.G:
            Exemplo05 ex053 = new Exemplo05();
            ex053.ConsultaGrupoCidade();
            break;
          case ConsoleKey.H:
            Exemplo05 ex054 = new Exemplo05();
            ex054.ConsultaGrupoAlunos();
            break;
          case ConsoleKey.I:
            Exemplo05 ex055 = new Exemplo05();
            ex055.ConsultaAlunosCentro();
            break;
          case ConsoleKey.J:
            Exemplo01 ex011 = new Exemplo01();
            ex011.ConsultaNumeros(5);
            break;
          case ConsoleKey.K:
            Exemplo01 ex012 = new Exemplo01();
            ex012.ConsultaPares();
            break;
          case ConsoleKey.L:
            Exemplo02 ex022 = new Exemplo02();
            ex022.ConsultaCrescente();
            break;
          case ConsoleKey.M:
            Exemplo02 ex023 = new Exemplo02();
            ex023.ConsultaDecrescente();
            break;
          case ConsoleKey.N:
            Exemplo01 ex014 = new Exemplo01();
            ex014.ConsultaMultiplicados(5);
            break;
          case ConsoleKey.O:
            Exemplo01 ex015 = new Exemplo01();
            ex015.ConsultaMedia();
            break;
          case ConsoleKey.P:
            Exemplo02 ex024 = new Exemplo02();
            ex024.ConsultaPalavra("banana");
            break;
          case ConsoleKey.Q:
            Exemplo03 ex031 = new Exemplo03();
            ex031.ConsultaMaior(30);
            break;
        }
        OpcoesMenu();
        opc = Console.ReadKey().Key;
        Console.WriteLine("\n");
      }
    }
  }
}

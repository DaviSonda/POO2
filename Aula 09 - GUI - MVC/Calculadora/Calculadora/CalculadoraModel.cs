using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
  public class CalculadoraModel
  {
    private int resultado;
    public void Soma(int num1, int num2)
    {
      resultado = num1 + num2;
    }
    public void Subtracao(int num1, int num2)
    {
      resultado = num1 - num2;
    }
    public void Multiplicacao(int num1, int num2)
    {
      resultado = num1 * num2;
    }
    public void Divisao(int num1, int num2)
    {
      resultado = num1 / num2;
    }
    public int Resultado()
    {
      return resultado;
    }
  }
}

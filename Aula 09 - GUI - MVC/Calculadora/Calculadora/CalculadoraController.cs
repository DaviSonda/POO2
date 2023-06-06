using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
  public class CalculadoraController
  {
    ICalculadoraView calculadoraView;
    CalculadoraModel calculadoraModel;
    public CalculadoraController(ICalculadoraView _calculadoraView, CalculadoraModel _calculadoraModel)
    {
      calculadoraView = _calculadoraView;
      calculadoraModel = _calculadoraModel;
      calculadoraView.SetController(this);
    }

    public void Soma()
    {
      int resultado = 0;
      int valor1 = int.Parse(calculadoraView.Valor1);
      int valor2 = int.Parse(calculadoraView.Valor2);
      this.calculadoraModel.Soma(valor1, valor2);
      resultado = this.calculadoraModel.Resultado();
      calculadoraView.Resultado = resultado.ToString();
    }
    public void Subtracao()
    {
      int resultado = 0;
      int valor1 = int.Parse(calculadoraView.Valor1);
      int valor2 = int.Parse(calculadoraView.Valor2);
      this.calculadoraModel.Subtracao(valor1, valor2);
      resultado = this.calculadoraModel.Resultado();
      calculadoraView.Resultado = resultado.ToString();
    }
    public void Multiplicacao()
    {
      int resultado = 0;
      int valor1 = int.Parse(calculadoraView.Valor1);
      int valor2 = int.Parse(calculadoraView.Valor2);
      this.calculadoraModel.Multiplicacao(valor1, valor2);
      resultado = this.calculadoraModel.Resultado();
      calculadoraView.Resultado = resultado.ToString();
    }
    public void Divisao()
    {
      int resultado = 0;
      int valor1 = int.Parse(calculadoraView.Valor1);
      int valor2 = int.Parse(calculadoraView.Valor2);
      this.calculadoraModel.Divisao(valor1, valor2);
      resultado = this.calculadoraModel.Resultado();
      calculadoraView.Resultado = resultado.ToString();
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
  public interface ICalculadoraView
  {
    void SetController(CalculadoraController controller);
    string Valor1 { get; set; }
    string Valor2 { get; set; }
    string Resultado { get; set; }
  }
}

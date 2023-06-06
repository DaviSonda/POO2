using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convercoes
{
    public interface IConverterView
    {
        void SetController(ConverterController controller);
        string Valor { get; set; }
        string Coeficiente { get; set; }
        string Resultado { get; set; }
    }
}

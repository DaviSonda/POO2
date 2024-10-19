using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviSonegoA1
{
    public interface IFracaoView
    {
        void SetController(FracaoController controller);
        Fracao F1 { get; set; }
        Fracao F2 { get; set; }
        String Resultado { get; set; }
    }
}

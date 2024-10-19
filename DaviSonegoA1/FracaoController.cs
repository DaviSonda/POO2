using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviSonegoA1
{
    public class FracaoController
    {
        IFracaoView view;
        CalculaFracao model;

        public FracaoController(IFracaoView _view, CalculaFracao _model)
        {
            this.view = _view;
            this.model = _model;
            view.SetController(this);
        }

        public void SomaFracao()
        {
            String rslt = this.model.SomaFracao(view.F1, view.F2);
            view.Resultado = $"O resultado da soma é: {rslt}";
        }

        public void SubtraiFracao()
        {
            String rslt = this.model.SubtraiFracao(view.F1, view.F2);
            view.Resultado = $"O resultado da subtração é: {rslt}";
        }

        public void MultiplicaFracao()
        {
            String rslt = this.model.MultiplicaFracao(view.F1, view.F2);
            view.Resultado = $"O resultado da multiplicação é: {rslt}";
        }

        public void DivideFracao()
        {
            String rslt = this.model.DivideFracao(view.F1, view.F2);
            view.Resultado = $"O resultado da divisão é: {rslt}";
        }
    }
}

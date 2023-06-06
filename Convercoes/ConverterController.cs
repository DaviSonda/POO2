using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convercoes
{
    public class ConverterController
    {
        IConverterView conView;
        ConverterModel conModel;

        public ConverterController(IConverterView _conView, ConverterModel _conModel)
        {
            conView = _conView;
            conModel = _conModel;
            conView.SetController(this);
        }

        public void Converter()
        {
            double rslt = 0;
            MessageBox.Show("must be: " + conView.Valor + " mais esse: ", conView.Coeficiente);
            double valor = double.Parse(conView.Valor);
            this.conModel.Converter(valor, conView.Coeficiente);
            rslt = this.conModel.Resultado();
            conView.Resultado = rslt.ToString();
        }
    }
}

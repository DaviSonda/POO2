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
            double valor = double.Parse(conView.Valor);
            this.conModel.Converter(valor, conView.Coeficiente);
            MessageBox.Show(this.conModel.Resultado().ToString());
            rslt = this.conModel.Resultado();
            MessageBox.Show(rslt.ToString());
            conView.Resultado = rslt.ToString();
        }
    }
}

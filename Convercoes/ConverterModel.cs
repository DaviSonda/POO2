using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convercoes
{
    public class ConverterModel
    {
        private double resultado;

        public void Converter(double num, string coeficiente)
        {
            MessageBox.Show("DADOS PRA TI: " + num + " mais esse: ", coeficiente);
            resultado = num * this.getCoeficiente(coeficiente);
        }

        private double getCoeficiente(string coeficiente)
        {
            switch(coeficiente)
            {

            }
            return 10.5;
        }

        public double Resultado() { return resultado; }
    }
}

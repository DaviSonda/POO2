using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class Termo
    {
        private double coeficiente;
        private double expoente;
        public Termo()
        {
            coeficiente = 0;
            expoente = 0;
        }
        public Termo(double coeficiente, double expoente)
        {
            this.coeficiente = coeficiente;
            this.expoente = expoente;


        }
        public double Coeficiente
        {
            get { return coeficiente; }
            set { coeficiente = value; }
        }
        public double Expoente
        {
            get { return expoente; }
            set { expoente = value; }
        }


         // VERIFICAR LÓGICA PARA ADICIONAR + E - PARA NÚMEROS:
         public override string ToString()
        {
            string Result = string.Empty;
            if (Coeficiente != 0)
            {
                if (this.Coeficiente > 0)
                    Result += "+";
                else
                    Result += "-";

                if (this.Expoente == 0)
                    Result += (this.Coeficiente < 0 ? this.Coeficiente * -1 : this.Coeficiente).ToString();
                else if (this.Expoente == 1)
                    if (this.Coeficiente > 1 | this.Coeficiente < -1)
                        Result += string.Format("{0}x",(this.Coeficiente < 0 ? this.Coeficiente * -1 : this.Coeficiente).ToString());
                    else
                        Result += "x";
                else
                    if (this.Coeficiente > 1 | this.Coeficiente < -1)
                        Result += string.Format("{0}x^{1}", (this.Coeficiente < 0 ? this.Coeficiente * -1 : this.Coeficiente).ToString(), this.Expoente.ToString());
                    else
                        Result += string.Format("x^{0}",this.Expoente.ToString());
            }
            
            return Result;
        }
         
    }
}

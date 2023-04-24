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
        public Termo(int coeficiente, int expoente)
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


        /* // VERIFICAR LÓGICA PARA ADICIONAR + E - PARA NÚMEROS:
         * public override string ToString()
        {
            string Result = string.Empty;
            if (Coefficient != 0)
            {
                if (this.Coefficient > 0)
                    Result += "+";
                else
                    Result += "-";

                if (this.Power == 0)
                    Result += (this.Coefficient < 0 ? this.Coefficient * -1 : this.Coefficient).ToString();
                else if (this.Power == 1)
                    if (this.Coefficient > 1 | this.Coefficient < -1)
                        Result += string.Format("{0}x",(this.Coefficient <0 ? this.Coefficient * -1 : this.Coefficient).ToString());
                    else
                        Result += "x";
                else
                    if (this.Coefficient > 1 | this.Coefficient < -1)
                        Result += string.Format("{0}x^{1}", (this.Coefficient < 0 ? this.Coefficient * -1 : this.Coefficient).ToString(), this.Power.ToString());
                    else
                        Result += string.Format("x^{0}",this.Power.ToString());
            }
            return Result;
        }
         */
    }
}

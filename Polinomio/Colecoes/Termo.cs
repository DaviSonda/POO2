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

    }
}

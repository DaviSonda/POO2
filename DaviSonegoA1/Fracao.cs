using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviSonegoA1
{
    public class Fracao
    {
        private int numerador;
        private int denominador;

        public Fracao() { }

        public Fracao(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }   
        public int Numerador { get { return numerador; } set { numerador = value; } }
        public int Denominador { get { return denominador; } set { denominador = value; } }

        public void SimplificaFracao()
        {
            int mdc = CalcularMDC(this.numerador, this.denominador);
            this.numerador /= mdc;
            this.denominador /= mdc;
        }

        private int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{numerador} / {denominador}";
        }
    }
}

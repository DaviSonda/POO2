using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviSonegoA1
{
    public class CalculaFracao
    {
        public CalculaFracao() { }

        public String SomaFracao(Fracao f1, Fracao f2)
        {
            int denominador = f1.Denominador * f2.Denominador;
            int n1 = (denominador / f1.Denominador) * f1.Numerador;
            int n2 = (denominador / f2.Denominador) * f2.Numerador;
            int numerador = n1 + n2;
            Fracao fracao = new Fracao(numerador, denominador);
            fracao.SimplificaFracao();
            return fracao.ToString();
        }

        public String SubtraiFracao(Fracao f1, Fracao f2)
        {
            int denominador = f1.Denominador * f2.Denominador;
            int n1 = f1.Numerador * f2.Denominador;
            int n2 = f2.Numerador * f1.Denominador;
            int numerador = n1 - n2;
            Fracao fracao = new Fracao(numerador, denominador);
            fracao.SimplificaFracao();
            return fracao.ToString();
        }

        public String MultiplicaFracao(Fracao f1, Fracao f2)
        {
            int numerador = f1.Numerador * f2.Numerador;
            int denominador = f1.Denominador * f2.Denominador;
            Fracao fracao = new Fracao(numerador, denominador);
            fracao.SimplificaFracao();
            return fracao.ToString();
        }

        public String DivideFracao(Fracao f1, Fracao f2)
        {
            int numerador = f1.Numerador * f2.Denominador;
            int denominador = f2.Numerador * f1.Denominador;
            Fracao fracao = new Fracao(numerador, denominador);
            fracao.SimplificaFracao();
            return fracao.ToString();
        }
    }
}

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
        private int coeficiente;
        private int expoente;
        private int id;

        private int somaPolinomio;
        public Termo()
        {
            coeficiente= 0;
            expoente= 0;
        }
        public Termo(int coeficiente, int expoente)
        {
            this.coeficiente = coeficiente;
            this.expoente= expoente;

            
        }
        public int Coeficiente
        {
            get { return coeficiente; }
            set { coeficiente = value; }
        }
        public int Expoente
        {
            get { return expoente; }
            set { expoente = value; }
        }
        public int SomaPolinomio()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"\nAtleta {nome}, \n{idade} anos, \n{peso} Kg, \n{altura} de altura, \nIMC: {imc:f2} , {RetornaSituacao(situacao)}";
        }
        public int CompareTo(Polinomio atleta)
        {
            // return aluno.Nome.CompareTo(this.Nome); //Ordem alfabética decrescente
            return this.Nome.CompareTo(atleta.Nome); //Ordem alfabética crescente
        }


    }
}

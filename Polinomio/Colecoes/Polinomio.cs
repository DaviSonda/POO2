using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class Polinomio : IComparable<Polinomio>
    {
        string id;
        string val;

        public Polinomio()
        {
            this.id = "";
            this.val = "";
        }

        public Polinomio(string id, string val)
        {
            this.id = id;
            this.val = val;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Val
        {
            get { return val; }
            set { val = value; }
        }

        public override string ToString()
        {
            return $"\nNome: {id}\nPolinomio: {val}";
        }

        public int CompareTo(Polinomio pl)
        {
            return this.Id.CompareTo(pl.Id);
        }

        public void Calcula(double valor)
        {
            //Substituir os x do valor abaixo pelo valor double da func e calcular
            this.val;
            //Calcular aq
        }

    }
}

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
        List<Termo> val;

        public Polinomio()
        {
            this.id = "";
            this.val = new List<Termo>();
        }

        public Polinomio(string id, List<Termo> val)
        {
            this.id = id;
            this.val = new List<Termo>();
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public List<Termo> Val
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

        public long Calcula(double valor)
        {
            long result = 0;
            foreach (Termo t in val)
            {
                result += (long)t.Coeficiente * (long)(Math.Pow(valor, t.Expoente));
            }
            return result;
        }

    }
}

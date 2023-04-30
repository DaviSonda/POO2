using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class Cadastro
    {
        List<Polinomio> list = new List<Polinomio>();
        List<Termo> tl = new List<Termo>();
        public Cadastro()
        {
            //Fazer dados fake aq
        }

        public void ImprimePolinomios(string id)
        {
            if (id == null)
            {
                foreach (Polinomio pl in list)
                {
                    Console.WriteLine(pl.ToString());
                }
            }
            else
            {
                string f = id.ToUpper();
                foreach (Polinomio pl in list)
                {
                    string i = pl.Id.ToUpper();
                    if (i.Equals(f))
                    {
                        Console.WriteLine(pl.ToString());
                    }
                }
            }
        }

        public void InsereTermoPolinomio(Termo termo)
        {
             tl.Add(termo);
            

        }

        public void InserePolinomio(string nome)
        {
            List<Termo> termos = tl;
            list.Add(new Polinomio(nome, termos));
            tl = new List<Termo>();
        }

        public void CalculaPolinomios(string n1, string n2)
        {
            Polinomio p1 = new Polinomio();
            Polinomio p2 = new Polinomio();
            string f1 = n1.ToUpper();
            string f2 = n2.ToUpper();
            foreach (Polinomio pl in list)
            {
                string i = pl.Id.ToUpper();
                if (i.Equals(f1))
                {
                    p1 = pl;
                   
                } else if (i.Equals(f2))
                {
                    p2 = pl;
                    break;
                }
            }
            Polinomio result = new Polinomio(p1.Id, p1.Val) ;
            foreach (Termo t in p2.Val)
            {
                result.Val.Add(t);
            }
            
            Console.WriteLine(result.ToString());
        }

        public void CalculaPolinomio(string id, double valor)
        {
            Polinomio p = new Polinomio();
            string f = id.ToUpper();
            foreach (Polinomio pl in list)
            {
                string i = pl.Id.ToUpper();
                if(i.Equals(f))
                {
                    p = pl; 
                    break;
                }
            }
            p.Calcula(valor);
        }
    }

}


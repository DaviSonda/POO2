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
        List<Polinomio> list;
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

        public void InserePolinomio(string nome)
        {
            List<Termo> tl = new List<Termo>(); //Lista de onde os termos serão inseridos
            string pol = ""; // aq será concatenado o polinomio
            //Fazer while pra ele ir criando termos e ir inserindo nessa lista
            //Ir criando termo e add na list até que o cara deseja
            //e no fim inserir um novo polinomio com o nome q ele quis
            /*
              public int Add(Term value)
        {
            if (value.Coefficient != 0)
            {
                if (this.HasTermByPower(value.Power))
                {
                    this.AddToEqualPower(value);
                    return -1;
                }
                else
                    return (List.Add(value));
            }
            else
                return -1;
        }

            //Verifica se o expoente é igual
                    public void AddToEqualExpoente(Term value)
        {
            foreach (Term t in List)
            {
                if (t.Power == value.Power)
                    t.Coefficient += value.Coefficient;
            }
        }*/
            foreach (Termo t in tl)
            {
                pol += t.ToString();//Aq é a lógica de como concatenar o negócio ai tenk ver como vai ser
            }
            list.Add(new Polinomio(nome, pol)); //Segunda variável daq vai ser o valor
            Console.WriteLine($"\nAtleta {nome} com sucesso");
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
                    break;
                } else if (i.Equals (f2))
                {
                    p2 = pl;
                }
            }
            //Aq deve dar display de erro caso os dois polinomios n estiverem preenchidos
            //Após deve ser feita a soma dos polinomios como está no txt
            /*
             *         public static Poly (Poly p1, Poly p2)
                 {
                    Poly result = new Poly(p1.ToString());
                    foreach (Term t in p2.Terms)
                        result.Terms.Add(t);
                    return result;
                }
             */
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


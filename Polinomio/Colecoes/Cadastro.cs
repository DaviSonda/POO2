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

            while(tl.Count > 0)
            {
                tl.Add(new Termo());
            }
            foreach (Termo t in tl)
            {
                pol += t.ToString();//Aq é a lógica de como concatenar o negócio ai tenk ver como vai ser
            }
            list.Add(new Polinomio(nome, tl)); //Segunda variável daq vai ser o valor
            Console.WriteLine($"\nPolinomio {nome} com sucesso");
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
            Polinomio result = new Polinomio(p1.Id, p1.Val) ;
            result.ToString();
            foreach (Termo t in p2.Val)
            result.Val.Add(t);
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


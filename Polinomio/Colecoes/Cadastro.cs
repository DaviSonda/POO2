using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class Cadastro
    {
        List<Termo> list;
        public Cadastro()
        {
            list = new List<Termo>
            {
                new Termo(2, 1),
                new Termo(1,2)
            };
        }

        public void ImprimePolinomio(int id)
        {
            if (id == null)
            {
                foreach (Termo polinomio in list)
                {
                    Console.WriteLine(polinomio.ToString());
                }
            }
            else
            {
                foreach (Termo polinomio in list)
                {
                    if (polinomio. == id)
                    {
                        Console.WriteLine(polinomio.ToString());
                    }
                }
            }
        }

        public void InserePolinomio(Termo polinomio)
        {
            list.Add(polinomio);
            Console.WriteLine("\nAtleta inserido com sucesso");
        }

        public void ExcluiPolinomio(int filtro) { 
        }

        public void FiltraSituacaoIdade(string situacao, int idade)
        {
           
            }
        }

    }
}

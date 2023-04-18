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

        public void InserePolinomio(Termo polinomio)
        {
            //Ir ADD termo até que o cara deseja
            list.Add(polinomio);
            Console.WriteLine("\nAtleta inserido com sucesso");
        }

        public void ExcluiPolinomio(int filtro)
        {
        }

        public void FiltraSituacaoIdade(string situacao, int idade)
        {

        }
    }

}
}

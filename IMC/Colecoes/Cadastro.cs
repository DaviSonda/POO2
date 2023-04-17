using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc
{
    public class Cadastro
    {
        List<Atleta> list;
        public Cadastro()
        {
            list = new List<Atleta>
            {
                new Atleta("Carlos", 70.00, 1.76, 21),
                new Atleta("Davi", 90.00, 1.90, 21)
            };
        }

        public void ImprimeAtletas(string nome)
        {
            if (nome == null)
            {
                foreach (Atleta atleta in list)
                {
                    Console.WriteLine(atleta.ToString());
                }
            }
            else
            {
                foreach (Atleta atleta in list)
                {
                    if (atleta.Nome == nome)
                    {
                        Console.WriteLine(atleta.ToString());
                    }
                }
            }
        }

        public void InsereAtleta(Atleta atleta)
        {
            list.Add(atleta);
            Console.WriteLine("\nAtleta inserido com sucesso");
        }

        public void ExcluiAtleta(string filtro)
        {
            string f = filtro.ToUpper();
            List<Atleta> atl = new List<Atleta>();
            foreach (Atleta atleta in list)
            {
                string nome = atleta.Nome.ToUpper();
                string sit = atleta.Situacao.ToUpper();
                if (nome.Equals(f))
                {
                    atl.Add(atleta);
                }
                if (sit.Equals(f))
                {
                    atl.Add(atleta);
                }
            }

            foreach (Atleta at in atl)
            {
                list.Remove(at);
            }
            Console.WriteLine("\nAtletas deletado com sucesso");
        }

        public void FiltraSituacaoIdade(string situacao, int idade)
        {
            string f = situacao.ToUpper();
            foreach (Atleta atl in list)
            {
                string sit = atl.Situacao.ToUpper();
                if (sit.Equals(f))
                {
                    if (atl.Idade >= idade)
                    {
                        Console.WriteLine(atl.ToString());
                    }
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public class Lista
    {
        public Lista()
        {

        }
        //PRINCIPAIS COLEÇÕES
        public void List()
        {
            IList<Atleta> lista = new List<Atleta>();
            lista.Add(new Atleta("Carlos", 70.00, 1.76, 21));
            lista.Add(new Atleta("Davi", 90.00, 1.90, 21));


            Console.WriteLine("Testa List\n");
            Console.WriteLine(lista.ElementAt(1).ToString() + "\n");

            //Percorrendo todos os valores
            foreach (Atleta atleta in lista)
            {
                Console.WriteLine(atleta.ToString());
            }
            Console.WriteLine();

            //Removendo
            lista.RemoveAt(0);
            foreach (Atleta atleta in lista)
            {
                Console.WriteLine(atleta.ToString());
            }
        }

        // ORDENAÇÃO DE LISTAS
        public void OrdenaLista()
        {
            List<Atleta> lista = new List<Atleta>();
            Console.WriteLine("Testa Ordenação em List\n");

            lista.Sort();
            foreach (Atleta aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }

        }
    }   
}

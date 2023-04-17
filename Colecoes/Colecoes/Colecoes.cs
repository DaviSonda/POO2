using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public class Colecoes
    {
        public Colecoes()
        {

        }
        //PRINCIPAIS COLEÇÕES
        public void Dicionario()
        {
            IDictionary<string, Aluno> dicionario = new Dictionary<string, Aluno>();

            dicionario.Add("Marcelo", new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            dicionario.Add("Elisa", new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            dicionario.Add("Carlos", new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));


            Console.WriteLine("Testa Dictionary\n");

            Console.WriteLine(dicionario["Elisa"].ToString()+"\n");

            //Percorrendo todos os valores através da chave
            foreach (string chave in dicionario.Keys)
            {
                Console.WriteLine(dicionario[chave].ToString());
            }
            Console.WriteLine();

            //Percorrendo todos os valores
            foreach (Aluno aluno in dicionario.Values)
            {
                Console.WriteLine(aluno.ToString());
            }
            Console.WriteLine();

            //Excluíndo um valor
            dicionario.Remove("Elisa");
            foreach (Aluno aluno in dicionario.Values)
            {
                Console.WriteLine(aluno.ToString());
            }

        }
        public void SortedDicionario()
        {
            IDictionary<string, Aluno> dicionario = new SortedDictionary<string, Aluno>();

            dicionario.Add("Marcelo", new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            dicionario.Add("Elisa", new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            dicionario.Add("Carlos", new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));

            Console.WriteLine("Testa SortedDictionary\n");
            Console.WriteLine(dicionario["Elisa"].ToString() + "\n");

            //Percorrendo todos os valores através da chave
            foreach (string chave in dicionario.Keys)
            {
                Console.WriteLine(dicionario[chave].ToString());
            }
            Console.WriteLine();

            //Percorrendo todos os valores
            foreach (Aluno aluno in dicionario.Values)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
        public void SortedLista()
        {
            IDictionary<string, Aluno> dicionario = new SortedList<string, Aluno>();

            dicionario.Add("Marcelo", new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            dicionario.Add("Elisa", new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            dicionario.Add("Carlos", new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));

            Console.WriteLine("Testa sortedList\n");
            Console.WriteLine(dicionario["Carlos"].ToString() + "\n");

            //Percorrendo todos os valores através da chave
            foreach (string chave in dicionario.Keys)
            {
                Console.WriteLine(dicionario[chave].ToString());
            }
            Console.WriteLine();

            //Percorrendo todos os valores
            foreach (Aluno aluno in dicionario.Values)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
        public void Lista()
        {
            IList<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));

            Console.WriteLine("Testa List\n");
            Console.WriteLine(lista.ElementAt(1).ToString() + "\n");

            //Percorrendo todos os valores
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }
            Console.WriteLine();

            //Removendo
            lista.RemoveAt(0);
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
       
        public void ListaLigada()
        {
            Aluno auxAluno = null;
            LinkedList<Aluno> lista = new LinkedList<Aluno>();

            lista.AddFirst(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.AddLast(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.AddFirst(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            lista.AddFirst(new Aluno(678, "Rodrigo", "Brasília", "Computação"));

            Console.WriteLine("Testa LinkedList\n");
            Console.WriteLine(lista.ElementAt(1).ToString() + "\n");

            //Percorrendo todos os valores
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }
            Console.WriteLine();

            //Removendo
            foreach (Aluno aluno in lista)
            {
                if(aluno.Matricula == 789)
                {
                    auxAluno = aluno;
                }
                    
            }
            lista.Remove(auxAluno);
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }
        }

        public void HashSet()
        {
            HashSet<string> lista = new HashSet<string>();

            lista.Add("laranja");
            lista.Add("melancia");
            lista.Add("banana");
            lista.Add("laranja");
            lista.Add("pêssego");

            Console.WriteLine("Testa HashSet\n");
            Console.WriteLine(lista.ElementAt(1).ToString() + "\n");

            //Percorrendo todos os valores
            foreach (string fruta in lista)
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine();
        }
        public void SortedSet()
        {
            SortedSet<string> lista = new SortedSet<string>();

            lista.Add("laranja");
            lista.Add("melancia");
            lista.Add("banana");
            lista.Add("laranja");
            lista.Add("pêssego");

            Console.WriteLine("Testa SortedSet\n");
            Console.WriteLine(lista.ElementAt(1).ToString() + "\n");

            //Percorrendo todos os valores
            foreach (string fruta in lista)
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine();
        }
        public void Pilha()
        {
            Stack<string> pilha = new Stack<string>();
            pilha.Push("caneta");
            pilha.Push("papel");
            pilha.Push("borracha");

            Console.WriteLine("Testa Stack\n");
            Console.WriteLine(pilha.Peek());
            Console.WriteLine();

            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Peek());
        }
        public void Fila()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("primeiro");
            fila.Enqueue("segundo");
            fila.Enqueue("terceiro");

            Console.WriteLine("Testa Queue\n");
            Console.WriteLine(fila.Peek());
            Console.WriteLine();

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Peek());
        }

        // ORDENAÇÃO DE LISTAS
        public void OrdenaLista()
        {
            List<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            Console.WriteLine("Testa Ordenação em List\n");

            lista.Sort();
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }

        }
        public void OrdenaListaCurso()
        {
            List<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));

            Console.WriteLine("Testa Ordenação em List\n");
            lista.Sort(new OrdenarCurso());
            foreach (Aluno aluno in lista)
            {
                Console.WriteLine(aluno.ToString());
            }
        }

        //CONSULTAS LINQ
        public void ConsultaLista()
        {
            IList<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            lista.Add(new Aluno(777, "Gabriela Machado", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(888, "Marina Viola", "Flores da Cunha", "Computação"));

            Console.WriteLine("Testa Consultas LINQ\n");

            var consulta = from aluno in lista
                           where aluno.Curso.Equals("Computação")
                           select aluno;

            foreach (Aluno aluno in consulta)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
        public void ConsultaLista2()
        {
            IList<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            lista.Add(new Aluno(777, "Gabriela Machado", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(888, "Marina Viola", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(999, "Luciana Veira", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(722, "Jorge Luiz", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(833, "Sandra Regina", "Flores da Cunha", "Computação"));

            Console.WriteLine("Testa Consultas LINQ\n");
            var consulta = from aluno in lista
                           where aluno.Curso.Equals("Computação") && aluno.Cidade.Equals("Flores da Cunha")
                           orderby aluno.Nome ascending
                           select aluno;

            foreach (Aluno aluno in consulta)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
        public void ConsultaLista3()
        {
            IList<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            lista.Add(new Aluno(777, "Gabriela Machado", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(888, "Marina Viola", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(999, "Luciana Veira", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(722, "Jorge Luiz", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(833, "Sandra Regina", "Flores da Cunha", "Computação"));

            Console.WriteLine("Testa Consultas LINQ\n");

            var consulta = from aluno in lista
                           group aluno by aluno.Cidade;

            foreach (var cidadeGrupo in consulta)
            {
                Console.WriteLine(cidadeGrupo.Key);
                foreach (Aluno aluno in cidadeGrupo)
                {
                    Console.WriteLine(" {0} {1}", aluno.Nome, aluno.Cidade);
                }
                Console.WriteLine();
            }
        }
        public void ConsultaLista4()
        {
            IList<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            lista.Add(new Aluno(777, "Gabriela Machado", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(888, "Marina Viola", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(999, "Luciana Veira", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(722, "Jorge Luiz", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(833, "Sandra Regina", "Flores da Cunha", "Computação"));

            Console.WriteLine("Testa Consultas LINQ\n");
            var consulta = from aluno in lista
                           group aluno by aluno.Cidade into grupoAlunos
                           orderby grupoAlunos.Key
                           select grupoAlunos;

            foreach (var cidadeGrupo in consulta)
            {
                Console.WriteLine(cidadeGrupo.Key);
                foreach (Aluno aluno in cidadeGrupo)
                {
                    Console.WriteLine(" {0} {1}", aluno.Nome, aluno.Cidade);
                }
                Console.WriteLine();
            }
        }
        public void ConsultaLista5()
        {
            IList<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno(789, "Marcelo Santos", "Bento Gonçalves", "Tecnologias Digitais"));
            lista.Add(new Aluno(456, "Elisa da Silva", "Farroupilha", "Sistemas de Informação"));
            lista.Add(new Aluno(123, "Carlos Eduardo", "Caxias do Sul", "Computação"));
            lista.Add(new Aluno(777, "Gabriela Machado", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(888, "Marina Viola", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(999, "Luciana Veira", "Flores da Cunha", "Computação"));
            lista.Add(new Aluno(722, "Jorge Luiz", "Caxias do Sul", "Sistemas de Informação"));
            lista.Add(new Aluno(833, "Sandra Regina", "Flores da Cunha", "Computação"));

            IList<Centros> centros = new List<Centros>();
            centros.Add(new Centros("CCET", "Computação"));
            centros.Add(new Centros("CCET", "Sistemas de Informação"));
            centros.Add(new Centros("CAMPUS 8", "Tecnologias Digitais"));

            Console.WriteLine("Testa Consultas LINQ\n");
            var join = from aluno in lista
                       join centro in centros on aluno.Curso equals centro.Curso
                       orderby centro.Centro
                       select new { NomeAluno = aluno.Nome, NomeCentro = centro.Centro };

            foreach (var item in join)
            {
                Console.WriteLine("{0} {1}", item.NomeAluno, item.NomeCentro);
            }

        }
    }
}

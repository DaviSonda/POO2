using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class OrdenarCurso : IComparer<Aluno>
    {
        //Nesse exemplo, não é necessário que a classe Aluno implemente IComparable
        public int Compare(Aluno aluno1, Aluno aluno2)
        {
            return aluno2.Curso.CompareTo(aluno1.Curso);
            //return aluno1.Curso.CompareTo(aluno2.Curso);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Centros
    {
        string centro;
        string curso;
        public Centros(string centro, string curso) {
            this.centro = centro;
            this.curso = curso;
        }
        public string Centro
        {
            get { return centro; }
            set { centro = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}

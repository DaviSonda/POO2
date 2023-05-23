using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores2
{
    public class Vendedor : IComparable<Vendedor>
    {
        int codigo;
        string nome;
        string cidade;
        double vendas;

        public Vendedor()
        {
            codigo = 0;
            nome = "";
            cidade = "";
            vendas = 0;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
         }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public double Vendas
        {
            get { return vendas; }
            set { vendas = value; }
        }

        public string ToString()
        {
            string res = "[" + codigo + ", " + nome + ", " + cidade + ", " + vendas + "]";
            return res; 
        }
        public int CompareTo(Vendedor vendedor)
        {
            // return func.Nome.CompareTo(this.Nome); //Ordem alfabética decrescente
            return this.Nome.CompareTo(vendedor.Nome); //Ordem alfabética crescente
        }
    }
}

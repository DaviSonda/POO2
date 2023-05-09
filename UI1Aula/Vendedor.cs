using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI1Aula
{
    public class Vendedor : IComparable<Vendedor>
    {
        private int codigo;
        private string nome;
        private string cidade;
        private double vendas;
        public Vendedor()
        {
            codigo = 0;
            nome = "";
            cidade = "";
            vendas = 0;
        }

        public Vendedor(int codigo, string nome, string cidade, double vendas)
        {
            Codigo = codigo;
            Nome = nome;
            Cidade = cidade;
            Vendas = vendas;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get => nome;
            set { nome = value; }
        }

        public double Vendas
        {
            get => vendas;
            set { vendas = value; }
        }

        public string Cidade
        {
            get => cidade;
            set { cidade = value; }
        }

        public int CompareTo(Vendedor other)
        {
            throw new NotImplementedException();
        }
    }
}

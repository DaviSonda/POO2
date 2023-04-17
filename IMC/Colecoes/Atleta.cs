using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public class Atleta : IComparable<Atleta>
    {
        string nome;
        string situacao;
        double peso;
        double altura;
        double imc;
        int idade;
        public Atleta()
        {
            nome = "";
            peso = 0.0;
            altura = 0.0;
            idade = 0;
        }
        public Atleta(string nome, double peso, double altura, double imc, int idade, string situacao)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
            this.idade = idade;
            this.situacao = situacao;

            this.imc = peso / (Math.Pow(altura, 2));
            this.situacao = RetornaSituacao(this.CalculaSituacao(this.imc));
        }
        public string Nome
        {
            get { return nome;}
            set { nome = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Imc
        {
            get { return imc; }
            set { imc = value; }
        }

        public string CalculaSituacao(double imc)
        {
            string situacao = null;
            if (imc < 18.5)
            {
                situacao = "AP";
            }
            if (imc >= 18.5 && imc <= 24.9)
            {
                situacao = "PN";
            }
            if (imc >= 25 && imc <= 29.9)
            {
                situacao = "PO";
            }
            if (imc >= 25 && imc <= 29.9)
            {
                situacao = "PO";
            }
            if (imc >= 25 && imc <= 29.9)
            {
                situacao = "PO";
            }
            if (imc >= 30 && imc <= 34.9)
            {
                situacao = "O1";
            }
            if (imc >= 35 && imc <= 39.9)
            {
                situacao = "O2";
            }
            if (imc > 40)
            {
                situacao = "O3";
            }

            return situacao;
        }

        public string RetornaSituacao(string situacao)
        {
            string retornacao = null;
            if (situacao == "AP")
            {
                retornacao = "Abaixo do peso ideal";
            }
            if (situacao == "PN")
            {
                retornacao = "Peso normal";
            }
            if (situacao == "PO")
            {
                retornacao = "Pré-obeso";
            }
            if (situacao == "O1")
            {
                retornacao = "Obeso classe I";
            }
            if (situacao == "O2")
            {
                retornacao = "Obeso classe II";
            }
            if (situacao == "O3")
            {
                retornacao = "Obeso classe III";
            }
                return retornacao;
        }

        
        public override string ToString()
        {
            string res = "\n[\n" + nome + ",\n" + peso + ",\n" + altura + ",\n" + idade + ",\n" + imc + ",\n" + situacao + "\n]\n";
            return res;
        }
        public int CompareTo(Atleta atleta)
        {
            // return aluno.Nome.CompareTo(this.Nome); //Ordem alfabética decrescente
            return this.Nome.CompareTo(atleta.Nome); //Ordem alfabética crescente
        }


    }
}

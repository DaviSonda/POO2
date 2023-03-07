using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private double valor;

        public Produto()
        {
            this.codigo = 0;
            this.descricao = "";
            this.valor = 0;
        }
        public Produto(int codigo, string descricao, double valor)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.valor = valor;
        }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public double Valor { get { return valor; } set { valor = value; } }

        public double Reajuste(OperacaoEnum operacao, double porcentagem)
        {
            switch (operacao)
            {
                case OperacaoEnum.Adicionar:
                    valor += (porcentagem / 100 * valor);
                    break;
                case OperacaoEnum.Remover:
                    valor -= (porcentagem / 100 * valor);
                    break;
            }
            return valor;
        }

        public override string ToString()
        {
            return codigo + " , " + descricao + " , " + valor;
        }
    }
}

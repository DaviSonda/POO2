using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class ProdutoAlimentar : Produto
    {
        private Data dataFabricacao;
        private Data dataValidade;

        public ProdutoAlimentar() : base()
        {
            DateTime madeDate = DateTime.Now;
            //Data de validate padrão é 30 dias
            DateTime expireDate = madeDate.AddDays(30);
            dataFabricacao = new Data(madeDate.Day, madeDate.Month, madeDate.Year);
            dataValidade = new Data(expireDate.Day, expireDate.Month, expireDate.Year);
        }

        public ProdutoAlimentar(Data dataFabricacao, Data dataValidade) : base()
        {
            Console.WriteLine("\nfabric: " + dataFabricacao.ToString());
            Console.WriteLine("\nvalidad: " + dataValidade.ToString());
            this.dataFabricacao = dataFabricacao;
            this.dataValidade = dataValidade;
        }

        public Data DataFabricacao { get { return dataFabricacao; } set { dataFabricacao = value; } }

        public Data DataValidade { get { return dataValidade; } set { dataValidade = value; } }

        public override string ToString()
        {
            string x = base.ToString();
            return x + "\nData de fabricação: " + DataFabricacao.ToString() + "\nData de validade: " + DataValidade.ToString();
        }
    }
}

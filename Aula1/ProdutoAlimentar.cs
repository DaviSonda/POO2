using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class ProdutoAlimentar : Produto
    {
        private int dataFabricacao;
        private int dataValidade;

        public ProdutoAlimentar(int dataFabricacao, int dataValidade)
        {
            this.dataFabricacao = dataFabricacao;
            this.dataValidade = dataValidade;
        }

        public int DataFabricacao { get { return dataFabricacao; } set { dataFabricacao = value; } }

        public int DataValidade { get { return dataValidade; } set { dataFabricacao = value; } }

        public override string ToString()
        {
            return "\nData de fabricação: " + dataFabricacao + "\nData de validade: " + dataValidade;
        }
    }
}

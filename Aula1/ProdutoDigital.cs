using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class ProdutoDigital : Produto
    {
        private int tamanhoArquivo;
        private int versaoProduto;

        public ProdutoDigital() : base()
        {
            tamanhoArquivo = 0;
            versaoProduto = 0;
        }

        public ProdutoDigital(int tamanhoArquivo, int versaoProduto) : base()
        {
            this.tamanhoArquivo = tamanhoArquivo;
            this.versaoProduto = versaoProduto;

        }

        public int TamanhoArquivo { get {  return tamanhoArquivo; } set {  tamanhoArquivo = value; } }
        public int VersaoProduto { get { return versaoProduto; } set {  versaoProduto = value; } }

        public override string ToString()
        {
            return "\nTamanho do arquivo: " + tamanhoArquivo + "\nVersão do Produto: " + versaoProduto;
        }
    }
}

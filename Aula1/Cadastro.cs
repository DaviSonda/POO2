using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Cadastro
    {
        EntradaDados entrada;
        private Produto[] produtos;
        private int pos = 0;
        private const int TAM = 5;

        public Cadastro()
        {
            produtos = new Produto[10];
            entrada = new EntradaDados();
            //Mock
            InsereDados(new Produto(1, "prod1", 5));
            InsereDados(new Produto(2, "prod2", 5));
            //Mock
        }

        public void OrdenaProdutosAlfabeticamente()
        {
            Produto aux = null;
            for (int i = 0; i < pos; i++)
            {
                for (int j = 0; j < pos - 1; j++)
                {
                    if (produtos[j].Descricao.CompareTo(produtos[j + 1].Descricao) > 0)
                    {
                        aux = produtos[j];
                        produtos[j] = produtos[j + 1];
                        produtos[j + 1] = aux;
                    }
                }
            }
        }

        public void InsereDados(int cod, string desc, double valor)
        {
            if (pos < TAM)
            {
                Produto p = new Produto(cod, desc, valor);
                produtos[pos] = p;
                pos++;
            }
        }
        public void InsereDados(Produto p)
        {
            if (pos < TAM)
            {
                produtos[pos] = p;
                pos++;
            }
        }

        public int Tamanho() { return pos; }

        public Produto GetProduto(int posicao)
        {
            Produto p = null;
            if (posicao >= 0 && posicao < pos)
            {
                p = produtos[posicao];
            }
            return p;
        }

        public Produto GetProdutoByCodigo(int codigo)
        {
            for (int i = 0; i < pos; i++)
            {
                if (produtos[i].Codigo == codigo) return produtos[i];
            }
            NotFound();
            return null;
        }

        public void ExcluiProduto(int codigo)
        {
            bool matched = false;
            for (int i = 0; i < pos; i++)
            {
                if (produtos[i].Codigo == codigo)
                {
                    //Transforma pedidos em lista
                    var prod = produtos.ToList();
                    //Remove produto da lista
                    prod.Remove(GetProduto(i));
                    //Transforma novamente em array
                    produtos = prod.ToArray();
                    //Diminui o tamanho do array
                    pos--;
                    //Marca o produto como excluído
                    matched = true;
                    //Avisa o produto que foi excluído e encerra o loop
                    Console.WriteLine("\nProduto de código: " + codigo + " deletado com sucesso");
                    break;
                }
            }
            if (!matched)
            {
                NotFound();
            }
        }

        public void EditarProduto(int codigo)
        {
            bool matched = false;
            for (int i = 0; i < pos; i++)
            {
                if (produtos[i].Codigo == codigo)
                {
                    produtos[i].Descricao = entrada.LeString("Digite a nova descrição do produto:");
                    produtos[i].Valor = entrada.LeDouble("Digite o novo valor do produto:");
                    Console.WriteLine("\nProduto de código: " + codigo + " atualizado com sucesso");
                    matched = true;
                    break;
                }
            }

            if (!matched)
            {
                NotFound();
            }
        }

        public void NotFound()
        {
            Console.WriteLine("\nNão foi encontrado nenhum produto com esse código");
        }
    }
}

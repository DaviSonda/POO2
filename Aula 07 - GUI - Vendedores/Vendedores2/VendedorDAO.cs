using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores2
{
    public class VendedorDAO
    {
        /* Classe que armazena os dados dos vendedores, na memória.
         * Possui métodos para inserir vendedores, excluir vendedores, ordenar a lista, 
         * retornar o tamanho da lista, retornar um vendedor dalista.
         */
        List<Vendedor> vendedores; //Declara um objeto List (conjunto de vendedores)
        
        public VendedorDAO()
        {
            vendedores = new List<Vendedor>(); //Constrói o objeto vendedores, da classe List
        }
        public List<Vendedor> ObtemTodosVendedores()
        { //Retorna todos os vendedores (retorna o objeto que armazena todos os vendedores)
            return vendedores;
        }
        public void InsereVendedor(Vendedor vend)
        { //Insere um vendedor e depois ordena pelo nome
            vendedores.Add(vend);
            Ordena(); //Chama o método que ordena a lista de vendedores

        }
        public Vendedor ObtemVendedor(int posicao)
        {//Retorna o vendedor da posição especificada.
            Vendedor vend = null;
            if ((posicao >= 0) && (posicao < vendedores.Count))
            {
                vend = vendedores.ElementAt(posicao); //Obtém o objeto da posição informada
            }
            return vend;
        }

        public int Tamanho()
        {//Retorna a quantidade de elementos da lista
            return vendedores.Count;
        }
        public void Ordena()
        {
            vendedores.Sort(); //Ordena os vendedores, pelo nome. Para isso usa o CompareTo da classe Vendedor
        }

        public void ExcluiVendedor(Vendedor vend)
        {
            for (int i = 0; i < this.Tamanho(); i++)
            {
                if ((vendedores[i].Nome.Equals(vend.Nome)) == true)
                {
                    vendedores.RemoveAt(i); //Exclui um vendedor do cadastro
                    break; //Força a saída do laço
                }
            }
        }
    }
}

using System;
using System.IO;

namespace Vendedores2
{
  public class AcessaDados
    {
        VendedorDAO cadastro; //cadVendedor é um objeto da classe CadVendedor

        public AcessaDados(VendedorDAO cadven)//Método Construtor
        {
            cadastro = cadven; //Atribui o cadven (parâmetro) ao objeto global cadVendedor
        }

        public bool ExisteArquivo(string arquivo) //retorna true ou false se o arq. existe ou não
        {
            return File.Exists(arquivo); //Testa a existência do arquivo
        }
        public void LeituraDados(string arquivo) //lê os dados colocando-os na lista
        {
            string linha = "";
            string aux = "";
            int codigo = 0;
            string nome = "";
            string cidade = "";
            decimal totalVendas;

            Vendedor vendedor;
            if (ExisteArquivo(arquivo))
            {
                try
                {
                    StreamReader sr = new StreamReader(arquivo); //Cria o objeto StreamReader para ler uma linha do arquivo
                    char[] delimitador = { ';' }; //Define o delimitador dos dados
                    while ((linha = sr.ReadLine()) != null) //Lê uma linha do arquivo e atribui à string linha
                    {
                        string[] linhaSplit = linha.Split(delimitador); // Transforma a string linha em um vetor de strings
                        codigo = int.Parse(linhaSplit[0]); //variável código recebe o valor da primeira posição do vetor
                        nome = linhaSplit[1]; //string nome recebe o valor da segunda posição do vetor
                        cidade = linhaSplit[2]; //string cidade recebe o valor da terceira posição do vetor
                        aux = linhaSplit[3];       
                        totalVendas = decimal.Parse(aux);
 
                        vendedor = new Vendedor(); 
                        vendedor.Codigo = codigo;
                        vendedor.Nome = nome;
                        vendedor.Cidade = cidade;
                        vendedor.Vendas = (double) totalVendas;
                        cadastro.InsereVendedor(vendedor);
                        }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro!\n" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Término da Leitura de Dados do Arquivo " + arquivo);
                }
            }
        }
        public void EscritaDados(string arquivo)
        {
            Vendedor vend;
            string linha;
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                    for (int i = 0; i < cadastro.Tamanho(); i++) // Laço para percorrer todos os dados cadastrados (todos os vendedores cadastrados)
                    {
                        vend = cadastro.ObtemVendedor(i); //Obtém cada um dos vendedores cadastrados
                        linha = vend.Codigo + ";" + vend.Nome + ";" + vend.Cidade + ";" + vend.Vendas;
                        sw.WriteLine(linha); //grava a string linha no arquivo
                    }

            }
            catch (Exception ex)
            {

            }
        }
    }
}

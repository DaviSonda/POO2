using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class EntradaDados
    {
        private Data data = new Data();
        public EntradaDados() { }

        public int LeInteiro(string msg)
        {
            try
            {
                Console.WriteLine("\n" + msg);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nVocê deve digitar um inteiro válido\n");
                return this.LeInteiro(msg);
            }
        }

        public double LeDouble(string msg)
        {
            try
            {
                Console.WriteLine("\n" + msg);
                return double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nVocê deve digitar um double válido\n");
                return this.LeDouble(msg);
            }
        }

        public string LeString(string msg)
        {
            try
            {
                Console.WriteLine("\n" + msg);
                return Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\nVocê deve digitar uma string válida\n");
                return this.LeString(msg);
            }
        }

        public Data LeData(string msg)
        {
            Console.WriteLine("\n" + msg);
            int day = LeInteiro("Digite o dia:");
            int month = LeInteiro("Digite o mês:");
            int year = LeInteiro("Digite o ano:");
            Data d = new Data(day, month, year);
            Boolean b = d.DataValida(d);
            if (b)
            {
                return d;
            }
            else
            {
                Console.WriteLine("\nVocê deve digitar uma data válida\n");
                return this.LeData(msg);
            }
        }
    }
}

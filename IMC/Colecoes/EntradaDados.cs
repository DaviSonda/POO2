using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc
{
    public class EntradaDados
    {
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

    }
}
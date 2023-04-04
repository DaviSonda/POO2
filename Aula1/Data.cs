using Aula1.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia { get { return dia; } set { dia = value; } }
        public int Mes { get { return mes; } set { mes = value; } }
        public int Ano { get { return ano; } set { ano = value; } }

        public Data() { }
        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public bool DataValida(Data data)
        {
            DateTime d;

            bool chValidity = DateTime.TryParseExact(
         data.ToString(),
         "dd/MM/yyyy",
         CultureInfo.InvariantCulture,
         DateTimeStyles.None,
         out d);
            return chValidity;
        }

        public override string ToString()
        {
            String d;
            String m;
            if (dia < 10)
            {
                d = "0" + dia;
            }
            else d = dia.ToString();
            if (mes < 10)
            {
                m = "0" + mes;
            }
            else m = mes.ToString();
            return d + "/" + m + "/" + ano;
        }

        public ValidadeEnum ValidadeData(Data data)
        {
            DateTime today = DateTime.Now;
            DateTime formattedData = DateTime.ParseExact(data.ToString(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
            int diffDays = today.CompareTo(formattedData);
            if (diffDays > 0)
            {
                return ValidadeEnum.Vencido;
            }
            else if (diffDays > -4)
            {
                return ValidadeEnum.VenceEmBreve;
            }
            else
            {
                return ValidadeEnum.Ok;
            }
        }

    }
}

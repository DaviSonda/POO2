using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convercoes
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConverterView conView = new ConverterView();
            conView.Visible = false;

            ConverterModel conModel = new ConverterModel();

            ConverterController conController = new ConverterController(conView, conModel);
            conView.ShowDialog();
        }
    }
}

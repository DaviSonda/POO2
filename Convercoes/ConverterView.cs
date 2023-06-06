using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convercoes
{
    public partial class ConverterView : Form, IConverterView
    {
        ConverterController controller;
        public ConverterView()
        {
            InitializeComponent();
            coeficiente.Items.Add(ConversorEnum.Kilometro);
            coeficiente.Items.Add(ConversorEnum.Milha);
            coeficiente.Items.Add(ConversorEnum.Quilo);
            coeficiente.Items.Add(ConversorEnum.Libra);
            coeficiente.Items.Add(ConversorEnum.Litro);
            coeficiente.Items.Add(ConversorEnum.Onca);
            coeficiente.Items.Add(ConversorEnum.Celsius);
            coeficiente.Items.Add(ConversorEnum.Fahrenheit);
        }

        public void SetController(ConverterController _controller)
        {
            controller = _controller;
        }

        public string Valor
        {
            get { return this.valor.Text; }
            set { this.valor.Text = value; }
        }
        public string Coeficiente
        {
            get { return this.coeficiente.Text; }
            set { this.coeficiente.Text = value; }
        }
        public string Resultado
        {
            get { return this.resultado.Text; }
            set { this.resultado.Text = value; }
        }

        private void ConverterView_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(coeficiente.Text);
            this.controller.Converter();
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {                                                           
                e.Handled = true;                                       
            }
        }
    }
}

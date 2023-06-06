using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculadoraView : Form, ICalculadoraView
    {
        Operacoes op;
        CalculadoraController controller;
        public CalculadoraView()
        {
            InitializeComponent();
            op = new Operacoes();
        }
    //******************************************************
    // Implementação da Interface 

        public void SetController(CalculadoraController _controller)
        {
          controller = _controller;
        }
        public string Valor1
        {
          get { return this.txtValor1.Text; }
          set { this.txtValor1.Text = value; }
        }
        public string Valor2
        {
          get { return this.txtValor2.Text; }
          set { this.txtValor2.Text = value; }
        }
        public string Resultado
        {
          get { return this.txtResultado.Text; }
          set { this.txtResultado.Text = value; }
        }
    // *******************************************************************
        private void btnSoma_Click(object sender, EventArgs e)
        {
          this.controller.Soma();
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
          this.controller.Subtracao();
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
          this.controller.Multiplicacao();
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
          this.controller.Divisao();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

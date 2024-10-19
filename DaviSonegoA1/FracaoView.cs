namespace DaviSonegoA1
{
    public partial class FracaoView : Form, IFracaoView
    {
        FracaoController controller;
        public FracaoView()
        {
            InitializeComponent();
        }

        public void SetController(FracaoController _controller)
        {
            controller = _controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Fracao F1
        {
            get { return new Fracao(int.Parse(this.num1.Text), int.Parse(this.den1.Text)); }
            set { this.num1.Text = value.Numerador.ToString(); this.den1.Text = value.Denominador.ToString(); }
        }

        public Fracao F2
        {
            get { return new Fracao(int.Parse(this.num2.Text), int.Parse(this.den2.Text)); }
            set { this.num2.Text = value.Numerador.ToString(); this.den2.Text = value.Denominador.ToString(); }
        }

        public string Resultado
        {
            get { return this.lblResultado.Text; }
            set { this.lblResultado.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void den1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void den2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                this.controller.SomaFracao();
            }   catch {
                MessageBox.Show("Você deve preencher todos campos para realizar a operação");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                this.controller.SubtraiFracao();
            }
            catch
            {
                MessageBox.Show("Você deve preencher todos campos para realizar a operação");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                this.controller.MultiplicaFracao();
            }
            catch
            {
                MessageBox.Show("Você deve preencher todos campos para realizar a operação");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                this.controller.DivideFracao();
            }
            catch
            {
                MessageBox.Show("Você deve preencher todos campos para realizar a operação");
            }
        }
    }
}
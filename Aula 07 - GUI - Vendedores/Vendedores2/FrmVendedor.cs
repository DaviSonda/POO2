using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendedores2
{
    public partial class FrmVendedor : Form
    {
        VendedorDAO vendedorDAO;
        int codigoConsultado;
        AcessaDados dadosVend;
        bool virg1;
        public FrmVendedor(VendedorDAO _vendedorDAO)
        {
            codigoConsultado = -1;
            vendedorDAO = _vendedorDAO;
            dadosVend = new AcessaDados(_vendedorDAO);
            InitializeComponent();
            virg1 = false; //Vírgula não foi teclada
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvVendedores.DataSource = null; // Limpa a fonte de dados da grade.
            dgvVendedores.Rows.Clear(); //Limpa os dados (as linhas) da grade.
            dgvVendedores.DataSource = vendedorDAO.ObtemTodosVendedores(); //Atribui o objeto List da classe CadVendedor para o datasource da grade de exibição de dados
            dgvVendedores.Visible = true; //Torna a grade visível
            dgvVendedores.Focus(); //Coloc o foco na grade.
        }

        private Vendedor ObtemDados()
        {//"Pega" os dados da tela. Cria um objeto da classe Vendedor. Atribui os dados ao 
         // objeto da classe Vendedor.
            int codigo = 0;
            string aux = "", nome = " ", cidade = " ";
            bool conversao = false;
            decimal totalVendas;
            Vendedor vendedor;

            //Consistencia para a entrada de dados - Código
            aux = txtCodigo.Text;
            conversao = int.TryParse(aux, out codigo);
            if (conversao == false)
            {
                MessageBox.Show("Código Inválido!!");
                return null;
            }
            
            nome = txtNome.Text;
            cidade = txtCidade.Text;
            //Consistencia para a entrada de dados - Total de Vendas
            aux = txtVendas.Text;
            conversao = decimal.TryParse(aux, out totalVendas);
            if (conversao == false)
            {
                MessageBox.Show("Valor de Vendas Inválido!!");
                return null;
            }
            vendedor = new Vendedor(); //Cria o objeto vendedor da classe Vendedor
            vendedor.Codigo = codigo;  //Insere o código lido do teclado no objeto vendedor
            vendedor.Nome = nome;      //Insere o nome lido do teclado no objeto vendedor
            vendedor.Cidade = cidade;  //Insere a cidade lida do teclado no objeto vendedor
            vendedor.Vendas = (double)totalVendas;  //Insere o total de vendas lido do teclado no objeto vendedor
            return vendedor;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = this.ObtemDados();
            Vendedor aux;
            if(codigoConsultado == -1)
            {
                vendedorDAO.InsereVendedor(vendedor); //Insere o vendedor no cadastro de vendedores
                dadosVend.EscritaDados("vendedores.csv");//Escreve os dados dos vendedores no arquivo.
            }
            else
            {
                aux = vendedorDAO.ObtemVendedor(codigoConsultado);
                vendedorDAO.ExcluiVendedor(aux);
                vendedorDAO.InsereVendedor(vendedor);
                dadosVend.EscritaDados("vendedores.csv");
            }
            LimparTela();
        }
        private void LimparTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCidade.Clear();
            txtVendas.Clear();
            txtCodigo.Focus();
            codigoConsultado = -1;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Vendedor vendedor;
            if (MessageBox.Show("Tem certeza que deseja remover este registro ?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vendedor = this.ObtemDados();
                vendedorDAO.ExcluiVendedor(vendedor);
                dadosVend.EscritaDados("vendedores.csv");
                LimparTela();
            }
        }

        private void dgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Este método é executado quando são dados dois clicks em qualquer célula da grade.
            int linha = -1;
            Vendedor vendedor;

            linha = dgvVendedores.CurrentCell.RowIndex; //Obtém o índice da linha em que os dois clicks foram dados
            vendedor = vendedorDAO.ObtemVendedor(linha); //Obtém o vendedor correspondente ao índice da linha
            txtCodigo.Text = vendedor.Codigo.ToString(); //Atribui o código do vendedor ao txtCodigo
            txtNome.Text = vendedor.Nome;//Atribui o nome do vendedor ao txtNome
            txtCidade.Text = vendedor.Cidade; //Atribui a cidade do vendedor ao txtCidade
            txtVendas.Text = vendedor.Vendas.ToString();
            codigoConsultado = linha;
            dgvVendedores.Visible = false;//Esconde a grade
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este evento (KeyPress) é gerado quando o teclado é usado
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Se a tecla digitada não for um caracter de controle (ex. SHIFT, ALT, CTRL)
            {                                                           //ou se não for um dígito decimal atribui TRUE ao parâmetro KeyPressEventArguments.
                e.Handled = true;                                       // Isso faz com que o caracter não seja exibido.
            }
        }

        private void txtVendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtVendas.Text.IndexOf(',') == -1)
            {
                virg1 = false;
            }
            if (e.KeyChar == ',')
            {
                if (virg1 == true)
                {
                    e.Handled = true;
                }
                else
                {
                    virg1 = true;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Se a tecla digitada não for um caracter de controle (ex. SHIFT, ALT, CTRL)
            {                                                           //ou se não for um dígito decimal atribui TRUE ao parâmetro KeyPressEventArguments.
                e.Handled = true;                                       // Isso faz com que o caracter não seja exibido.
            }
        }

        private void dgvVendedores_KeyDown(object sender, KeyEventArgs e)
        {
            //Evento que captura se uma tecla de controle (ESC) foi pressionada
            if (e.KeyData == Keys.Escape)  //Se foi pressionado o ESC a grade se torna invisível.
            {
                dgvVendedores.Visible = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    private void txtCodigo_TextChanged(object sender, EventArgs e)
    {

    }
  }
}

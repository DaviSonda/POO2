using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendedores2
{
    public partial class FrmPrincipal : Form
    {
        FrmVendedor frmVendedor;

        VendedorDAO vendedorDAO;
        AcessaDados dadosVend;

        public FrmPrincipal()
        {
            vendedorDAO = new VendedorDAO();
            dadosVend = new AcessaDados(vendedorDAO);
            dadosVend.LeituraDados("vendedores.csv");
            InitializeComponent();
        }

        private void itemVendedores_Click(object sender, EventArgs e)
        {
            frmVendedor = new FrmVendedor(vendedorDAO);
            frmVendedor.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void itemSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }
  }
}

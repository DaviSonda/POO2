using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioForms
{
    public partial class FormJokenpo : Form
    {
        public FormJokenpo()
        {
            InitializeComponent();
            cbJokenpo.Items.Add(JokenpoEnum.Pedra);
            cbJokenpo.Items.Add(JokenpoEnum.Papel);
            cbJokenpo.Items.Add(JokenpoEnum.Tesoura);
            cbJokenpo2.Items.Add(JokenpoEnum.Pedra);
            cbJokenpo2.Items.Add(JokenpoEnum.Papel);
            cbJokenpo2.Items.Add(JokenpoEnum.Tesoura);
        }

        private void FormJokenpo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p = GetDados();
            lblVencedor.Text = p;
            lblVencedor.Visible = true;

        }

        private string GetDados()
        {
            try
            {
                JokenpoEnum j1 = new Jokenpo().getEnumByString(cbJokenpo.Text);
                JokenpoEnum j2 = new Jokenpo().getEnumByString(cbJokenpo2.Text);
                return new Jokenpo().retornaGanhador(j1, j2);
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve preencher todas informações");
                return null;
            }
        }

        private void lblVencedor_Click(object sender, EventArgs e)
        {

        }
    }
    }


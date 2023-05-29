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
    public partial class FormPlanetas : Form
    {
        public FormPlanetas()
        {
            InitializeComponent();
            cbPlaneta.Items.Add(PlanetaEnum.Mercurio);
            cbPlaneta.Items.Add(PlanetaEnum.Venus);
            cbPlaneta.Items.Add(PlanetaEnum.Marte);
            cbPlaneta.Items.Add(PlanetaEnum.Jupiter);
            cbPlaneta.Items.Add(PlanetaEnum.Saturno);
            cbPlaneta.Items.Add(PlanetaEnum.Urano);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPlaneta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            Peso p = getDados();
            if (p != null)
            {
                String plnt = p.getPlanetaName();
                lblPeso.Text = "O seu peso no planeta " + plnt + " é: " + p.getPesoPlaneta(p) + " Kilos";
                lblPeso.Visible = true;
            }

        }

        private Peso getDados()
        {
            try
            {
                PlanetaEnum plnt = new Peso().getEnumByString(cbPlaneta.Text);
                return new Peso(int.Parse(inptPeso.Text), plnt);
                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve preencher todas informações");
                return null;
            }
        }

        private void inptPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Se a tecla digitada não for um caracter de controle (ex. SHIFT, ALT, CTRL)
            {                                                           //ou se não for um dígito decimal atribui TRUE ao parâmetro KeyPressEventArguments.
                e.Handled = true;                                       // Isso faz com que o caracter não seja exibido.
            }
        }
    }
}

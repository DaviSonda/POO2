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
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            Triangulo t = GetDados();
            if (t != null)
            {
                resultado.Text = t.RetornaTriangulo();
                resultado.Visible = true;
            }

        }

        private Triangulo GetDados()
        {
            try { 
            return new Triangulo(int.Parse(txtLado1.Text), int.Parse(txtLado2.Text), int.Parse(txtLado3.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve preencher os tres lados");
                return null;
            }
                            
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Se a tecla digitada não for um caracter de controle (ex. SHIFT, ALT, CTRL)
            {                                                           //ou se não for um dígito decimal atribui TRUE ao parâmetro KeyPressEventArguments.
                e.Handled = true;                                       // Isso faz com que o caracter não seja exibido.
            }

        }

        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Se a tecla digitada não for um caracter de controle (ex. SHIFT, ALT, CTRL)
            {                                                           //ou se não for um dígito decimal atribui TRUE ao parâmetro KeyPressEventArguments.
                e.Handled = true;                                       // Isso faz com que o caracter não seja exibido.
            }
        }

        private void txtLado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Se a tecla digitada não for um caracter de controle (ex. SHIFT, ALT, CTRL)
            {                                                           //ou se não for um dígito decimal atribui TRUE ao parâmetro KeyPressEventArguments.
                e.Handled = true;                                       // Isso faz com que o caracter não seja exibido.
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

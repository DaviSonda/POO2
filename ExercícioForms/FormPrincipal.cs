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
    public partial class FormPrincipal : Form
    {       
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuCalculaTriangulo_Click(object sender, EventArgs e)
        {
            new FormTriangulo().Show();
        }

        private void menuPesoPlanetas_Click(object sender, EventArgs e)
        {
           new FormPlanetas().Show();
        }

        private void menuCalculaJokenpo_Click(object sender, EventArgs e)
        {
            new FormJokenpo().Show();  
        }
    }
}

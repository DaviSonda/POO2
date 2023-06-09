using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinadoDavi
{
    public partial class CampoMinadoView : Form
    {
        private const int TamanhoJogo = 10;
        private Button[,] botoes;

        public CampoMinadoView()
        {
            CriaJogo();
            this.Size = new Size(320, 340);
        }

        private void CriaJogo()
        {
            botoes = new Button[TamanhoJogo, TamanhoJogo];
            Size = new Size(TamanhoJogo * 30, TamanhoJogo * 30);

            for (int i = 0; i < TamanhoJogo; i++)
            {
                for (int j = 0; j < TamanhoJogo; j++)
                {
                    Button button = new Button
                    {
                        Size = new Size(30, 30),
                        Location = new Point(i * 30, j * 30),
                        Tag = new Point(i, j)
                    };

                    button.MouseDown += Button_MouseDown;
                    Controls.Add(button);
                    botoes[i, j] = button;
                }
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Point location = (Point)button.Tag;
            int x = location.X;
            int y = location.Y;

            if (e.Button == MouseButtons.Left)
            {
                BotaoClicado(x, y, MouseButtons.Left);
            }
            else if (e.Button == MouseButtons.Right)
            {
                BotaoClicado(x, y, MouseButtons.Right);
            }
        }

        public event Action<int, int, MouseButtons> CliqueBotao;

        private void BotaoClicado(int x, int y, MouseButtons botao)
        {
            CliqueBotao?.Invoke(x, y, botao);
        }

        public void AtualizaBotao(int x, int y, string texto, Color corTexto, Color corFundo)
        {
            botoes[x, y].Text = texto;
            botoes[x, y].ForeColor = corTexto;
            botoes[x, y].BackColor = corFundo;
        }
    }
}

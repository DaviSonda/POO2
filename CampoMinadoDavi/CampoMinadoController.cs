using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinadoDavi
{
    public class CampoMinadoController
    {
        private const int TamanhoJogo = 10;
        private const int QuantidadeMinas = 20;

        private Cell[,] jogo;
        private CampoMinadoView view;

        public CampoMinadoController()
        {
            jogo = new Cell[TamanhoJogo, TamanhoJogo];
            view = new CampoMinadoView();
            view.CliqueBotao += View_ButtonClicked;
            IniciaJogo();
        }

        private void IniciaJogo()
        {
            for (int i = 0; i < TamanhoJogo; i++)
            {
                for (int j = 0; j < TamanhoJogo; j++)
                {
                    jogo[i, j] = new Cell(ItemCelula.Vazio, EstadoCelula.Coberta);
                }
            }

            Random random = new Random();
            int count = 0;
            while (count < QuantidadeMinas)
            {
                int x = random.Next(TamanhoJogo);
                int y = random.Next(TamanhoJogo);
                if (jogo[x, y].Content == ItemCelula.Vazio)
                {
                    jogo[x, y].Content = ItemCelula.Mina;
                    count++;
                }
            }
        }

        private void View_ButtonClicked(int x, int y, MouseButtons button)
        {
            if (button == MouseButtons.Left)
            {
                if (jogo[x, y].State == EstadoCelula.Coberta)
                {
                    if (jogo[x, y].Content == ItemCelula.Mina)
                    {
                        jogo[x, y].State = EstadoCelula.Descoberta;
                        view.AtualizaBotao(x, y, "X", Color.Red, Color.Gray);
                        MessageBox.Show("Você Perdeu!");
                        view.Close();
                    }
                    else if (QtdMinasProximas(x, y) == 0)
                    {
                        jogo[x, y].State = EstadoCelula.Descoberta;
                        view.AtualizaBotao(x, y, "", Color.Black, Color.White);
                        RevelaVizinhosVazios(x, y);
                    }
                    else
                    {
                        jogo[x, y].State = EstadoCelula.Descoberta;
                        int MinasProximas = QtdMinasProximas(x, y);
                        string textoBotao = MinasProximas.ToString();
                        Color corBotao = PegaCorNumero(MinasProximas);
                        view.AtualizaBotao(x, y, textoBotao, corBotao, Color.White);
                    }
                }
            }
            else if (button == MouseButtons.Right)
            {
                if (jogo[x, y].State == EstadoCelula.Coberta)
                {
                    jogo[x, y].State = EstadoCelula.Marcada;
                    view.AtualizaBotao(x, y, "F", Color.Red, Color.Gray);
                }
                else if (jogo[x, y].State == EstadoCelula.Marcada)
                {
                    jogo[x, y].State = EstadoCelula.Coberta;
                    view.AtualizaBotao(x, y, "", Color.Black, Color.LightGray);
                }
            }
        }

        private void RevelaVizinhosVazios(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < TamanhoJogo && j >= 0 && j < TamanhoJogo)
                    {
                        if (jogo[i, j].State == EstadoCelula.Coberta && jogo[i, j].Content != ItemCelula.Mina)
                        {
                            jogo[i, j].State = EstadoCelula.Descoberta;
                            int minasProximas = QtdMinasProximas(i, j);
                            string textoBotao = minasProximas > 0 ? minasProximas.ToString() : "";
                            Color corBotao = PegaCorNumero(minasProximas);
                            view.AtualizaBotao(i, j, textoBotao, corBotao, Color.White);

                            if (minasProximas == 0)
                            {
                                RevelaVizinhosVazios(i, j);
                            }
                        }
                    }
                }
            }
        }

        private int QtdMinasProximas(int x, int y)
        {
            int count = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < TamanhoJogo && j >= 0 && j < TamanhoJogo)
                    {
                        if (jogo[i, j].Content == ItemCelula.Mina)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        private Color PegaCorNumero(int number)
        {
            switch (number)
            {
                case 1:
                    return Color.Blue;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Red;
                case 4:
                    return Color.DarkBlue;
                case 5:
                    return Color.DarkRed;
                case 6:
                    return Color.Cyan;
                case 7:
                    return Color.Magenta;
                case 8:
                    return Color.Yellow;
                default:
                    return Color.Black;
            }
        }

        public void Run()
        {
            Application.Run(view);
        }

    }
}

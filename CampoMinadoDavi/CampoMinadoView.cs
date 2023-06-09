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
        private const int BoardSize = 10;
        private Button[,] buttons;

        public CampoMinadoView()
        {
            InitializeComponents();
            this.Size = new Size(320, 340);
        }

        private void InitializeComponents()
        {
            buttons = new Button[BoardSize, BoardSize];
            Size = new Size(BoardSize * 30, BoardSize * 30);

            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    Button button = new Button
                    {
                        Size = new Size(30, 30),
                        Location = new Point(i * 30, j * 30),
                        Tag = new Point(i, j)
                    };

                    button.MouseDown += Button_MouseDown;
                    Controls.Add(button);
                    buttons[i, j] = button;
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
                OnButtonClicked(x, y, MouseButtons.Left);
            }
            else if (e.Button == MouseButtons.Right)
            {
                OnButtonClicked(x, y, MouseButtons.Right);
            }
        }

        public event Action<int, int, MouseButtons> ButtonClicked;

        private void OnButtonClicked(int x, int y, MouseButtons button)
        {
            ButtonClicked?.Invoke(x, y, button);
        }

        public void UpdateButton(int x, int y, string text, Color textColor, Color backColor)
        {
            buttons[x, y].Text = text;
            buttons[x, y].ForeColor = textColor;
            buttons[x, y].BackColor = backColor;
        }
    }
}

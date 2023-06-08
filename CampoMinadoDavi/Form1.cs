using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinadoDavi
{
    public partial class Form1 : Form
    {
        private const int Size = 10; // Size of the grid
        private const int NumMines = 10; // Number of mines

        private Button[,] buttons;
        private bool[,] mines;
        private int[,] counts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[Size, Size];
            mines = new bool[Size, Size];
            counts = new int[Size, Size];

            // Initialize the buttons and add them to the form
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(30, 30);
                    button.Location = new Point(i * 30, j * 30);
                    button.MouseDown += new MouseEventHandler(Button_MouseDown);
                    button.Tag = new Point(i, j); // Store the cell position in the button's Tag property
                    Controls.Add(button);
                    buttons[i, j] = button;
                }
            }

            // Randomly place mines
            Random random = new Random();
            int mineCount = 0;

            while (mineCount < NumMines)
            {
                int i = random.Next(Size);
                int j = random.Next(Size);

                if (!mines[i, j])
                {
                    mines[i, j] = true;
                    mineCount++;
                }
            }

            // Calculate counts for each cell
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    int count = 0;

                    if (mines[i, j])
                    {
                        counts[i, j] = -1;
                        continue;
                    }

                    // Check adjacent cells
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            int nx = i + x;
                            int ny = j + y;

                            if (nx >= 0 && nx < Size && ny >= 0 && ny < Size && mines[nx, ny])
                            {
                                count++;
                            }
                        }
                    }

                    counts[i, j] = count;
                }
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Point position = (Point)button.Tag; // Retrieve the cell position from the button's Tag property
            int x = position.X;
            int y = position.Y;

            if (e.Button == MouseButtons.Left)
            {
                // Left mouse button is clicked
                if (mines[x, y])
                {
                    // Game over
                    button.BackColor = Color.Red;
                    MessageBox.Show("Game Over");
                }
                else
                {
                    // Show the count
                    button.Text = counts[x, y].ToString();
                    button.Enabled = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Right mouse button is clicked
                if (button.Text == "F")
                {
                    button.Text = ""; // Remove flag
                }
                else
                {
                    button.Text = "F"; // Mark as flagged
                }
            }
        }
    }

}

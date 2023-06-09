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
        private const int BoardSize = 10;
        private const int MineCount = 15;

        private Cell[,] board;
        private CampoMinadoView view;

        public CampoMinadoController()
        {
            board = new Cell[BoardSize, BoardSize];
            view = new CampoMinadoView();
            view.ButtonClicked += View_ButtonClicked;
            InitializeGame();
        }

        private void InitializeGame()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    board[i, j] = new Cell(CellContent.Empty, CellState.Covered);
                }
            }

            Random random = new Random();
            int count = 0;
            while (count < MineCount)
            {
                int x = random.Next(BoardSize);
                int y = random.Next(BoardSize);
                if (board[x, y].Content == CellContent.Empty)
                {
                    board[x, y].Content = CellContent.Mine;
                    count++;
                }
            }
        }

        private void View_ButtonClicked(int x, int y, MouseButtons button)
        {
            if (button == MouseButtons.Left)
            {
                if (board[x, y].State == CellState.Covered)
                {
                    if (board[x, y].Content == CellContent.Mine)
                    {
                        board[x, y].State = CellState.Uncovered;
                        view.UpdateButton(x, y, "X", Color.Red, Color.Gray);
                        MessageBox.Show("Game Over!");
                        view.Close();
                    }
                    else if (GetAdjacentMineCount(x, y) == 0)
                    {
                        board[x, y].State = CellState.Uncovered;
                        view.UpdateButton(x, y, "", Color.Black, Color.White);
                        RevealEmptyNeighbors(x, y);
                        // Handle logic for empty cell with no adjacent mines
                    }
                    else
                    {
                        board[x, y].State = CellState.Uncovered;
                        int adjacentMines = GetAdjacentMineCount(x, y);
                        string buttonText = adjacentMines.ToString();
                        Color buttonColor = GetNumberColor(adjacentMines);
                        view.UpdateButton(x, y, buttonText, buttonColor, Color.White);
                        // Handle logic for empty cell or cell with adjacent mines
                    }
                }
            }
            else if (button == MouseButtons.Right)
            {
                if (board[x, y].State == CellState.Covered)
                {
                    board[x, y].State = CellState.Flagged;
                    view.UpdateButton(x, y, "F", Color.Red, Color.Gray);
                }
                else if (board[x, y].State == CellState.Flagged)
                {
                    board[x, y].State = CellState.Covered;
                    view.UpdateButton(x, y, "", Color.Black, Color.LightGray);
                }
            }
        }

        private void RevealEmptyNeighbors(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < BoardSize && j >= 0 && j < BoardSize)
                    {
                        if (board[i, j].State == CellState.Covered && board[i, j].Content != CellContent.Mine)
                        {
                            board[i, j].State = CellState.Uncovered;
                            int adjacentMines = GetAdjacentMineCount(i, j);
                            string buttonText = adjacentMines > 0 ? adjacentMines.ToString() : "";
                            Color buttonColor = GetNumberColor(adjacentMines);
                            view.UpdateButton(i, j, buttonText, buttonColor, Color.White);

                            if (adjacentMines == 0)
                            {
                                RevealEmptyNeighbors(i, j);
                            }
                        }
                    }
                }
            }
        }

        private int GetAdjacentMineCount(int x, int y)
        {
            int count = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < BoardSize && j >= 0 && j < BoardSize)
                    {
                        if (board[i, j].Content == CellContent.Mine)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        private Color GetNumberColor(int number)
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

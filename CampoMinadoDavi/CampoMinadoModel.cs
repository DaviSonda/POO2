using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace CampoMinadoDavi
{
    public enum CellState
    {
        Covered,
        Uncovered,
        Flagged
    }

    public enum CellContent
    {
        Empty,
        Mine
    }

    public class Cell
    {
        public CellContent Content { get; set; }
        public CellState State { get; set; }

        public Cell(CellContent content, CellState state)
        {
            Content = content;
            State = state;
        }
    }
}

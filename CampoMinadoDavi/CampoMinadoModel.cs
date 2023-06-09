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
    public enum EstadoCelula
    {
        Coberta,
        Descoberta,
        Marcada
    }

    public enum ItemCelula
    {
        Vazio,
        Mina
    }

    public class Cell
    {
        public ItemCelula Content { get; set; }
        public EstadoCelula State { get; set; }

        public Cell(ItemCelula content, EstadoCelula state)
        {
            Content = content;
            State = state;
        }
    }
}

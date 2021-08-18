using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Domain.Models
{
    /// <summary>
    /// Defines properties of the board. Open for extension.
    /// </summary>
    public class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }

        public Board(int _rows, int _columns)
        {
            rows = _rows;
            columns = _columns;
        }
    }
}

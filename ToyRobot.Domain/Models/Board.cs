namespace ToyRobot.Domain.Models
{
    /// <summary>
    /// Defines properties of the board. Open for extension.
    /// </summary>
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public bool BoardIsInitialized { get; set; }

        public Board(int _rows, int _columns)
        {
            Rows = _rows;
            Columns = _columns;
        }
    }
}

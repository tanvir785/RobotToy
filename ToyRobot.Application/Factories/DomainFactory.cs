using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application
{
    /// <summary>
    /// Using Factory design patern here. Keeps the program less tightly coupled and provides an abstraction layer.
    /// The basic factory creates domain layer objects
    /// </summary>
    public class DomainFactory
    {
        public static Board CreateBoard()
        {
            return new Board(AppConstants.ROWS, AppConstants.COLUMNS);
        }
        public static Position CreatePosition()
        {
            return new Position(0, 0);
        }
        public static Position CreatePosition(int x, int y)
        {
            return new Position(x, y);
        }
        public static Robot CreateRobot()
        {
            return new Robot(AppConstants.NORTH, CreatePosition());
        }
        public static Robot CreateRobot(string direction, Position position)
        {
            return new Robot(direction, position);
        }
    }
}

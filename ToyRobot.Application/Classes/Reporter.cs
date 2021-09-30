using ToyRobot.Application.Exceptions;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Classes
{
    public class Reporter : IReporter
    {
        public string GetCurrentPosition(Robot robot, Board board)
        {
            if (!BLFactory.CreateValidator().isPositionIsValid(robot.Position, board)) { throw new InvalidPositionException(robot.Position); }

            return ($"{robot.Position.X},{robot.Position.Y},{robot.Direction}");
        }
    }
}

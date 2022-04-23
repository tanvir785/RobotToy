using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Classes
{
    public class Mover : IMover
    {
        private Position newPosition;

        private readonly IValidator _validator;
        public Mover(IValidator validator)
        {
            _validator = validator;
        }

        public void Move(Robot robot, Board board)
        {
            switch (robot.Direction)
            {
                case AppConstants.NORTH:
                    newPosition = DomainFactory.CreatePosition(robot.Position.X, (robot.Position.Y + 1));
                    break;
                case AppConstants.SOUTH:
                    newPosition = DomainFactory.CreatePosition(robot.Position.X, (robot.Position.Y - 1)); break;
                case AppConstants.EAST:
                    newPosition = DomainFactory.CreatePosition(robot.Position.X + 1, (robot.Position.Y)); break;
                case AppConstants.WEST:
                    newPosition = DomainFactory.CreatePosition((robot.Position.X - 1), robot.Position.Y); break;
                default: break;
            }
            if (_validator.isPositionIsValid(newPosition, board)) robot.Position = newPosition;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application.Exceptions;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Classes
{
    public class Reporter : IReporter
    {
        public string GetCurrentPosition(Robot robot, Board board)
        {
            if (!BLFactory.CreateValidator().isPositionIsValid(robot._position, board)) { throw new InvalidPositionException(robot._position); }

            return ($"{robot._position.X},{robot._position.Y},{robot.Direction}");
        }
    }
}

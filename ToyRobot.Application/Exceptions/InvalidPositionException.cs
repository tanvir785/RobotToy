using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Exceptions
{
    public class InvalidPositionException : Exception
    {
        public InvalidPositionException(Position position)
        : base($"Position: \"{position.X},{position.Y}\" is invalid.")
        {
        }
    }
}

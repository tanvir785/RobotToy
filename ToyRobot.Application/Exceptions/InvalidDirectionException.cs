using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Exceptions
{
    public class InvalidDirectionException : Exception
    {
        public InvalidDirectionException(string direction)
            : base($"Direction: \"{direction}\" is invalid.")
        {
        }
    }
}

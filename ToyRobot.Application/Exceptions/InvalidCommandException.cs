using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Application.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(string command)
                : base($"Command: \"{command}\" is invalid.")
        {
        }
    }
}

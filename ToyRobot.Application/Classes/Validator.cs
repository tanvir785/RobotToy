using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application.Exceptions;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Classes
{
    /// <summary>
    /// Extending Interface this will validate the app.
    /// </summary>
    public class Validator : IValidator
    {
        public bool isPositionIsValid(Position newPosition, Board board)
        {
            if (newPosition.X >= board.rows || newPosition.Y >= board.columns || newPosition.X < 0 || newPosition.Y < 0) throw new InvalidPositionException(newPosition);

            else return true;
        }

        public bool isDirectionIsValid(string direction)
        {
            return (AppConstants.ValidDirections.Contains(direction));
        }

        public bool isCommandIsValid (string command)
        {
            if (AppConstants.ValidCommands.Contains(command)) return true;
            else return false;
        }
    }
}

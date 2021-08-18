using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Interfaces
{
    /// <summary>
    /// Checks if Position or Direction is valid. Other validations reside here also.
    /// </summary>
    public interface IValidator
    {
        bool isPositionIsValid(Position position, Board board);
        bool isDirectionIsValid(string direction);
        bool isCommandIsValid(string command);
    }
}

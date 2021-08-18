using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Interfaces
{
    /// <summary>
    /// Outputs current position to 
    /// </summary>
    public interface IReporter
    {
        string GetCurrentPosition(Robot robot, Board board);
    }
}

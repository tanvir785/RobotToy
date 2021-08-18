using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Interfaces
{
    /// <summary>
    /// Change direction of Robot
    /// </summary>
    public interface IDirector
    {
        void Left(Robot robot); 
        void Right(Robot robot);
        void ChangeDirection(string turn, Robot robot);
    }
}

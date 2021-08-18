using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Interfaces
{
    public interface IMover
    {
        void Move(Robot robot, Board board);
    }
}

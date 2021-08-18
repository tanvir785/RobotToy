using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Domain.Models
{
    
/// <summary>
/// Defines current Co-Ordinates of the Toy Robot
/// </summary>
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

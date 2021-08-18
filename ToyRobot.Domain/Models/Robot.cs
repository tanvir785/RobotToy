using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Domain.Models
{
    /// <summary>
    /// Defines the properties of the ToyRobot
    /// It's attributes are it's position and direction
    /// </summary>
    public class Robot
    {
        public string Direction { get; set; }
        public Position _position { get; set; }
        public Robot(string direction, Position position)
        {
            Direction = direction;
            _position = position;
        }
    }
}

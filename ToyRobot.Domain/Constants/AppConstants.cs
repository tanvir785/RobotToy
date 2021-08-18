using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Domain.Constants
{
    public class AppConstants
    {

        public const string MOVE = "MOVE";
        public const string LEFT = "LEFT";
        public const string RIGHT = "RIGHT";
        public const string PLACE = "PLACE";
        public const string REPORT = "REPORT";

        public const string EAST = "EAST";
        public const string NORTH = "NORTH";
        public const string SOUTH = "SOUTH";
        public const string WEST = "WEST";

        //Board
        public const int rows = 6;
        public const int columns = 6;

        public static List<string> ValidCommands = new List<string> { MOVE, LEFT, RIGHT, PLACE, REPORT };
        public static List<string> ValidDirections = new List<string> { EAST,NORTH,SOUTH,WEST };
    }
}

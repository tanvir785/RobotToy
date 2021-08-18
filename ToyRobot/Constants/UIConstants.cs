using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Presentation
{
/// <summary>
/// Seperating UI constants that are used for parsing specifically to have some SOC.
/// </summary>
    public static class UIConstants
    {

        public const int xIndex = 1;
        public const int YIndex = 2;
        public const int directionIndex = 3;
        public static char[] delimiters = { ' ', ',' };

    }
}

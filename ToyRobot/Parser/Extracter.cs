using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Presentation
{
    /// <summary>
    /// Utility class to extract Words from UI.String "PLACE 0,0,NORTH" is translated to an array of ["PLACE","0","0","NORTH"]
    /// </summary>
    public class Extracter
    {
        public static string[] ExtractWords(string input, char[] delimiters)
        {
            string[] seperatedWords = input.Split(delimiters);
            return seperatedWords;
        }
    }
}

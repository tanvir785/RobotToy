using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application;
using ToyRobot.Application.Classes;
using ToyRobot.Application.Exceptions;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;
using ToyRobot.Presentation;

namespace ToyRobot.Presentation
{
    /// <summary>
    /// Parses Sample Input
    /// PLACE 0,0,NORTH
    /// MOVE / LEFT/ RIGHT
    /// REPORT
    /// </summary>
    public class InputParser
    {
        public string extractedDirection { get; set; }
        public Position extractedPosition { get; set; }
        public readonly IValidator _validator;
        public string command { get; set; }

        public InputParser(IValidator validator)
        {
            _validator = validator;
        }
        /// <summary>
        /// 1. Validation
        /// 2. If Validation passes then assign attributes (Command, Position, Direction) to be used in the program.
        /// 3. Throw error if any validation checks fail
        /// </summary>
        /// <param name="input"></param>
        /// <param name="board"></param>
        public void ParseInput(string input, Board board)
        { 
            //Validation Checks
            if (!(input.Length > 0)) { throw new InvalidCommandException(input); }

                //Place
            if (input.IndexOf(AppConstants.PLACE.ToString()) >= 0) {

                string[] seperatedStr = Extracter.ExtractWords(input, UIConstants.delimiters);

                //Position
                int x = int.Parse(seperatedStr[UIConstants.xIndex]);
                int y = int.Parse(seperatedStr[UIConstants.YIndex]);
                extractedPosition = DomainFactory.CreatePosition(x,y);

                if (!_validator.isPositionIsValid(extractedPosition, board)) { throw new InvalidPositionException(extractedPosition); }

                extractedDirection = seperatedStr[UIConstants.directionIndex];
                if (!_validator.isDirectionIsValid(extractedDirection)) { throw new InvalidDirectionException(extractedDirection);  }

                command = AppConstants.PLACE;
            }
            else
            {
                // Other commands -> Move,Left,right
                if(!_validator.isCommandIsValid(input)) throw new InvalidCommandException(input);
                command = input;
            }
        }
    }

}

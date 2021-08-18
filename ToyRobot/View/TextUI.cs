using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application;
using ToyRobot.Application.Exceptions;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Presentation.View
{
    public class TextUI
    {
        public static void CommandEntry(InputParser parser, InitApp app)
        {
            Console.WriteLine("Please enter command");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                try
                {
                    parser.ParseInput(input.ToUpper(), app._board);
                    if (parser.command.Equals(AppConstants.PLACE))
                    {
                        //Initialize Robot here -> Pass it to constructor.
                        //Robot -> exractedPosition, direction
                        Robot robot = DomainFactory.CreateRobot(parser.extractedDirection, parser.extractedPosition);
                        app = new InitApp(robot, app._board, BLFactory.CreateReporter(), BLFactory.CreateDirector(), BLFactory.CreateMover());
                    }
                    app._command = parser.command;

                    if (app._AppInitialized) app.ExecuteCommand();
                    else throw new InvalidCommandException(app._command);
                }
                catch (InvalidCommandException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidPositionException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please re-enter command.");
                }

                input = Console.ReadLine();
            }
        }
    }
}

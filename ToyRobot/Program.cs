using System;
using ToyRobot.Application;
using ToyRobot.Presentation.View;

namespace ToyRobot.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InputParser parser = new InputParser(BLFactory.CreateValidator());
            InitApp app = new InitApp();
            TextUI.CommandEntry(parser, app);
        } 
    }
}

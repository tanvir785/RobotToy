using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application;
using ToyRobot.Application.Classes;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;
using ToyRobot.Presentation;
using Xunit;

namespace ToyRobot.Tests
{
    public class TestToyRobotDirector
    {
        [Fact]

        public void TestSimpleLeftTurn()
        {
            string expected = "0,0,WEST";

            Robot robot = DomainFactory.CreateRobot();
            InitApp app = new InitApp(robot, DomainFactory.CreateBoard(), BLFactory.CreateReporter(), BLFactory.CreateDirector(), BLFactory.CreateMover());
            app.ExecuteCommand();

            app._command = AppConstants.LEFT;
            app.ExecuteCommand();
            string output = BLFactory.CreateReporter().GetCurrentPosition(app._robot, app._board);
            Assert.Equal(expected, output);
        }

        [Fact]
        public void TestFactoryReturnsCorrectType()
        {
            IBLFactory aValidator = BLFactory.Get<IValidator>();
            IBLFactory aReporter = BLFactory.Get<IReporter>();
            IBLFactory aDirector = BLFactory.Get<IDirector>();
            IBLFactory aMover = BLFactory.Get<IMover>();

            Assert.Equal(typeof(Validator), aValidator.GetType());
            Assert.Equal(typeof(Reporter), aReporter.GetType());
            Assert.Equal(typeof(Director), aDirector.GetType());
            Assert.Equal(typeof(Mover), aMover.GetType());
        }

        [Fact]
        public void TestComplexTurn()
        {
            string expected = "1,3,EAST";

            Position position = DomainFactory.CreatePosition();
            Robot robot = DomainFactory.CreateRobot();
            InitApp app = new InitApp(robot, DomainFactory.CreateBoard(), BLFactory.CreateReporter(), BLFactory.CreateDirector(), BLFactory.CreateMover());
            app.ExecuteCommand();

            app._command = AppConstants.RIGHT;  
            app.ExecuteCommand();
            app._command = AppConstants.MOVE;   //Should be 0,1
            app.ExecuteCommand();
            app._command = AppConstants.LEFT;   
            app.ExecuteCommand();
            app._command = AppConstants.MOVE;   //1,1
            app.ExecuteCommand();
            app._command = AppConstants.MOVE;   //1,2
            app.ExecuteCommand();
            app._command = AppConstants.MOVE;   //1,3,NORTH
            app.ExecuteCommand();
            app._command = AppConstants.RIGHT;  //1,3,EAST
            app.ExecuteCommand();

            string output = BLFactory.CreateReporter().GetCurrentPosition(app._robot, app._board);
            Assert.Equal(expected, output);
        }
    }
}

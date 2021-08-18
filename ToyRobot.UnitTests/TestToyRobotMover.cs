using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application;
using ToyRobot.Application.Exceptions;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;
using ToyRobot.Presentation;
using Xunit;

namespace ToyRobot.Tests
{
    public class TestToyRobotMover
    {
        [Fact]
        public void TestNorthMove()
        {
            string expected = "0,1,NORTH";

            Robot robot = DomainFactory.CreateRobot();
            InitApp app = new InitApp(robot, DomainFactory.CreateBoard(), BLFactory.CreateReporter(), BLFactory.CreateDirector(), BLFactory.CreateMover());
            app.ExecuteCommand();

            app._command = AppConstants.MOVE;
            app.ExecuteCommand();
            string output = BLFactory.CreateReporter().GetCurrentPosition(app._robot, app._board);
            Assert.Equal(expected, output);
        }

        [Fact]
        //Should fail
        public void TestComplexMove()
        {
            string expected = "3,3,NORTH";

            Robot robot = DomainFactory.CreateRobot();
            InitApp app = new InitApp(robot, DomainFactory.CreateBoard(), BLFactory.CreateReporter(), BLFactory.CreateDirector(), BLFactory.CreateMover());
            app.ExecuteCommand();

            app._command = AppConstants.MOVE;
            app.ExecuteCommand();
            app.ExecuteCommand();
            app._command = AppConstants.LEFT;
            app.ExecuteCommand();
            app._command = AppConstants.MOVE;
            app.ExecuteCommand();
            string output = BLFactory.CreateReporter().GetCurrentPosition(app._robot, app._board);
            Assert.Equal(expected, output);
        }
        [Fact]
        public void TestInvalidPosition()
        {
            Robot robot = DomainFactory.CreateRobot();
            InitApp app = new InitApp(robot, DomainFactory.CreateBoard(), BLFactory.CreateReporter(), BLFactory.CreateDirector(), BLFactory.CreateMover());
            app.ExecuteCommand();

            app._command = AppConstants.MOVE;
            app.ExecuteCommand();

            app._command = AppConstants.MOVE;
            app.ExecuteCommand();
            app.ExecuteCommand();
            app._command = AppConstants.LEFT;
            app.ExecuteCommand();
            app._command = AppConstants.MOVE;
            Exception ex = Assert.Throws<InvalidPositionException>(() => app.ExecuteCommand());
            Assert.Equal("Position: \"-1,3\" is invalid.", ex.Message);
        }
    }
}

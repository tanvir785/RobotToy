using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application;
using Xunit;

namespace ToyRobot.Tests
{
    public class TestToyRobotReporter
    {
        [Fact]
        public void TestInitialPositionReport()
        {
            string expected = "0,0,NORTH";
            string output = BLFactory.CreateReporter().GetCurrentPosition(DomainFactory.CreateRobot(), DomainFactory.CreateBoard());
            Assert.Equal(expected, output);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application.Classes
{ 
    /// <summary>
    /// Business logic layer. Contains most of the Application logic.
    /// </summary>
    public class Director : IDirector
    {
        private readonly IValidator _validator;
        public Director(IValidator validator)
        {
            _validator = validator;
        }
        public void Left(Robot robot)
        {
            switch (robot.Direction)
            {
                case AppConstants.NORTH:
                    robot.Direction = AppConstants.WEST;
                    break;
                case AppConstants.SOUTH:
                    robot.Direction = AppConstants.EAST;
                    break;
                case AppConstants.EAST:
                    robot.Direction = AppConstants.NORTH;
                    break;
                case AppConstants.WEST:
                    robot.Direction = AppConstants.SOUTH;
                    break;
                default: break;
            }
        }

        public void Right (Robot robot)
        {
            switch (robot.Direction)
            {
                case AppConstants.NORTH:
                    robot.Direction = AppConstants.EAST;
                    break;
                case AppConstants.SOUTH:
                    robot.Direction = (AppConstants.WEST);
                    break;
                case AppConstants.EAST:
                    robot.Direction = AppConstants.SOUTH;
                    break;
                case AppConstants.WEST:
                    robot.Direction = AppConstants.NORTH;
                    break;
                default: break;
            }
        }
        public void ChangeDirection(string turn, Robot robot)
        {
            switch (robot.Direction)
            {
                case AppConstants.NORTH:
                    robot.Direction = AppConstants.EAST;
                    break;
                case AppConstants.SOUTH:
                    robot.Direction = AppConstants.WEST;
                    break;
                case AppConstants.EAST:
                    robot.Direction = AppConstants.SOUTH;
                    break;
                case AppConstants.WEST:
                    robot.Direction = AppConstants.NORTH;
                    break;
                default: break;
            }

        }
    }
}

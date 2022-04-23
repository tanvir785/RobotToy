using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application.Classes;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Application
{
    /// <summary>
    /// Using Factory design patern here. Keeps the program less tightly coupled and provides an abstraction layer.
    /// Business logic factory 
    /// </summary>
    public static class BLFactory
    {
        public static IBLFactory Get<T>()
        {
            if(typeof(T).IsAssignableFrom(typeof(IValidator)))
            {
                return CreateValidator();
            }

            else if (typeof(T).IsAssignableFrom(typeof(IReporter)))
            {
                return CreateReporter();
            }

            else if (typeof(T).IsAssignableFrom(typeof(IDirector)))
            {
                return CreateDirector();
            }

            else if(typeof(T).IsAssignableFrom(typeof(IMover)))
            {
                return CreateMover();
            }
            else return null;
        }

        public static IValidator CreateValidator()
        {
            return new Validator();
        }
        public static IReporter CreateReporter()
        {
            return new Reporter();
        }

        public static IDirector CreateDirector()
        {
            return new Director(CreateValidator());
        }

        public static IMover CreateMover()
        {
            return new Mover(CreateValidator());
        }
    }
}

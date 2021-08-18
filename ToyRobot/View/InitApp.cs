using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Application;
using ToyRobot.Application.Classes;
using ToyRobot.Application.Interfaces;
using ToyRobot.Domain.Constants;
using ToyRobot.Domain.Models;

namespace ToyRobot.Presentation
{
    public class InitApp
    {
        private readonly Position _position;
        private readonly string _direction;
        private readonly IReporter _reporter;
        private readonly IDirector _director;
        private readonly IMover _mover;

        public string _command;
        public Robot _robot;
        public Board _board;

        public bool _AppInitialized = false;    //<-- Keeps check on if program is good for other execution and if Place command has been issued.
        public InitApp()
        {
            _board = DomainFactory.CreateBoard();
        }
        public InitApp(Robot robot, Board board, IReporter reporter, IDirector director, IMover mover)
        {
            _robot = robot;
            _board = board;
            _reporter = reporter;
            _director = director;
            _mover = mover;
            _AppInitialized = true;
        }

        public void ExecuteCommand()
        {
            switch (_command)
            {
                case AppConstants.MOVE:
                    _mover.Move(_robot, _board);
                    break;
                case AppConstants.LEFT:
                    _director.Left(_robot);
                    break;
                case AppConstants.RIGHT:
                    _director.Right(_robot);
                    break;
                case AppConstants.REPORT:
                    Console.WriteLine(_reporter.GetCurrentPosition(_robot, _board));
                    break;
            }
        }
    }
}

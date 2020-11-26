using System;
using HepsiBurada.Business.Abstract;
using HepsiBurada.Core.Concrete;
using HepsiBurada.Core.Enum;
using HepsiBurada.Core.Constant;

namespace HepsiBurada.Business.Concrete
{
    public class RoverService : IRoverService
    {
        public PlaceDirectionEnum PlaceDirection = PlaceDirectionEnum.North;
        private readonly Rover _rover;
        private readonly PlaceService _placeService;
        public RoverService(Rover rover, PlaceService placeService)
        {
            _rover = rover;
            _placeService = placeService;
        }

        public void SetPosition(Rover rover)
        {
            PlaceDirection = rover.PlaceDirection;
        }

        public string GetPosition(Rover rover)
        {
            return $"{rover.Position.PositionX} {rover.Position.PositionY} {rover.PlaceDirection}";
        }

        public void Process(string command)
        {
            foreach (char item in command)
            {
                Operation(item);
            }
        }

        public void Operation(char command)
        {
            if (RoverConstant.RoverL == command)
                TurnLeft();
            else if (RoverConstant.RoverR == command)
                TurnRight();
            else if (RoverConstant.RoverM == command)
                Move();
            else
            {
                Console.WriteLine("Parameter values can be L, R and M");
            }
        }

        public bool Move()
        {
            Console.WriteLine(_placeService.IsMove(_rover.Position.PositionX, _rover.Position.PositionY));
            if (!_placeService.IsMove(_rover.Position.PositionX, _rover.Position.PositionY)) return false;

            Console.WriteLine(_rover.PlaceDirection);
            if (PlaceDirection == PlaceDirectionEnum.North)
                _rover.Position.PositionY += 1;
            else if (PlaceDirection == PlaceDirectionEnum.East)
                _rover.Position.PositionX += 1;
            else if (PlaceDirection == PlaceDirectionEnum.South)
                _rover.Position.PositionY -= 1;
            else if (PlaceDirection == PlaceDirectionEnum.West)
                _rover.Position.PositionX -= 1;

            return true;
        }

        public void TurnLeft()
        {
            PlaceDirection = (int)PlaceDirection - 1 < (int)PlaceDirectionEnum.North ?
                PlaceDirectionEnum.West : (PlaceDirectionEnum)((int)PlaceDirection - 1);
        }

        public void TurnRight()
        {
            PlaceDirection = (int)PlaceDirection + 1 > (int)PlaceDirectionEnum.West ?
                PlaceDirectionEnum.North : (PlaceDirectionEnum)((int)PlaceDirection + 1);
        }
    }
}
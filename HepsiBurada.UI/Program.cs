using System;
using HepsiBurada.Business.Concrete;
using HepsiBurada.Core.Concrete;
using HepsiBurada.Core.Enum;

namespace HepsiBurada.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var place = new Place { PointX = 5, PointY = 5 };
            var placeService = new PlaceService(place);
            var rover = new Rover
            {
                Place = place,
                Position = new Position { PositionX = 1, PositionY = 2 },
                PlaceDirection = PlaceDirectionEnum.North
            };

            var roverService = new RoverService(rover, placeService);
            roverService.Process("LMLMLMLMM");
            Console.WriteLine(roverService.GetPosition(rover)); // 1 3 N

            var rover2 = new Rover
            {
                Place = place,
                Position = new Position { PositionX = 3, PositionY = 3 },
                PlaceDirection = PlaceDirectionEnum.East
            };
            var roverService2 = new RoverService(rover2, placeService);
            roverService2.SetPosition(rover2);
            roverService2.Process("MMRMMRMRRM");
            Console.WriteLine(roverService.GetPosition(rover2)); // 5 1 E
            Console.ReadKey();
        }
    }
}
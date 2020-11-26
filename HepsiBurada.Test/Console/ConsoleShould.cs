using System.Threading.Tasks;
using HepsiBurada.Business.Concrete;
using HepsiBurada.Core.Concrete;
using HepsiBurada.Core.Enum;
using Xunit;

namespace HepsiBurada.Test.Console
{
    public class ConsoleShould
    {
        [Fact]
        public async Task Set_Process()
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
            roverService.SetPosition(rover);
            roverService.Process("LMLMLMLMM");
            var result = roverService.GetPosition(rover); // prints 1 3 N

            var textResult = "1 3 North";
            Assert.Equal(textResult, result);
        }
    }
}
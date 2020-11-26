using System.Threading.Tasks;
using FizzWare.NBuilder;
using HepsiBurada.Business.Abstract;
using HepsiBurada.Core.Concrete;
using Moq;
using Xunit;

namespace HepsiBurada.Test.Business
{
    public class RoverServiceShould
    {
        [Fact]
        public async Task Set_Position()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var rover = await Task.FromResult<Rover>(Builder<Rover>.CreateNew().Build());
            var result = roverServiceMock.Setup(m => m.SetPosition(rover));
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Get_Position()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var rover = await Task.FromResult<Rover>(Builder<Rover>.CreateNew().Build());
            var result = roverServiceMock.Setup(m => m.GetPosition(rover));
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Process()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var result = roverServiceMock.Setup(m => m.Process("LMLMLMLMM"));
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Operation()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var result = roverServiceMock.Setup(m => m.Operation('L'));
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Move()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var result = roverServiceMock.Setup(m => m.Move());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Turn_Left()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var result = roverServiceMock.Setup(m => m.TurnLeft());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Turn_Right()
        {
            var roverServiceMock = new Mock<IRoverService>();
            var result = roverServiceMock.Setup(m => m.TurnRight());
            Assert.NotNull(result);
        }
    }
}

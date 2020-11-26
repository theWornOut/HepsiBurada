using System.Threading.Tasks;
using HepsiBurada.Business.Abstract;
using Moq;
using Xunit;

namespace HepsiBurada.Test.Business
{
    public class PositionServiceShould
    {
        [Fact]
        public async Task Get_Position()
        {
            var positionServiceMock = new Mock<IPositionService>();
            var result = positionServiceMock.Setup(m => m.GetPosition());
            Assert.NotNull(result);
        }
    }
}
using System.Threading.Tasks;
using HepsiBurada.Business.Abstract;
using Moq;
using Xunit;

namespace HepsiBurada.Test.Business
{
    public class PlaceServiceShould
    {
        [Fact]
        public async Task Is_Move()
        {
            var placeServiceMock = new Mock<IPlaceService>();
            var result = placeServiceMock.Setup(m => m.IsMove(3, 4));
            Assert.NotNull(result);
        }
    }
}
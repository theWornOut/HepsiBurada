using HepsiBurada.Business.Abstract;
using HepsiBurada.Core.Concrete;

namespace HepsiBurada.Business.Concrete
{
    public class PlaceService : IPlaceService
    {
        private readonly Place _place;
        public PlaceService(Place place)
        {
            _place = place;
        }

        public bool IsMove(int positionX, int positionY)
        {
            return _place.StartPointX <= positionX &&
                   _place.StartPointY <= positionY &&
                   positionX <= _place.PointX &&
                   positionY <= _place.PointY;
        }
    }
}
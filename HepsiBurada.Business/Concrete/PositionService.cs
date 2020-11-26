using HepsiBurada.Business.Abstract;
using HepsiBurada.Core.Concrete;

namespace HepsiBurada.Business.Concrete
{
    public class PositionService : IPositionService
    {
        private readonly Position _position;
        public PositionService(Position position)
        {
            _position = position;
        }

        public string GetPosition()
        {
            return $"{_position.PositionX} {_position.PositionY}";
        }
    }
}
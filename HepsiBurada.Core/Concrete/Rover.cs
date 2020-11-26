using HepsiBurada.Core.Abstract;
using HepsiBurada.Core.Enum;

namespace HepsiBurada.Core.Concrete
{
    public class Rover : IEntity
    {
        public Place Place { get; set; }
        public Position Position { get; set; }
        public PlaceDirectionEnum PlaceDirection { get; set; }
    }
}
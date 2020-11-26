using HepsiBurada.Core.Abstract;

namespace HepsiBurada.Core.Concrete
{
    public class Place : IEntity
    {
        public int StartPointX { get; }
        public int StartPointY { get; }
        public int PointX { get; set; }
        public int PointY { get; set; }

        public Place()
        {
            StartPointX = 0;
            StartPointY = 0;
        }
    }
}
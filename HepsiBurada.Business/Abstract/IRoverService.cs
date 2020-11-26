using HepsiBurada.Core.Concrete;

namespace HepsiBurada.Business.Abstract
{
    public interface IRoverService
    {
        void SetPosition(Rover rover);
        string GetPosition(Rover rover);
        void Process(string command);
        void Operation(char command);
        bool Move();
        void TurnLeft();
        void TurnRight();
    }
}
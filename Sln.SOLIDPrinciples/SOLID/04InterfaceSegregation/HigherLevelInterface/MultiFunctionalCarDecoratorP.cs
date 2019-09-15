using SOLID._04InterfaceSegregation.WithISP;

namespace SOLID._04InterfaceSegregation.HigherLevelInterface
{
    public class MultiFunctionalCarDecoratorP
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public MultiFunctionalCarDecoratorP(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}

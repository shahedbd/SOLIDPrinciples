using System;

namespace SOLID._04InterfaceSegregation.HigherLevelInterface
{
    public class MultiFunctionalCar : IMultiFunctionalVehicle
    {
        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}

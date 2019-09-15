using System;

namespace SOLID._04InterfaceSegregation
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}

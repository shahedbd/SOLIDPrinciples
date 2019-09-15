using System;

namespace SOLID._04InterfaceSegregation.WithISP
{
    public class Car : ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}

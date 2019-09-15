using System;

namespace SOLID._04InterfaceSegregation.WithISP
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}

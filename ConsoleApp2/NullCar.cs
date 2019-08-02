using System;

namespace Factory1
{
    internal class NullCar : IAuto
    {
        public void TurnOff()
        {
        }

        public void TurnOn()
        {
            Console.WriteLine("car not found");
        }
    }
}
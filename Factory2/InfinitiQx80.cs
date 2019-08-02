using System;

namespace Factory2
{
    internal class InfinitiQx80 : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine($"goodbye");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Infiniti QX80 started");
        }
    }
}
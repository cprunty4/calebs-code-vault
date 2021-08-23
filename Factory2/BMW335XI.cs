using System;

namespace Factory2
{
    internal class BMW335XI : IAuto
    {
        public BMW335XI()
        {

        }
        public void TurnOff()
        {
            Console.WriteLine("bmw 335i coupe shutoff");
        }

        public void TurnOn()
        {
            Console.WriteLine("bmw 335i coupe started");
            Console.WriteLine("vrrroommm");
        }
    }
}
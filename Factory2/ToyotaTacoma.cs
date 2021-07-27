using System;

namespace Factory2
{
    public class ToyotaTacmoa : IAuto
    {
        public ToyotaTacmoa()
        {

        }

        public void TurnOff()
        {
            Console.WriteLine("Taco shutoff");
        }

        public void TurnOn()
        {
           Console.WriteLine("Start Tacoma SR5");
           Console.WriteLine("BRRRRRRR");
        }
    }
}
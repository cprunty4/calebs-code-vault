using System;

namespace Factory2
{
    public class DodgeChallenger : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("dodge challenger shut off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Dodge Challenger SRT Hellcat started");
            Console.WriteLine("VRRRRROOOMMMMM!!!!");
            Console.WriteLine("POP POP POP POP");
                       
        }
    }
}
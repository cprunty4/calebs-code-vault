using System;

namespace Factory2
{

    public class ToyotaCorolla : IAuto
    {
        public ToyotaCorolla ()
        {

        }

        public void TurnOn ()
        {
            Console.WriteLine ("Toyota Corolla LE started!");
        }

        public void TurnOff ()
        {
            Console.WriteLine ("Toyota Corolla LE stopped.");
        }
    }

}
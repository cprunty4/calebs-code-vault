using System;

namespace Factory2
{
    internal class InfinitiG37X : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Infiniti G37X started");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Infiniti G37X started");
        }
    }
}
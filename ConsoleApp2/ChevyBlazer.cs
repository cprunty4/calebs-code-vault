using System;
using System.Collections.Generic;
using System.Text;

namespace Factory1
{
    public class ChevyBlazer : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("blazer shut off");
        }

        public void TurnOn()
        {
            Console.WriteLine("blazer started");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory2
{
    public class ChevySuburban : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Suburban LT shut off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Suburban LT started");
            Console.WriteLine("vrrrooomm brrrr");1
        }
    }
}

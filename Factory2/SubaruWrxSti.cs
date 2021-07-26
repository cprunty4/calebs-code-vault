using System;

namespace Factory2
{
    internal class SubaruWrxSti : IAuto
    { 
        
 
        public void TurnOff()
        {
            Console.WriteLine("Subaru WRX STI shut off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Subaru WRX STI started!");
            Console.WriteLine("VRRRRROOOOMMMM!");            
            Console.WriteLine("STUTUTUTU!");
        }

    }
}
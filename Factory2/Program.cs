using System;

namespace Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();
        }
    }
}

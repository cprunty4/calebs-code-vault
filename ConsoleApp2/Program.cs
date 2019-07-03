using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            IAuto car = GetCar(carName);

            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();

        }

        private static IAuto GetCar(string carName)
        {
            switch(carName)
            {
                case "bmw":
                    return new BMW335XI();
                default:
                    return new NullCar();
            }
        }
    }
}

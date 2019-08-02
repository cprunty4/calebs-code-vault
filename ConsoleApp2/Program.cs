using System;

namespace Factory1
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
                case "infiniti":
                    return new InfinitiQx80();
                case "blazer":
                    return new ChevyBlazer();
                default:
                    return new NullCar();
            }
        }
    }
}

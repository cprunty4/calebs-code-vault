using System;

namespace Decorator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();

            largePizza = new Cheese(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}

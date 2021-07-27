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

            Pizza largePinapplePizza = new LargePizza();

            largePinapplePizza = new Cheese(largePinapplePizza);

            largePinapplePizza = new Pineapple(largePinapplePizza);

            Console.WriteLine(largePinapplePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePinapplePizza.CalculateCost());            

            Console.ReadKey();
        }
    }
}

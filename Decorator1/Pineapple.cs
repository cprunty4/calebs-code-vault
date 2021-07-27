using Decorator1;

namespace Decorator1
{
    public class Pineapple : PizzaDecorator
    {
        public Pineapple(Pizza pizza) : base(pizza)
        {
            Description = "Pineapple";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 0.50;
        }        
    }
}
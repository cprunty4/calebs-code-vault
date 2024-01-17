using Decorator1;

namespace Decorator1
{
    public class CanadianBacon : PizzaDecorator
    {
        public CanadianBacon(Pizza pizza) : base(pizza)
        {
            Description = "Canadian Bacon";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.50;
        }        
    }
}
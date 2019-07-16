using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return _pizza.Description;
        }
    }
}

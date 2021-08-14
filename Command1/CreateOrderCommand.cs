using System;

namespace Command1
{
    internal class CreateOrderCommand : ICommandFactory, ICommand
    {
        public string CommandName => "CreateOrder";

        public string Description => "This is CreateOrderCommand's Description";

        public void Execute()
        {
            Console.WriteLine($"Description {Description}");
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new CreateOrderCommand();
        }
    }
}
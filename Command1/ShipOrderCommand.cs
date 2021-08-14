using System;

namespace Command1
{
    internal class ShipOrderCommand : ICommandFactory, ICommand
    {
        public string CommandName => "ShipOrder";

        public string Description => "This is ShipOrder's description.";

        public void Execute()
        {
            Console.WriteLine($"description {Description}");
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new ShipOrderCommand();
        }
    }
}
using System;

namespace Command1
{
    internal class UpdateQuantityCommand : ICommandFactory, ICommand
    {
        public string CommandName => "UpdateQuantity";

        public string Description => string.Empty;

        public int NewQuantity { get; set; }

        public void Execute()
        {
            Console.WriteLine("Database updated");
        }

        public ICommand MakeCommand(string[] arguments)
        {
           return new UpdateQuantityCommand { NewQuantity = int.Parse(arguments[1])};
        }
    }
}
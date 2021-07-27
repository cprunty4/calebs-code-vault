using System;

namespace Command1
{
    internal class NotFoundCommand : ICommand
    {
        public string Name => "command not found";

        public void Execute()
        {
            Console.WriteLine("command not found!");
        }

    }
}
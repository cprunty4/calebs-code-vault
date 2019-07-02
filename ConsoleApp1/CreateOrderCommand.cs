namespace ConsoleApp1
{
    internal class CreateOrderCommand : ICommandFactory, ICommand
    {
        public string CommandName => throw new System.NotImplementedException();

        public string Description => throw new System.NotImplementedException();

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public ICommand MakeCommand(string[] arguments)
        {
            throw new System.NotImplementedException();
        }
    }
}
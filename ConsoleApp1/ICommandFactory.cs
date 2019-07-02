namespace ConsoleApp1
{
    internal interface ICommandFactory
    {
        string CommandName { get;}
        string Description { get;}

        ICommand MakeCommand(string[] arguments);
    }
}
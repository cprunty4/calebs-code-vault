using System;
using System.Collections.Generic;
using System.Linq;

namespace Command1
{
    internal class CommandParser
    {
        private IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);

            if (command == null)
                return new NotFoundCommand();

            return command.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommand(string requestedCommandName)
        {
            return availableCommands
                .FirstOrDefault(cmd => cmd.CommandName.ToLower().Contains(requestedCommandName.ToLower()));
        }
    }
}
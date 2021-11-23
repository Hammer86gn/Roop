using System;
using System.Collections.Generic;

namespace ROOP.CLI.command
{
    public class CommandManager
    {
        private static CommandManager instance;
        private Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

        private CommandManager()
        {
            instance = this;
        }

        public void registerCommand(ICommand command)
        {
            this.commands.Add(command.getName(), command);
        }

        public ICommand getCommand(string name)
        {
            return this.commands[name];
        }

        public static CommandManager getInstance()
        {
            return instance == null ? new CommandManager() : instance;
        }
        
    }
}
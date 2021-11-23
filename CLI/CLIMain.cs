using System;
using System.Collections.Generic;
using System.Linq;
using ROOP.CLI.command;
using ROOP.CLI.command.impl;

namespace ROOP.CLI
{
    public class CLIMain
    {
        public static void Main(string[] args)
        {
            CommandManager.getInstance().registerCommand(new InitCommand());

            string commmandName = args[0];

            ICommand command = CommandManager.getInstance().getCommand(commmandName);

            if (command == null)
            {
                Console.WriteLine("Could not find command \"" + commmandName + "\" use help for a list of commands");
                return;
            }

            List<string> cmdArgs = args.OfType<string>().ToList();
            cmdArgs.RemoveAt(0);

            command.execute(cmdArgs);
        }
    }
}
using System;
using System.Collections.Generic;

namespace ROOP.CLI.command
{
    public interface ICommand
    {
        String getName();

        void execute(List<string> args);
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace ROOP.CLI.command.impl
{
    public class InitCommand : ICommand
    {
        int totalDirs = 8;
        int completedDirs = 0;
        public string getName()
        {
            return "init";
        }

        public void execute(List<string> args)
        {
            string projectName = "robloxProject";
            if (args[0] != null)
            {
                projectName = args[0];
            }
            
            Console.WriteLine("Creating ROOP project in current directory");
            
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/Workspace");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/Players");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/ReplicatedFirst");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/ReplicatedStorage");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/ServerScriptService");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/ServerStorage");
            this.stateDirCreate();
            Directory.CreateDirectory(Environment.CurrentDirectory + "/" + projectName + "/game/Chat");
            this.stateDirCreate();
            
            Console.WriteLine("Directories created! Thank you for using ROOP!");
        }

        private void stateDirCreate()
        {
            completedDirs++;
            Console.WriteLine("{0}/{1} Directories created", totalDirs, completedDirs);
        }

    }
    
    
}
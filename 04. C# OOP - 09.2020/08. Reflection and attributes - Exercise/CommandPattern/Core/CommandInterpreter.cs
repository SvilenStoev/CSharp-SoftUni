using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Models.Commands
{
    class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";
        public CommandInterpreter()
        {

        }

        public string Read(string args)
        {
            string commandName = args.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0] + COMMAND_POSTFIX;

            string[] commandArgs = args.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray().Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == commandName.ToLower());

            if (commandType == null)
            {
                throw new ArgumentException("Invalid command type");
            }

            var currCommand = (ICommand)Activator.CreateInstance(commandType);

            string result = currCommand.Execute(commandArgs);

            return result;
        }
    }
}

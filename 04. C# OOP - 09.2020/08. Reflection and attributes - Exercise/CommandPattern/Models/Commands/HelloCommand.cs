using CommandPattern.Core.Contracts;

namespace CommandPattern.Models.Commands
{
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string result = "No arguments!";

            if (args.Length != 0)
            {
                result = $"Hello, {args[0]}";
            }

            return result;
        }
    }
}

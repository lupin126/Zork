using System;

namespace Zork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFileName = "Zork.json";
            string gameFileName = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultGameFileName);

            ConsoleInputService input = new ConsoleInputService();
            ConsoleOutputService output = new ConsoleOutputService();

            Game.StartFromFile(gameFileName, input, output);
            Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");

            while (Game.Instance.IsRunning)
            {
                output.Write("\n> ");
                input.GetInput();
            }

            output.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }
    }
}
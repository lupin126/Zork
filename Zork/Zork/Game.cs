using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }



        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Run()
        {
            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Player.CurrentLocation);

                if (Player.PreviousLocation != Player.CurrentLocation)
                {
                    Console.WriteLine(Player.CurrentLocation.Description);
                    Player.PreviousLocation = Player.CurrentLocation;
                }

                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine(ExitMessage);
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(Player.CurrentLocation.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        //if (Player.Move(direction) == false)
                        //{
                        //    Console.WriteLine("The way is shut!");
                        //}
                        //break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
            Console.WriteLine("Finished.");
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
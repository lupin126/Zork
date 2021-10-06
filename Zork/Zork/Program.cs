using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Zork
{
    class Program
    {
        private static Room Location
        {
            get
            {
                return Rooms[LocationRow, LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            const string roomDescriptionsFilename = "Rooms.txt";

            InitializeRoomDescriptions(roomDescriptionsFilename);

            Room previousLocation = null;

            while (true)
            {
                Console.WriteLine(Location.Name);

                if (previousLocation != Location)
                {
                    Console.WriteLine(Location.Description);
                    previousLocation = Location;
                }

                Console.Write("> ");

                Commands command = ToCommand(Console.ReadLine().Trim());

                if (command == Commands.QUIT)
                {
                    break;
                }

                string outputString;
                switch (command)
                {
                    case Commands.LOOK:
                       outputString = Location.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
            Console.WriteLine("Thank you for playing!\nFinished.") ;
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when LocationRow > 0:
                    LocationRow--;
                    didMove = true;
                    break;

                case Commands.SOUTH when LocationRow < Rooms.GetLength(0) - 1:
                    LocationRow++;
                    didMove = true;
                    break;

                case Commands.EAST when LocationColumn < Rooms.GetLength(1) - 1:
                    LocationColumn++;
                    didMove = true;
                    break;

                case Commands.WEST when LocationColumn > 0:
                    LocationColumn--;
                    didMove = true;
                    break;
            }

            return didMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static void InitializeRoomDescriptions(string roomDescriptionsFilename)
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap[room.Name] = room;
            }

            string[] lines = File.ReadAllLines(roomDescriptionsFilename);
            foreach (string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2;

                string[] fields = line.Split(delimiter);
                if (fields.Length != expectedFieldCount)
                {
                    throw new Exception("Invalid Record");
                }

                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);
                roomMap[name].Description = description;
            }
        }

        private static Room[,] Rooms =
        {
            {new Room("Dense Woods"),   new Room("North of House"),   new Room("Clearing") },
            {new Room("Forest"),        new Room("West of House"),    new Room("Behind House") },
            {new Room("Rocky Trail"),   new Room("South of House"),   new Room("Canyon View") }
        };

        private enum Fields
        {
            Name = 0,
            Description = 1
        }

        private static int LocationColumn = 1;
        private static int LocationRow = 1;
    }
}
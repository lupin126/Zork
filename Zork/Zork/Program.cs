using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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

            const string roomsFilename = "Rooms.json";

            InitializeRooms(roomsFilename);

            Room previousLocation = null;

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.WriteLine(Location.Name);

                if (previousLocation != Location)
                {
                    Console.WriteLine(Location.Description);
                    previousLocation = Location;
                }

                Console.Write("> ");

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

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
            Console.WriteLine("Finished.") ;
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

        private static void InitializeRooms(string roomsFilename)
        {
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));
        }

        private static Room[,] Rooms;

        private static int LocationColumn = 1;
        private static int LocationRow = 1;
    }
}
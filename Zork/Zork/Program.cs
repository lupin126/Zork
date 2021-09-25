using System;
using System.Linq;
using System.Collections.Generic;

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

            InitializeRoomDescriptions();

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

            Console.WriteLine("Finished.");
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

        private static void InitializeRoomDescriptions()
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                roomMap[room.Name] = room;
            }

            roomMap["Dense Woods"].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
            roomMap["North of House"].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Clearing"].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
            roomMap["Forest"].Description = "This is a forest, with trees in all directions around you.";
            roomMap["West of House"].Description = "This is an open field west of a white house, with a boarded front door.";
            roomMap["Behind House"].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";
            roomMap["Rocky Trail"].Description = "You are on a rock-strewn trail.";
            roomMap["South of House"].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Canyon View"].Description = "You are at the top of the Great Canyon on its south wall.";
        }

        private static Room[,] Rooms =
        {
            {new Room("Dense Woods"),   new Room("North of House"),   new Room("Clearing") },
            {new Room("Forest"),        new Room("West of House"),    new Room("Behind House") },
            {new Room("Rocky Trail"),   new Room("South of House"),   new Room("Canyon View") }
        };
        private static int LocationColumn = 1;
        private static int LocationRow = 1;
    }
}
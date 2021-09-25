﻿namespace Zork
{
    public class Room
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Room(string name, string description = null)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Linq;
using Newtonsoft.Json;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        [JsonIgnore]
        public Room CurrentLocation { get; set; }

        [JsonIgnore]
        public Room PreviousLocation { get; set; }

        public Player(World world, string startingLocation)
        {
            World = world;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = (CurrentLocation.Neighbors.TryGetValue(direction, out Room neighbor));
            if (isValidMove)
            {
                CurrentLocation = neighbor;
            }

            return isValidMove;
        }
    }
}
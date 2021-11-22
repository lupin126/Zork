using System;
using Newtonsoft.Json;

namespace Zork
{
    public class Player
    {
        public event EventHandler<Room> LocationChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location
        {
            get
            {
                return _location;
            }
            private set
            {
                if (_location != value)
                {
                    _location = value;
                    LocationChanged?.Invoke(this, _location);
                }
            }
        }

        public string LocationName
        {
            get { return Location?.Name; }
            set => Location = World?.RoomsByName.GetValueOrDefault(value);
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }
            return isValidMove;
        }

        private Room _location;

        public int score { get; set; }

        public int moves { get; set; }
    }
}

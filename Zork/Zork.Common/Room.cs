using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System;

namespace Zork
{
    public class Room : INotifyPropertyChanged, IEquatable<Room>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name { get; set; }
        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; }

        [JsonIgnore]
        public List<Room> Inventory { get; set; }

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return true;
            if (lhs is null || rhs is null)
                return false;

            return lhs.Name == rhs.Name;
        }

        public Room(string name = null)
        {
            Name = name;
            Inventory = new List<Room>();
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room && this == room;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();
       
        public void BuildInventoryFromNames(List<Room> rooms)
        {
            foreach (Room room in rooms)
            {
                if (room.Name != Name)
                    Inventory.Add(room);
            }
        }

        public void UpdateNeighbors(World world)

            => Neighbors = (from entry in NeighborNames
                            let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                            where room != null
                            select (Direction: entry.Key, Room: room))
                            .ToDictionary(pair => pair.Direction, pair => pair.Room);
    }
}

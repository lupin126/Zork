using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

namespace Zork
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public ReadOnlyDictionary<string, Room> RoomsByName => new ReadOnlyDictionary<string, Room>(mRoomsByName);

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.BuildInventoryFromNames(Rooms);
                room.UpdateNeighbors(this);
            }
        }

        [JsonProperty]
        public string StartingLocation { get; set; }

        [JsonProperty]
        public string WelcomeMessage { get; set; }
        
        [JsonProperty]
        public string ExitMessage { get; set; }

        private Dictionary<string, Room> mRoomsByName;
    }
}

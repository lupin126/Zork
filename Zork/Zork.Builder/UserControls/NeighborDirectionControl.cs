using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zork.Builder.UserControls
{
    public partial class NeighborDirectionControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };

        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if (Room != null)
                    {
                        List<Room> roomsList = new List<Room>(mRoom.Inventory);

                        roomsList.Insert(0, NoNeighbor);
                        neighborComboBox.SelectedIndexChanged -= neighborComboBox_SelectedIndexChanged;
                        neighborComboBox.DataSource = roomsList;

                        if (mRoom.Neighbors != null)
                        { 
                            if (mRoom.Neighbors.ContainsKey(Direction))
                            {
                                Room neighbor = mRoom.Neighbors[Direction];
                                Neighbor = neighbor;
                            }
                            else
                            {
                                Neighbor = NoNeighbor;
                            }
                        }
                        else
                        {
                            mRoom.Neighbors = new Dictionary<Directions, Room>();
                            mRoom.NeighborNames = new Dictionary<Directions, string>();
                        }

                        neighborComboBox.SelectedIndexChanged += neighborComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborComboBox.DataSource = null;
                    }
                }
            }
        }

        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                directionTextBox.Text = value.ToString();
            }
        }

        public Room Neighbor
        {
            get => (Room)neighborComboBox.SelectedItem;
            set => neighborComboBox.SelectedItem = value;
        }

        public NeighborDirectionControl()
        {
            InitializeComponent();
        }

        public NeighborDirectionControl(Directions direction, Room room)
        {
            Direction = direction;
            Neighbor = room ?? throw new ArgumentNullException(nameof(room));
        }

        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mRoom != null)
            {
                Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                if (selectedRoom == NoNeighbor)
                {
                    mRoom.Neighbors.Remove(Direction);
                    mRoom.NeighborNames.Remove(Direction);
                }
                else
                {
                    mRoom.Neighbors[Direction] = selectedRoom;
                    mRoom.NeighborNames[Direction] = selectedRoom.Name;
                }
            }
        }

        private Room mRoom;
        private Directions mDirection;
    }
}

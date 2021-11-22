using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;
using System.Reflection;
using System.Collections.Generic;
using Zork.Builder.UserControls;

namespace Zork.Builder
{
    public partial class ZorkBuilderForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        public string currentJsonFileName;

        private GameViewModel _viewModel;
        private Control[] _worldDependentControls;
        private ToolStripMenuItem[] _worldDependentMenuItems;
        private GroupBox[] _worldInfoItems;
        private readonly Dictionary<Directions, NeighborDirectionControl> mEquippedDirectionControlMap;

        private bool GameIsLoaded
        {
            get
            {
                return _viewModel.GameIsLoaded;
            }
            set
            {
                _viewModel.GameIsLoaded = value;

                tabControl.Enabled = _viewModel.GameIsLoaded;

                foreach (var box in _worldInfoItems)
                {
                    box.Enabled = _viewModel.GameIsLoaded;
                }
                foreach (var control in _worldDependentControls)
                {
                    control.Enabled = _viewModel.GameIsLoaded;
                }
                foreach (var menuItem in _worldDependentMenuItems)
                {
                    menuItem.Enabled = _viewModel.GameIsLoaded;
                }

            }
        }

        private GameViewModel ViewModel 
        {
            get => _viewModel;
            set
            {
                if(_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }
        
        public ZorkBuilderForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();

            _worldDependentControls = new Control[]
            {
                addRoomButton,
                removeRoomButton
            };

            _worldDependentMenuItems = new ToolStripMenuItem[]
            {
                editToolStripMenuItem,
                saveToolStripMenuItem,
                saveAsToolStripMenuItem
            };

            _worldInfoItems = new GroupBox[]
            {
                roomInfoGroupBox,
                roomsGroupBox
            };

            mEquippedDirectionControlMap = new Dictionary<Directions, NeighborDirectionControl>
            {
                { Directions.North, northNeighborDirectionControl },
                { Directions.South, southNeighborDirectionControl },
                { Directions.East, eastNeighborDirectionControl },
                { Directions.West, westNeighborDirectionControl }
            };

            GameIsLoaded = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (currentJsonFileName == openFileDialog.FileName)
                {
                    MessageBox.Show("File is already open", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentJsonFileName = openFileDialog.FileName;
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                    GameIsLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Room selectedRoom = roomsListBox.SelectedItem as Room;
                foreach (KeyValuePair<Directions, NeighborDirectionControl> entry in mEquippedDirectionControlMap)
                {
                    entry.Value.Room = selectedRoom;
                }

                Binding welcomeBinding = welcomeTextBox.DataBindings.Add("Text", _viewModel.Game.World, "WelcomeMessage", true, DataSourceUpdateMode.OnPropertyChanged);
                Binding exitBinding = exitTextBox.DataBindings.Add("Text", _viewModel.Game.World, "ExitMessage", true, DataSourceUpdateMode.OnPropertyChanged);
                Binding startingLocationBinding = startingLocationComboBox.DataBindings.Add("Text", _viewModel.Game.World, "StartingLocation", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room existingRoom = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                    if (existingRoom != null)
                    {
                        MessageBox.Show("Room already exists.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Room room = new Room(addRoomForm.RoomName);
                        ViewModel.Rooms.Add(room);
                        room.BuildInventoryFromNames(ViewModel.Game.World.Rooms);
                        roomsListBox.SelectedItem = ViewModel.Rooms.LastOrDefault();
                    }
                }
            }
        }

        private void removeRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Room?", AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveGame(currentJsonFileName);
        
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentJsonFileName = saveFileDialog.FileName;
                ViewModel.SaveGame(currentJsonFileName);
            }
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeRoomButton.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (KeyValuePair<Directions, NeighborDirectionControl> entry in mEquippedDirectionControlMap)
            {
                entry.Value.Room = selectedRoom;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void redoToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void openRecentToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void newToolStripMenuItem_Click(object sender, EventArgs e) => NotYetImplemented();
        private void NotYetImplemented() => MessageBox.Show("Not yet implemented.", AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

using System;
using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName => nameTextBox.Text;

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okayButton.Enabled = !string.IsNullOrWhiteSpace(RoomName);
        }
    }
}

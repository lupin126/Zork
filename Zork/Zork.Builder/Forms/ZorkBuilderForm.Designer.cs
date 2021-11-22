
namespace Zork.Builder
{
    partial class ZorkBuilderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label startingLocationLabel;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label exitMessageLabel;
            System.Windows.Forms.MenuStrip menuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem1;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem2;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
            System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
            System.Windows.Forms.TabPage startTabPage;
            System.Windows.Forms.TabPage welcomeTabPage;
            System.Windows.Forms.TabPage exitTabPage;
            System.Windows.Forms.GroupBox neighborsGroupBox;
            System.Windows.Forms.TextBox descriptionTextBox;
            System.Windows.Forms.TextBox roomNameTextBox;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label roomNameLabel;
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.welcomeTextBox = new System.Windows.Forms.TextBox();
            this.exitTextBox = new System.Windows.Forms.TextBox();
            this.westNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.eastNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.southNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.northNeighborDirectionControl = new Zork.Builder.UserControls.NeighborDirectionControl();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            startingLocationLabel = new System.Windows.Forms.Label();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            fileSeparatorStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            startTabPage = new System.Windows.Forms.TabPage();
            welcomeTabPage = new System.Windows.Forms.TabPage();
            exitTabPage = new System.Windows.Forms.TabPage();
            neighborsGroupBox = new System.Windows.Forms.GroupBox();
            descriptionTextBox = new System.Windows.Forms.TextBox();
            roomNameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            menuStrip.SuspendLayout();
            startTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            welcomeTabPage.SuspendLayout();
            exitTabPage.SuspendLayout();
            neighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.roomsGroupBox.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(5, 11);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(119, 17);
            startingLocationLabel.TabIndex = 2;
            startingLocationLabel.Text = "Starting Location:";
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(5, 11);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            welcomeMessageLabel.TabIndex = 4;
            welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageLabel
            // 
            exitMessageLabel.AutoSize = true;
            exitMessageLabel.Location = new System.Drawing.Point(5, 11);
            exitMessageLabel.Name = "exitMessageLabel";
            exitMessageLabel.Size = new System.Drawing.Size(95, 17);
            exitMessageLabel.TabIndex = 4;
            exitMessageLabel.Text = "Exit Message:";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            this.editToolStripMenuItem});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(657, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            openRecentToolStripMenuItem,
            fileSeparatorStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            fileSeparatorStripMenuItem2,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            openRecentToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            openRecentToolStripMenuItem.Text = "Open Recent";
            openRecentToolStripMenuItem.Click += new System.EventHandler(this.openRecentToolStripMenuItem_Click);
            // 
            // fileSeparatorStripMenuItem1
            // 
            fileSeparatorStripMenuItem1.Name = "fileSeparatorStripMenuItem1";
            fileSeparatorStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // fileSeparatorStripMenuItem2
            // 
            fileSeparatorStripMenuItem2.Name = "fileSeparatorStripMenuItem2";
            fileSeparatorStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            undoToolStripMenuItem,
            redoToolStripMenuItem,
            toolStripMenuItem3,
            cutToolStripMenuItem,
            copyToolStripMenuItem,
            pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // startTabPage
            // 
            startTabPage.Controls.Add(this.startingLocationComboBox);
            startTabPage.Controls.Add(startingLocationLabel);
            startTabPage.Location = new System.Drawing.Point(4, 25);
            startTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            startTabPage.Name = "startTabPage";
            startTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            startTabPage.Size = new System.Drawing.Size(192, 71);
            startTabPage.TabIndex = 0;
            startTabPage.Text = "Start";
            startTabPage.UseVisualStyleBackColor = true;
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.DataSource = this.locationBindingSource;
            this.startingLocationComboBox.DisplayMember = "Name";
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(5, 32);
            this.startingLocationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(177, 24);
            this.startingLocationComboBox.TabIndex = 12;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.AllowNew = true;
            this.locationBindingSource.DataMember = "Rooms";
            this.locationBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // welcomeTabPage
            // 
            welcomeTabPage.Controls.Add(welcomeMessageLabel);
            welcomeTabPage.Controls.Add(this.welcomeTextBox);
            welcomeTabPage.Location = new System.Drawing.Point(4, 25);
            welcomeTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            welcomeTabPage.Name = "welcomeTabPage";
            welcomeTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            welcomeTabPage.Size = new System.Drawing.Size(192, 71);
            welcomeTabPage.TabIndex = 1;
            welcomeTabPage.Text = "Welcome";
            welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.Location = new System.Drawing.Point(8, 34);
            this.welcomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(177, 22);
            this.welcomeTextBox.TabIndex = 3;
            // 
            // exitTabPage
            // 
            exitTabPage.Controls.Add(exitMessageLabel);
            exitTabPage.Controls.Add(this.exitTextBox);
            exitTabPage.Location = new System.Drawing.Point(4, 25);
            exitTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            exitTabPage.Name = "exitTabPage";
            exitTabPage.Size = new System.Drawing.Size(192, 71);
            exitTabPage.TabIndex = 2;
            exitTabPage.Text = "Exit";
            exitTabPage.UseVisualStyleBackColor = true;
            // 
            // exitTextBox
            // 
            this.exitTextBox.Location = new System.Drawing.Point(8, 34);
            this.exitTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitTextBox.Name = "exitTextBox";
            this.exitTextBox.Size = new System.Drawing.Size(177, 22);
            this.exitTextBox.TabIndex = 3;
            // 
            // neighborsGroupBox
            // 
            neighborsGroupBox.Controls.Add(this.westNeighborDirectionControl);
            neighborsGroupBox.Controls.Add(this.eastNeighborDirectionControl);
            neighborsGroupBox.Controls.Add(this.southNeighborDirectionControl);
            neighborsGroupBox.Controls.Add(this.northNeighborDirectionControl);
            neighborsGroupBox.Location = new System.Drawing.Point(21, 190);
            neighborsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            neighborsGroupBox.Name = "neighborsGroupBox";
            neighborsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            neighborsGroupBox.Size = new System.Drawing.Size(361, 199);
            neighborsGroupBox.TabIndex = 5;
            neighborsGroupBox.TabStop = false;
            neighborsGroupBox.Text = "Neighbors";
            // 
            // westNeighborDirectionControl
            // 
            this.westNeighborDirectionControl.Direction = Zork.Directions.West;
            this.westNeighborDirectionControl.Location = new System.Drawing.Point(9, 146);
            this.westNeighborDirectionControl.Margin = new System.Windows.Forms.Padding(5);
            this.westNeighborDirectionControl.Name = "westNeighborDirectionControl";
            this.westNeighborDirectionControl.Neighbor = null;
            this.westNeighborDirectionControl.Room = null;
            this.westNeighborDirectionControl.Size = new System.Drawing.Size(345, 36);
            this.westNeighborDirectionControl.TabIndex = 3;
            // 
            // eastNeighborDirectionControl
            // 
            this.eastNeighborDirectionControl.Direction = Zork.Directions.East;
            this.eastNeighborDirectionControl.Location = new System.Drawing.Point(9, 108);
            this.eastNeighborDirectionControl.Margin = new System.Windows.Forms.Padding(5);
            this.eastNeighborDirectionControl.Name = "eastNeighborDirectionControl";
            this.eastNeighborDirectionControl.Neighbor = null;
            this.eastNeighborDirectionControl.Room = null;
            this.eastNeighborDirectionControl.Size = new System.Drawing.Size(345, 36);
            this.eastNeighborDirectionControl.TabIndex = 2;
            // 
            // southNeighborDirectionControl
            // 
            this.southNeighborDirectionControl.Direction = Zork.Directions.South;
            this.southNeighborDirectionControl.Location = new System.Drawing.Point(9, 65);
            this.southNeighborDirectionControl.Margin = new System.Windows.Forms.Padding(5);
            this.southNeighborDirectionControl.Name = "southNeighborDirectionControl";
            this.southNeighborDirectionControl.Neighbor = null;
            this.southNeighborDirectionControl.Room = null;
            this.southNeighborDirectionControl.Size = new System.Drawing.Size(345, 36);
            this.southNeighborDirectionControl.TabIndex = 1;
            // 
            // northNeighborDirectionControl
            // 
            this.northNeighborDirectionControl.Direction = Zork.Directions.North;
            this.northNeighborDirectionControl.Location = new System.Drawing.Point(9, 22);
            this.northNeighborDirectionControl.Margin = new System.Windows.Forms.Padding(5);
            this.northNeighborDirectionControl.Name = "northNeighborDirectionControl";
            this.northNeighborDirectionControl.Neighbor = null;
            this.northNeighborDirectionControl.Room = null;
            this.northNeighborDirectionControl.Size = new System.Drawing.Size(345, 36);
            this.northNeighborDirectionControl.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            descriptionTextBox.Location = new System.Drawing.Point(21, 89);
            descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new System.Drawing.Size(361, 84);
            descriptionTextBox.TabIndex = 4;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            roomNameTextBox.Location = new System.Drawing.Point(115, 23);
            roomNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new System.Drawing.Size(268, 22);
            roomNameTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(19, 63);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(19, 25);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(90, 17);
            roomNameLabel.TabIndex = 1;
            roomNameLabel.Text = "Room Name:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(startTabPage);
            this.tabControl.Controls.Add(welcomeTabPage);
            this.tabControl.Controls.Add(exitTabPage);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(8, 34);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 100);
            this.tabControl.TabIndex = 1;
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.removeRoomButton);
            this.roomsGroupBox.Controls.Add(this.addRoomButton);
            this.roomsGroupBox.Controls.Add(this.roomsListBox);
            this.roomsGroupBox.Enabled = false;
            this.roomsGroupBox.Location = new System.Drawing.Point(12, 137);
            this.roomsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsGroupBox.Size = new System.Drawing.Size(200, 302);
            this.roomsGroupBox.TabIndex = 3;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms List";
            // 
            // removeRoomButton
            // 
            this.removeRoomButton.Enabled = false;
            this.removeRoomButton.Location = new System.Drawing.Point(119, 272);
            this.removeRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeRoomButton.Name = "removeRoomButton";
            this.removeRoomButton.Size = new System.Drawing.Size(75, 23);
            this.removeRoomButton.TabIndex = 5;
            this.removeRoomButton.Text = "Remove";
            this.removeRoomButton.UseVisualStyleBackColor = true;
            this.removeRoomButton.Click += new System.EventHandler(this.removeRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Enabled = false;
            this.addRoomButton.Location = new System.Drawing.Point(4, 272);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 4;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(4, 21);
            this.roomsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(191, 244);
            this.roomsListBox.TabIndex = 2;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(neighborsGroupBox);
            this.roomInfoGroupBox.Controls.Add(descriptionTextBox);
            this.roomInfoGroupBox.Controls.Add(roomNameTextBox);
            this.roomInfoGroupBox.Controls.Add(descriptionLabel);
            this.roomInfoGroupBox.Controls.Add(roomNameLabel);
            this.roomInfoGroupBox.Enabled = false;
            this.roomInfoGroupBox.Location = new System.Drawing.Point(235, 31);
            this.roomInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomInfoGroupBox.Size = new System.Drawing.Size(405, 407);
            this.roomInfoGroupBox.TabIndex = 4;
            this.roomInfoGroupBox.TabStop = false;
            this.roomInfoGroupBox.Text = "Room Info";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            // 
            // ZorkBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.roomInfoGroupBox);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ZorkBuilderForm";
            this.Text = "ZorkBuilder";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            startTabPage.ResumeLayout(false);
            startTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            welcomeTabPage.ResumeLayout(false);
            welcomeTabPage.PerformLayout();
            exitTabPage.ResumeLayout(false);
            exitTabPage.PerformLayout();
            neighborsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.roomsGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button removeRoomButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.TextBox welcomeTextBox;
        private System.Windows.Forms.TextBox exitTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private UserControls.NeighborDirectionControl westNeighborDirectionControl;
        private UserControls.NeighborDirectionControl eastNeighborDirectionControl;
        private UserControls.NeighborDirectionControl southNeighborDirectionControl;
        private UserControls.NeighborDirectionControl northNeighborDirectionControl;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.GroupBox roomInfoGroupBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}


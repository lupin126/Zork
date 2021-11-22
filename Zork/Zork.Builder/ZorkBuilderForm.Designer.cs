
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
            System.Windows.Forms.Label startingLocationLabel;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label exitMessageLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.startTabPage = new System.Windows.Forms.TabPage();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.welcomTextBox = new System.Windows.Forms.TextBox();
            this.exitTabPage = new System.Windows.Forms.TabPage();
            this.exitTextBox = new System.Windows.Forms.TextBox();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsTextBox = new System.Windows.Forms.TextBox();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.neighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.westComboBox = new System.Windows.Forms.ComboBox();
            this.eastComboBox = new System.Windows.Forms.ComboBox();
            this.southComboBox = new System.Windows.Forms.ComboBox();
            this.northComboBox = new System.Windows.Forms.ComboBox();
            this.southLabel = new System.Windows.Forms.Label();
            this.eastLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.northLlabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            startingLocationLabel = new System.Windows.Forms.Label();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.startTabPage.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            this.exitTabPage.SuspendLayout();
            this.roomsGroupBox.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            this.neighborsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(6, 11);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(119, 17);
            startingLocationLabel.TabIndex = 2;
            startingLocationLabel.Text = "Starting Location:";
            startingLocationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(6, 11);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            welcomeMessageLabel.TabIndex = 4;
            welcomeMessageLabel.Text = "Welcome Message:";
            welcomeMessageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // exitMessageLabel
            // 
            exitMessageLabel.AutoSize = true;
            exitMessageLabel.Location = new System.Drawing.Point(6, 11);
            exitMessageLabel.Name = "exitMessageLabel";
            exitMessageLabel.Size = new System.Drawing.Size(95, 17);
            exitMessageLabel.TabIndex = 4;
            exitMessageLabel.Text = "Exit Message:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openRecentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            this.openRecentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.startTabPage);
            this.tabControl.Controls.Add(this.welcomeTabPage);
            this.tabControl.Controls.Add(this.exitTabPage);
            this.tabControl.Location = new System.Drawing.Point(8, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 100);
            this.tabControl.TabIndex = 1;
            // 
            // startTabPage
            // 
            this.startTabPage.Controls.Add(this.startingLocationComboBox);
            this.startTabPage.Controls.Add(startingLocationLabel);
            this.startTabPage.Location = new System.Drawing.Point(4, 25);
            this.startTabPage.Name = "startTabPage";
            this.startTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.startTabPage.Size = new System.Drawing.Size(192, 71);
            this.startTabPage.TabIndex = 0;
            this.startTabPage.Text = "Start";
            this.startTabPage.UseVisualStyleBackColor = true;
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(8, 35);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(177, 24);
            this.startingLocationComboBox.TabIndex = 12;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Controls.Add(welcomeMessageLabel);
            this.welcomeTabPage.Controls.Add(this.welcomTextBox);
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 25);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTabPage.Size = new System.Drawing.Size(192, 71);
            this.welcomeTabPage.TabIndex = 1;
            this.welcomeTabPage.Text = "Welcome";
            this.welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomTextBox
            // 
            this.welcomTextBox.Location = new System.Drawing.Point(8, 35);
            this.welcomTextBox.Name = "welcomTextBox";
            this.welcomTextBox.Size = new System.Drawing.Size(178, 22);
            this.welcomTextBox.TabIndex = 3;
            this.welcomTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // exitTabPage
            // 
            this.exitTabPage.Controls.Add(exitMessageLabel);
            this.exitTabPage.Controls.Add(this.exitTextBox);
            this.exitTabPage.Location = new System.Drawing.Point(4, 25);
            this.exitTabPage.Name = "exitTabPage";
            this.exitTabPage.Size = new System.Drawing.Size(192, 71);
            this.exitTabPage.TabIndex = 2;
            this.exitTabPage.Text = "Exit";
            this.exitTabPage.UseVisualStyleBackColor = true;
            // 
            // exitTextBox
            // 
            this.exitTextBox.Location = new System.Drawing.Point(8, 35);
            this.exitTextBox.Name = "exitTextBox";
            this.exitTextBox.Size = new System.Drawing.Size(177, 22);
            this.exitTextBox.TabIndex = 3;
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(4, 21);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(190, 244);
            this.roomsListBox.TabIndex = 2;
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.removeRoomButton);
            this.roomsGroupBox.Controls.Add(this.addRoomButton);
            this.roomsGroupBox.Controls.Add(this.roomsListBox);
            this.roomsGroupBox.Location = new System.Drawing.Point(12, 137);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(200, 301);
            this.roomsGroupBox.TabIndex = 3;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms List";
            // 
            // removeRoomButton
            // 
            this.removeRoomButton.Location = new System.Drawing.Point(119, 272);
            this.removeRoomButton.Name = "removeRoomButton";
            this.removeRoomButton.Size = new System.Drawing.Size(75, 23);
            this.removeRoomButton.TabIndex = 5;
            this.removeRoomButton.Text = "Remove";
            this.removeRoomButton.UseVisualStyleBackColor = true;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(4, 272);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 4;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(this.itemsTextBox);
            this.roomInfoGroupBox.Controls.Add(this.itemsLabel);
            this.roomInfoGroupBox.Controls.Add(this.neighborsGroupBox);
            this.roomInfoGroupBox.Controls.Add(this.descriptionTextBox);
            this.roomInfoGroupBox.Controls.Add(this.roomNameTextBox);
            this.roomInfoGroupBox.Controls.Add(this.descriptionLabel);
            this.roomInfoGroupBox.Controls.Add(this.roomNameLabel);
            this.roomInfoGroupBox.Location = new System.Drawing.Point(234, 31);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Size = new System.Drawing.Size(406, 407);
            this.roomInfoGroupBox.TabIndex = 4;
            this.roomInfoGroupBox.TabStop = false;
            this.roomInfoGroupBox.Text = "Room Info";
            // 
            // itemsTextBox
            // 
            this.itemsTextBox.Location = new System.Drawing.Point(77, 347);
            this.itemsTextBox.Multiline = true;
            this.itemsTextBox.Name = "itemsTextBox";
            this.itemsTextBox.Size = new System.Drawing.Size(306, 53);
            this.itemsTextBox.TabIndex = 6;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(26, 354);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(45, 17);
            this.itemsLabel.TabIndex = 5;
            this.itemsLabel.Text = "Items:";
            // 
            // neighborsGroupBox
            // 
            this.neighborsGroupBox.Controls.Add(this.westComboBox);
            this.neighborsGroupBox.Controls.Add(this.eastComboBox);
            this.neighborsGroupBox.Controls.Add(this.southComboBox);
            this.neighborsGroupBox.Controls.Add(this.northComboBox);
            this.neighborsGroupBox.Controls.Add(this.southLabel);
            this.neighborsGroupBox.Controls.Add(this.eastLabel);
            this.neighborsGroupBox.Controls.Add(this.westLabel);
            this.neighborsGroupBox.Controls.Add(this.northLlabel);
            this.neighborsGroupBox.Location = new System.Drawing.Point(22, 190);
            this.neighborsGroupBox.Name = "neighborsGroupBox";
            this.neighborsGroupBox.Size = new System.Drawing.Size(361, 151);
            this.neighborsGroupBox.TabIndex = 4;
            this.neighborsGroupBox.TabStop = false;
            this.neighborsGroupBox.Text = "Neighbors";
            // 
            // westComboBox
            // 
            this.westComboBox.FormattingEnabled = true;
            this.westComboBox.Location = new System.Drawing.Point(93, 113);
            this.westComboBox.Name = "westComboBox";
            this.westComboBox.Size = new System.Drawing.Size(243, 24);
            this.westComboBox.TabIndex = 11;
            // 
            // eastComboBox
            // 
            this.eastComboBox.FormattingEnabled = true;
            this.eastComboBox.Location = new System.Drawing.Point(93, 83);
            this.eastComboBox.Name = "eastComboBox";
            this.eastComboBox.Size = new System.Drawing.Size(243, 24);
            this.eastComboBox.TabIndex = 10;
            // 
            // southComboBox
            // 
            this.southComboBox.FormattingEnabled = true;
            this.southComboBox.Location = new System.Drawing.Point(93, 53);
            this.southComboBox.Name = "southComboBox";
            this.southComboBox.Size = new System.Drawing.Size(243, 24);
            this.southComboBox.TabIndex = 9;
            // 
            // northComboBox
            // 
            this.northComboBox.FormattingEnabled = true;
            this.northComboBox.Location = new System.Drawing.Point(93, 24);
            this.northComboBox.Name = "northComboBox";
            this.northComboBox.Size = new System.Drawing.Size(243, 24);
            this.northComboBox.TabIndex = 5;
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(22, 56);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(49, 17);
            this.southLabel.TabIndex = 8;
            this.southLabel.Text = "South:";
            this.southLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Location = new System.Drawing.Point(22, 88);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(40, 17);
            this.eastLabel.TabIndex = 7;
            this.eastLabel.Text = "East:";
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(22, 120);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(44, 17);
            this.westLabel.TabIndex = 6;
            this.westLabel.Text = "West:";
            // 
            // northLlabel
            // 
            this.northLlabel.AutoSize = true;
            this.northLlabel.Location = new System.Drawing.Point(22, 27);
            this.northLlabel.Name = "northLlabel";
            this.northLlabel.Size = new System.Drawing.Size(47, 17);
            this.northLlabel.TabIndex = 5;
            this.northLlabel.Text = "North:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(22, 88);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(361, 84);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(115, 23);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.roomNameTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(19, 63);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(19, 25);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(90, 17);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "Room Name:";
            // 
            // ZorkBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.roomInfoGroupBox);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilderForm";
            this.Text = "ZorkBuilder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.startTabPage.ResumeLayout(false);
            this.startTabPage.PerformLayout();
            this.welcomeTabPage.ResumeLayout(false);
            this.welcomeTabPage.PerformLayout();
            this.exitTabPage.ResumeLayout(false);
            this.exitTabPage.PerformLayout();
            this.roomsGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.PerformLayout();
            this.neighborsGroupBox.ResumeLayout(false);
            this.neighborsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage startTabPage;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.TabPage exitTabPage;
        private System.Windows.Forms.TextBox welcomTextBox;
        private System.Windows.Forms.TextBox exitTextBox;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.Button removeRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.GroupBox roomInfoGroupBox;
        private System.Windows.Forms.GroupBox neighborsGroupBox;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.Label northLlabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.ComboBox westComboBox;
        private System.Windows.Forms.ComboBox eastComboBox;
        private System.Windows.Forms.ComboBox southComboBox;
        private System.Windows.Forms.ComboBox northComboBox;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.TextBox itemsTextBox;
        private System.Windows.Forms.Label itemsLabel;
    }
}


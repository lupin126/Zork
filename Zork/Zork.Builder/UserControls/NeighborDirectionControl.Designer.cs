
namespace Zork.Builder.UserControls
{
    partial class NeighborDirectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.neighborComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(5, 7);
            this.directionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(83, 22);
            this.directionTextBox.TabIndex = 0;
            this.directionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // neighborComboBox
            // 
            this.neighborComboBox.FormattingEnabled = true;
            this.neighborComboBox.Location = new System.Drawing.Point(97, 6);
            this.neighborComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.neighborComboBox.Name = "neighborComboBox";
            this.neighborComboBox.Size = new System.Drawing.Size(243, 24);
            this.neighborComboBox.TabIndex = 1;
            this.neighborComboBox.SelectedIndexChanged += new System.EventHandler(this.neighborComboBox_SelectedIndexChanged);
            // 
            // NeighborDirectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NeighborDirectionControl";
            this.Size = new System.Drawing.Size(345, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.ComboBox neighborComboBox;
    }
}

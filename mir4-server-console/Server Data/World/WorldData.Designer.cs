namespace Server_Console.Server_Data.World
{
    partial class WorldData
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
            SearchBox = new TextBox();
            DataTextBox = new RichTextBox();
            DataListBox = new ListBox();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(1, 427);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(278, 23);
            SearchBox.TabIndex = 13;
            SearchBox.TextChanged += SearchBox_TextChanged;
            SearchBox.Enter += SearchBox_Enter;
            SearchBox.Leave += SearchBox_Leave;
            // 
            // DataTextBox
            // 
            DataTextBox.Location = new Point(275, 0);
            DataTextBox.Name = "DataTextBox";
            DataTextBox.Size = new Size(525, 450);
            DataTextBox.TabIndex = 12;
            DataTextBox.Text = "";
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 15;
            DataListBox.Location = new Point(1, 0);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(278, 424);
            DataListBox.TabIndex = 11;
            DataListBox.SelectedIndexChanged += DataListBox_SelectedIndexChanged;
            // 
            // WorldData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBox);
            Controls.Add(DataTextBox);
            Controls.Add(DataListBox);
            Name = "WorldData";
            Text = "WorldData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private RichTextBox DataTextBox;
        private ListBox DataListBox;
    }
}
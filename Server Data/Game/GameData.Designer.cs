namespace Server_Console.Server_Data
{
    partial class GameData
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
            DataListBox = new ListBox();
            DataTextBox = new RichTextBox();
            SearchBox = new TextBox();
            SuspendLayout();
            // 
            // DataListBox
            // 
            DataListBox.FormattingEnabled = true;
            DataListBox.ItemHeight = 15;
            DataListBox.Location = new Point(1, 0);
            DataListBox.Name = "DataListBox";
            DataListBox.Size = new Size(278, 424);
            DataListBox.TabIndex = 2;
            DataListBox.SelectedIndexChanged += DataListBox_SelectedIndexChanged;
            // 
            // DataTextBox
            // 
            DataTextBox.Location = new Point(275, 0);
            DataTextBox.Name = "DataTextBox";
            DataTextBox.Size = new Size(525, 450);
            DataTextBox.TabIndex = 6;
            DataTextBox.Text = "";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(1, 427);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(278, 23);
            SearchBox.TabIndex = 7;
            SearchBox.TextChanged += SearchBox_TextChanged;
            SearchBox.Enter += SearchBox_Enter;
            SearchBox.Leave += SearchBox_Leave;
            // 
            // GameData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBox);
            Controls.Add(DataTextBox);
            Controls.Add(DataListBox);
            Name = "GameData";
            Text = "GameData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DataListBox;
        private RichTextBox DataTextBox;
        private TextBox SearchBox;
    }
}
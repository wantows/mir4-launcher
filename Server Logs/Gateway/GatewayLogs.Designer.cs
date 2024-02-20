namespace Server_Console.Logs.Gateway
{
    partial class GatewayLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GatewayLogs));
            LogsListBox = new ListBox();
            LogTextBox = new RichTextBox();
            SearchBox = new TextBox();
            SuspendLayout();
            // 
            // LogsListBox
            // 
            LogsListBox.FormattingEnabled = true;
            LogsListBox.ItemHeight = 15;
            LogsListBox.Location = new Point(0, 0);
            LogsListBox.Name = "LogsListBox";
            LogsListBox.Size = new Size(278, 424);
            LogsListBox.TabIndex = 3;
            LogsListBox.SelectedIndexChanged += LogsListBox_SelectedIndexChanged;
            // 
            // LogTextBox
            // 
            LogTextBox.Location = new Point(274, 0);
            LogTextBox.Name = "LogTextBox";
            LogTextBox.Size = new Size(525, 450);
            LogTextBox.TabIndex = 5;
            LogTextBox.Text = "";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(0, 427);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(278, 23);
            SearchBox.TabIndex = 8;
            SearchBox.TextChanged += SearchBox_TextChanged;
            SearchBox.Enter += SearchBox_Enter;
            SearchBox.Leave += SearchBox_Leave;
            // 
            // GatewayLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBox);
            Controls.Add(LogTextBox);
            Controls.Add(LogsListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GatewayLogs";
            Text = "GatewayLogs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LogsListBox;
        private RichTextBox LogTextBox;
        private TextBox SearchBox;
    }
}
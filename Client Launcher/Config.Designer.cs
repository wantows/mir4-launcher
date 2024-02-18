namespace Mir_4_Launcher
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            ConfigTabs = new TabControl();
            ClientConfigTab = new TabPage();
            ConfigTextBox = new RichTextBox();
            ClientVersionTab = new TabPage();
            VersionTextBox = new RichTextBox();
            ConfigTabs.SuspendLayout();
            ClientConfigTab.SuspendLayout();
            ClientVersionTab.SuspendLayout();
            SuspendLayout();
            // 
            // ConfigTabs
            // 
            ConfigTabs.Controls.Add(ClientConfigTab);
            ConfigTabs.Controls.Add(ClientVersionTab);
            ConfigTabs.Dock = DockStyle.Fill;
            ConfigTabs.Location = new Point(0, 0);
            ConfigTabs.Name = "ConfigTabs";
            ConfigTabs.SelectedIndex = 0;
            ConfigTabs.Size = new Size(800, 450);
            ConfigTabs.TabIndex = 0;
            ConfigTabs.SelectedIndexChanged += ConfigTabs_SelectedIndexChanged;
            // 
            // ClientConfigTab
            // 
            ClientConfigTab.Controls.Add(ConfigTextBox);
            ClientConfigTab.Location = new Point(4, 24);
            ClientConfigTab.Name = "ClientConfigTab";
            ClientConfigTab.Padding = new Padding(3);
            ClientConfigTab.Size = new Size(792, 422);
            ClientConfigTab.TabIndex = 0;
            ClientConfigTab.Text = "Config";
            ClientConfigTab.UseVisualStyleBackColor = true;
            // 
            // ConfigTextBox
            // 
            ConfigTextBox.Location = new Point(0, 0);
            ConfigTextBox.Name = "ConfigTextBox";
            ConfigTextBox.Size = new Size(792, 422);
            ConfigTextBox.TabIndex = 0;
            ConfigTextBox.Text = "";
            // 
            // ClientVersionTab
            // 
            ClientVersionTab.Controls.Add(VersionTextBox);
            ClientVersionTab.Location = new Point(4, 24);
            ClientVersionTab.Name = "ClientVersionTab";
            ClientVersionTab.Padding = new Padding(3);
            ClientVersionTab.Size = new Size(792, 422);
            ClientVersionTab.TabIndex = 1;
            ClientVersionTab.Text = "Version";
            ClientVersionTab.UseVisualStyleBackColor = true;
            // 
            // VersionTextBox
            // 
            VersionTextBox.Dock = DockStyle.Fill;
            VersionTextBox.Location = new Point(3, 3);
            VersionTextBox.Name = "VersionTextBox";
            VersionTextBox.Size = new Size(786, 416);
            VersionTextBox.TabIndex = 0;
            VersionTextBox.Text = "";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfigTabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Config";
            Text = "Config";
            ConfigTabs.ResumeLayout(false);
            ClientConfigTab.ResumeLayout(false);
            ClientVersionTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ConfigTabs;
        private TabPage ClientConfigTab;
        private TabPage ClientVersionTab;
        private RichTextBox ConfigTextBox;
        private RichTextBox VersionTextBox;
    }
}
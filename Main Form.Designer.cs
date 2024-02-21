namespace Server_Console
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ChattingServerButton = new Button();
            GameServerButton = new Button();
            GatewayServerButton = new Button();
            WorldServerButton = new Button();
            LaunchAllButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            WeGreedLabel = new Label();
            ChattingLogsButton = new Button();
            GameLogsButton = new Button();
            GatewayLogsButton = new Button();
            WorldLogsButton = new Button();
            ChattingConfigButton = new Button();
            GameConfigButton = new Button();
            GatewayConfigButton = new Button();
            WorldConfigButton = new Button();
            GameDataButton = new Button();
            GatewayDataButton = new Button();
            WorldDataButton = new Button();
            AutoPatcherButton = new Button();
            SuspendLayout();
            // 
            // ChattingServerButton
            // 
            ChattingServerButton.Location = new Point(12, 53);
            ChattingServerButton.Name = "ChattingServerButton";
            ChattingServerButton.Size = new Size(77, 45);
            ChattingServerButton.TabIndex = 0;
            ChattingServerButton.Text = "Chatting Server";
            ChattingServerButton.UseVisualStyleBackColor = true;
            ChattingServerButton.Click += ChattingServerButton_Click;
            // 
            // GameServerButton
            // 
            GameServerButton.Location = new Point(12, 104);
            GameServerButton.Name = "GameServerButton";
            GameServerButton.Size = new Size(77, 45);
            GameServerButton.TabIndex = 1;
            GameServerButton.Text = "Game Server";
            GameServerButton.UseVisualStyleBackColor = true;
            GameServerButton.Click += GameServerButton_Click;
            // 
            // GatewayServerButton
            // 
            GatewayServerButton.Location = new Point(12, 155);
            GatewayServerButton.Name = "GatewayServerButton";
            GatewayServerButton.Size = new Size(77, 45);
            GatewayServerButton.TabIndex = 2;
            GatewayServerButton.Text = "Gateway Server";
            GatewayServerButton.UseVisualStyleBackColor = true;
            GatewayServerButton.Click += GatewayServerButton_Click;
            // 
            // WorldServerButton
            // 
            WorldServerButton.Location = new Point(12, 206);
            WorldServerButton.Name = "WorldServerButton";
            WorldServerButton.Size = new Size(77, 45);
            WorldServerButton.TabIndex = 3;
            WorldServerButton.Text = "World Server";
            WorldServerButton.UseVisualStyleBackColor = true;
            WorldServerButton.Click += WorldServerButton_Click;
            // 
            // LaunchAllButton
            // 
            LaunchAllButton.Location = new Point(111, 262);
            LaunchAllButton.Name = "LaunchAllButton";
            LaunchAllButton.Size = new Size(122, 37);
            LaunchAllButton.TabIndex = 4;
            LaunchAllButton.Text = "Launch All";
            LaunchAllButton.UseVisualStyleBackColor = true;
            LaunchAllButton.Click += LaunchAllButton_Click;
            // 
            // WeGreedLabel
            // 
            WeGreedLabel.AutoSize = true;
            WeGreedLabel.Location = new Point(62, 302);
            WeGreedLabel.Name = "WeGreedLabel";
            WeGreedLabel.Size = new Size(222, 15);
            WeGreedLabel.TabIndex = 5;
            WeGreedLabel.Text = "© WeGreed Entertainment Co LTD - 2024";
            // 
            // ChattingLogsButton
            // 
            ChattingLogsButton.Location = new Point(95, 64);
            ChattingLogsButton.Name = "ChattingLogsButton";
            ChattingLogsButton.Size = new Size(75, 23);
            ChattingLogsButton.TabIndex = 6;
            ChattingLogsButton.Text = "Logs";
            ChattingLogsButton.UseVisualStyleBackColor = true;
            ChattingLogsButton.Click += ChattingLogsButton_Click;
            // 
            // GameLogsButton
            // 
            GameLogsButton.Location = new Point(95, 115);
            GameLogsButton.Name = "GameLogsButton";
            GameLogsButton.Size = new Size(75, 23);
            GameLogsButton.TabIndex = 7;
            GameLogsButton.Text = "Logs";
            GameLogsButton.UseVisualStyleBackColor = true;
            GameLogsButton.Click += GameLogsButton_Click;
            // 
            // GatewayLogsButton
            // 
            GatewayLogsButton.Location = new Point(95, 166);
            GatewayLogsButton.Name = "GatewayLogsButton";
            GatewayLogsButton.Size = new Size(75, 23);
            GatewayLogsButton.TabIndex = 8;
            GatewayLogsButton.Text = "Logs";
            GatewayLogsButton.UseVisualStyleBackColor = true;
            GatewayLogsButton.Click += GatewayLogsButton_Click;
            // 
            // WorldLogsButton
            // 
            WorldLogsButton.Location = new Point(95, 217);
            WorldLogsButton.Name = "WorldLogsButton";
            WorldLogsButton.Size = new Size(75, 23);
            WorldLogsButton.TabIndex = 9;
            WorldLogsButton.Text = "Logs";
            WorldLogsButton.UseVisualStyleBackColor = true;
            WorldLogsButton.Click += WorldLogsButton_Click;
            // 
            // ChattingConfigButton
            // 
            ChattingConfigButton.Location = new Point(176, 64);
            ChattingConfigButton.Name = "ChattingConfigButton";
            ChattingConfigButton.Size = new Size(75, 23);
            ChattingConfigButton.TabIndex = 10;
            ChattingConfigButton.Text = "Config";
            ChattingConfigButton.UseVisualStyleBackColor = true;
            ChattingConfigButton.Click += ChattingConfigButton_Click;
            // 
            // GameConfigButton
            // 
            GameConfigButton.Location = new Point(176, 115);
            GameConfigButton.Name = "GameConfigButton";
            GameConfigButton.Size = new Size(75, 23);
            GameConfigButton.TabIndex = 11;
            GameConfigButton.Text = "Config";
            GameConfigButton.UseVisualStyleBackColor = true;
            GameConfigButton.Click += GameConfigButton_Click;
            // 
            // GatewayConfigButton
            // 
            GatewayConfigButton.Location = new Point(176, 166);
            GatewayConfigButton.Name = "GatewayConfigButton";
            GatewayConfigButton.Size = new Size(75, 23);
            GatewayConfigButton.TabIndex = 12;
            GatewayConfigButton.Text = "Config";
            GatewayConfigButton.UseVisualStyleBackColor = true;
            GatewayConfigButton.Click += GatewayConfigButton_Click;
            // 
            // WorldConfigButton
            // 
            WorldConfigButton.Location = new Point(176, 217);
            WorldConfigButton.Name = "WorldConfigButton";
            WorldConfigButton.Size = new Size(75, 23);
            WorldConfigButton.TabIndex = 13;
            WorldConfigButton.Text = "Config";
            WorldConfigButton.UseVisualStyleBackColor = true;
            WorldConfigButton.Click += WorldConfigButton_Click;
            // 
            // GameDataButton
            // 
            GameDataButton.Location = new Point(257, 115);
            GameDataButton.Name = "GameDataButton";
            GameDataButton.Size = new Size(75, 23);
            GameDataButton.TabIndex = 14;
            GameDataButton.Text = "Data";
            GameDataButton.UseVisualStyleBackColor = true;
            GameDataButton.Click += GameDataButton_Click;
            // 
            // GatewayDataButton
            // 
            GatewayDataButton.Location = new Point(257, 166);
            GatewayDataButton.Name = "GatewayDataButton";
            GatewayDataButton.Size = new Size(75, 23);
            GatewayDataButton.TabIndex = 15;
            GatewayDataButton.Text = "Data";
            GatewayDataButton.UseVisualStyleBackColor = true;
            GatewayDataButton.Click += GatewayDataButton_Click;
            // 
            // WorldDataButton
            // 
            WorldDataButton.Location = new Point(257, 217);
            WorldDataButton.Name = "WorldDataButton";
            WorldDataButton.Size = new Size(75, 23);
            WorldDataButton.TabIndex = 16;
            WorldDataButton.Text = "Data";
            WorldDataButton.UseVisualStyleBackColor = true;
            WorldDataButton.Click += WorldDataButton_Click;
            // 
            // AutoPatcherButton
            // 
            AutoPatcherButton.Location = new Point(259, 269);
            AutoPatcherButton.Name = "AutoPatcherButton";
            AutoPatcherButton.Size = new Size(81, 23);
            AutoPatcherButton.TabIndex = 17;
            AutoPatcherButton.Text = "AutoPatcher";
            AutoPatcherButton.UseVisualStyleBackColor = true;
            AutoPatcherButton.Click += AutoPatcherButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 324);
            Controls.Add(AutoPatcherButton);
            Controls.Add(WorldDataButton);
            Controls.Add(GatewayDataButton);
            Controls.Add(GameDataButton);
            Controls.Add(WorldConfigButton);
            Controls.Add(GatewayConfigButton);
            Controls.Add(GameConfigButton);
            Controls.Add(ChattingConfigButton);
            Controls.Add(WorldLogsButton);
            Controls.Add(GatewayLogsButton);
            Controls.Add(GameLogsButton);
            Controls.Add(ChattingLogsButton);
            Controls.Add(WeGreedLabel);
            Controls.Add(LaunchAllButton);
            Controls.Add(WorldServerButton);
            Controls.Add(GatewayServerButton);
            Controls.Add(GameServerButton);
            Controls.Add(ChattingServerButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Legend Of Mir 4 Server Console";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChattingServerButton;
        private Button GameServerButton;
        private Button GatewayServerButton;
        private Button WorldServerButton;
        private Button LaunchAllButton;
        private System.Windows.Forms.Timer timer1;
        private Label WeGreedLabel;
        private Button ChattingLogsButton;
        private Button GameLogsButton;
        private Button GatewayLogsButton;
        private Button WorldLogsButton;
        private Button ChattingConfigButton;
        private Button GameConfigButton;
        private Button GatewayConfigButton;
        private Button WorldConfigButton;
        private Button GameDataButton;
        private Button GatewayDataButton;
        private Button WorldDataButton;
        private Button AutoPatcherButton;
    }
}

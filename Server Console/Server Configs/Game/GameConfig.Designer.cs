namespace Server_Console.Server_Configs.Game
{
    partial class GameConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameConfig));
            MaxDumpBox = new TextBox();
            LogConsoleLevelBox = new TextBox();
            LogFileLevelBox = new TextBox();
            SendBufferSizeBox = new TextBox();
            RecvBufferSizeBox = new TextBox();
            IOCPThreadCountBox = new TextBox();
            MaxWorkerCountBox = new TextBox();
            MaxGatewaySocketCountBox = new TextBox();
            WorldServerConnectPortBox = new TextBox();
            WorldServerConnectIPBox = new TextBox();
            MakeDumpLabel = new Label();
            LogConsoleLevelLabel = new Label();
            LogFileLevelLabel = new Label();
            SendBufferSizeLabel = new Label();
            RecvBufferSizeLabel = new Label();
            IOCPThreadCountLabel = new Label();
            MaxWorkerCountLabel = new Label();
            MaxGatewaySocketCountLabel = new Label();
            WorldServerConnectPortLabel = new Label();
            WorldServerConnectIPLabel = new Label();
            AssertMessageboxBox = new TextBox();
            DumpPathBox = new TextBox();
            DumpServerPathBox = new TextBox();
            AssertMessageboxLabel = new Label();
            DumpPathLabel = new Label();
            DumpServerPathLabel = new Label();
            OpenButton = new Button();
            SuspendLayout();
            // 
            // MaxDumpBox
            // 
            MaxDumpBox.Location = new Point(78, 249);
            MaxDumpBox.Name = "MaxDumpBox";
            MaxDumpBox.ReadOnly = true;
            MaxDumpBox.Size = new Size(100, 23);
            MaxDumpBox.TabIndex = 54;
            // 
            // LogConsoleLevelBox
            // 
            LogConsoleLevelBox.Location = new Point(115, 225);
            LogConsoleLevelBox.Name = "LogConsoleLevelBox";
            LogConsoleLevelBox.ReadOnly = true;
            LogConsoleLevelBox.Size = new Size(100, 23);
            LogConsoleLevelBox.TabIndex = 53;
            // 
            // LogFileLevelBox
            // 
            LogFileLevelBox.Location = new Point(90, 199);
            LogFileLevelBox.Name = "LogFileLevelBox";
            LogFileLevelBox.ReadOnly = true;
            LogFileLevelBox.Size = new Size(100, 23);
            LogFileLevelBox.TabIndex = 52;
            // 
            // SendBufferSizeBox
            // 
            SendBufferSizeBox.Location = new Point(103, 175);
            SendBufferSizeBox.Name = "SendBufferSizeBox";
            SendBufferSizeBox.ReadOnly = true;
            SendBufferSizeBox.Size = new Size(100, 23);
            SendBufferSizeBox.TabIndex = 51;
            // 
            // RecvBufferSizeBox
            // 
            RecvBufferSizeBox.Location = new Point(102, 147);
            RecvBufferSizeBox.Name = "RecvBufferSizeBox";
            RecvBufferSizeBox.ReadOnly = true;
            RecvBufferSizeBox.Size = new Size(100, 23);
            RecvBufferSizeBox.TabIndex = 50;
            // 
            // IOCPThreadCountBox
            // 
            IOCPThreadCountBox.Location = new Point(121, 122);
            IOCPThreadCountBox.Name = "IOCPThreadCountBox";
            IOCPThreadCountBox.ReadOnly = true;
            IOCPThreadCountBox.Size = new Size(100, 23);
            IOCPThreadCountBox.TabIndex = 49;
            // 
            // MaxWorkerCountBox
            // 
            MaxWorkerCountBox.Location = new Point(119, 97);
            MaxWorkerCountBox.Name = "MaxWorkerCountBox";
            MaxWorkerCountBox.ReadOnly = true;
            MaxWorkerCountBox.Size = new Size(100, 23);
            MaxWorkerCountBox.TabIndex = 48;
            // 
            // MaxGatewaySocketCountBox
            // 
            MaxGatewaySocketCountBox.Location = new Point(164, 69);
            MaxGatewaySocketCountBox.Name = "MaxGatewaySocketCountBox";
            MaxGatewaySocketCountBox.ReadOnly = true;
            MaxGatewaySocketCountBox.Size = new Size(100, 23);
            MaxGatewaySocketCountBox.TabIndex = 46;
            // 
            // WorldServerConnectPortBox
            // 
            WorldServerConnectPortBox.Location = new Point(159, 44);
            WorldServerConnectPortBox.Name = "WorldServerConnectPortBox";
            WorldServerConnectPortBox.ReadOnly = true;
            WorldServerConnectPortBox.Size = new Size(100, 23);
            WorldServerConnectPortBox.TabIndex = 45;
            // 
            // WorldServerConnectIPBox
            // 
            WorldServerConnectIPBox.Location = new Point(147, 19);
            WorldServerConnectIPBox.Name = "WorldServerConnectIPBox";
            WorldServerConnectIPBox.ReadOnly = true;
            WorldServerConnectIPBox.Size = new Size(100, 23);
            WorldServerConnectIPBox.TabIndex = 44;
            // 
            // MakeDumpLabel
            // 
            MakeDumpLabel.AutoSize = true;
            MakeDumpLabel.Location = new Point(3, 250);
            MakeDumpLabel.Name = "MakeDumpLabel";
            MakeDumpLabel.Size = new Size(75, 15);
            MakeDumpLabel.TabIndex = 41;
            MakeDumpLabel.Text = "Make Dump:";
            // 
            // LogConsoleLevelLabel
            // 
            LogConsoleLevelLabel.AutoSize = true;
            LogConsoleLevelLabel.Location = new Point(3, 225);
            LogConsoleLevelLabel.Name = "LogConsoleLevelLabel";
            LogConsoleLevelLabel.Size = new Size(106, 15);
            LogConsoleLevelLabel.TabIndex = 40;
            LogConsoleLevelLabel.Text = "Log Console Level:";
            // 
            // LogFileLevelLabel
            // 
            LogFileLevelLabel.AutoSize = true;
            LogFileLevelLabel.Location = new Point(3, 200);
            LogFileLevelLabel.Name = "LogFileLevelLabel";
            LogFileLevelLabel.Size = new Size(81, 15);
            LogFileLevelLabel.TabIndex = 39;
            LogFileLevelLabel.Text = "Log File Level:";
            // 
            // SendBufferSizeLabel
            // 
            SendBufferSizeLabel.AutoSize = true;
            SendBufferSizeLabel.Location = new Point(3, 175);
            SendBufferSizeLabel.Name = "SendBufferSizeLabel";
            SendBufferSizeLabel.Size = new Size(94, 15);
            SendBufferSizeLabel.TabIndex = 38;
            SendBufferSizeLabel.Text = "Send Buffer Size:";
            // 
            // RecvBufferSizeLabel
            // 
            RecvBufferSizeLabel.AutoSize = true;
            RecvBufferSizeLabel.Location = new Point(3, 150);
            RecvBufferSizeLabel.Name = "RecvBufferSizeLabel";
            RecvBufferSizeLabel.Size = new Size(93, 15);
            RecvBufferSizeLabel.TabIndex = 37;
            RecvBufferSizeLabel.Text = "Recv Buffer Size:";
            // 
            // IOCPThreadCountLabel
            // 
            IOCPThreadCountLabel.AutoSize = true;
            IOCPThreadCountLabel.Location = new Point(3, 125);
            IOCPThreadCountLabel.Name = "IOCPThreadCountLabel";
            IOCPThreadCountLabel.Size = new Size(112, 15);
            IOCPThreadCountLabel.TabIndex = 36;
            IOCPThreadCountLabel.Text = "IOCP Thread Count:";
            // 
            // MaxWorkerCountLabel
            // 
            MaxWorkerCountLabel.AutoSize = true;
            MaxWorkerCountLabel.Location = new Point(3, 100);
            MaxWorkerCountLabel.Name = "MaxWorkerCountLabel";
            MaxWorkerCountLabel.Size = new Size(110, 15);
            MaxWorkerCountLabel.TabIndex = 35;
            MaxWorkerCountLabel.Text = "Max Worker Count:";
            // 
            // MaxGatewaySocketCountLabel
            // 
            MaxGatewaySocketCountLabel.AutoSize = true;
            MaxGatewaySocketCountLabel.Location = new Point(3, 72);
            MaxGatewaySocketCountLabel.Name = "MaxGatewaySocketCountLabel";
            MaxGatewaySocketCountLabel.Size = new Size(155, 15);
            MaxGatewaySocketCountLabel.TabIndex = 33;
            MaxGatewaySocketCountLabel.Text = "Max Gateway Socket Count:";
            // 
            // WorldServerConnectPortLabel
            // 
            WorldServerConnectPortLabel.AutoSize = true;
            WorldServerConnectPortLabel.Location = new Point(3, 47);
            WorldServerConnectPortLabel.Name = "WorldServerConnectPortLabel";
            WorldServerConnectPortLabel.Size = new Size(150, 15);
            WorldServerConnectPortLabel.TabIndex = 32;
            WorldServerConnectPortLabel.Text = "World Server Connect Port:";
            // 
            // WorldServerConnectIPLabel
            // 
            WorldServerConnectIPLabel.AutoSize = true;
            WorldServerConnectIPLabel.Location = new Point(3, 22);
            WorldServerConnectIPLabel.Name = "WorldServerConnectIPLabel";
            WorldServerConnectIPLabel.Size = new Size(138, 15);
            WorldServerConnectIPLabel.TabIndex = 31;
            WorldServerConnectIPLabel.Text = "World Server Connect IP:";
            // 
            // AssertMessageboxBox
            // 
            AssertMessageboxBox.Location = new Point(120, 325);
            AssertMessageboxBox.Name = "AssertMessageboxBox";
            AssertMessageboxBox.ReadOnly = true;
            AssertMessageboxBox.Size = new Size(100, 23);
            AssertMessageboxBox.TabIndex = 60;
            // 
            // DumpPathBox
            // 
            DumpPathBox.Location = new Point(79, 300);
            DumpPathBox.Name = "DumpPathBox";
            DumpPathBox.ReadOnly = true;
            DumpPathBox.Size = new Size(199, 23);
            DumpPathBox.TabIndex = 59;
            // 
            // DumpServerPathBox
            // 
            DumpServerPathBox.Location = new Point(114, 275);
            DumpServerPathBox.Name = "DumpServerPathBox";
            DumpServerPathBox.ReadOnly = true;
            DumpServerPathBox.Size = new Size(199, 23);
            DumpServerPathBox.TabIndex = 58;
            // 
            // AssertMessageboxLabel
            // 
            AssertMessageboxLabel.AutoSize = true;
            AssertMessageboxLabel.Location = new Point(3, 325);
            AssertMessageboxLabel.Name = "AssertMessageboxLabel";
            AssertMessageboxLabel.Size = new Size(111, 15);
            AssertMessageboxLabel.TabIndex = 57;
            AssertMessageboxLabel.Text = "Assert Messagebox:";
            // 
            // DumpPathLabel
            // 
            DumpPathLabel.AutoSize = true;
            DumpPathLabel.Location = new Point(3, 300);
            DumpPathLabel.Name = "DumpPathLabel";
            DumpPathLabel.Size = new Size(70, 15);
            DumpPathLabel.TabIndex = 56;
            DumpPathLabel.Text = "Dump Path:";
            // 
            // DumpServerPathLabel
            // 
            DumpServerPathLabel.AutoSize = true;
            DumpServerPathLabel.Location = new Point(3, 275);
            DumpServerPathLabel.Name = "DumpServerPathLabel";
            DumpServerPathLabel.Size = new Size(105, 15);
            DumpServerPathLabel.TabIndex = 55;
            DumpServerPathLabel.Text = "Dump Server Path:";
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(144, 380);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(75, 23);
            OpenButton.TabIndex = 61;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // GameConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 415);
            Controls.Add(OpenButton);
            Controls.Add(AssertMessageboxBox);
            Controls.Add(DumpPathBox);
            Controls.Add(DumpServerPathBox);
            Controls.Add(AssertMessageboxLabel);
            Controls.Add(DumpPathLabel);
            Controls.Add(DumpServerPathLabel);
            Controls.Add(MaxDumpBox);
            Controls.Add(LogConsoleLevelBox);
            Controls.Add(LogFileLevelBox);
            Controls.Add(SendBufferSizeBox);
            Controls.Add(RecvBufferSizeBox);
            Controls.Add(IOCPThreadCountBox);
            Controls.Add(MaxWorkerCountBox);
            Controls.Add(MaxGatewaySocketCountBox);
            Controls.Add(WorldServerConnectPortBox);
            Controls.Add(WorldServerConnectIPBox);
            Controls.Add(MakeDumpLabel);
            Controls.Add(LogConsoleLevelLabel);
            Controls.Add(LogFileLevelLabel);
            Controls.Add(SendBufferSizeLabel);
            Controls.Add(RecvBufferSizeLabel);
            Controls.Add(IOCPThreadCountLabel);
            Controls.Add(MaxWorkerCountLabel);
            Controls.Add(MaxGatewaySocketCountLabel);
            Controls.Add(WorldServerConnectPortLabel);
            Controls.Add(WorldServerConnectIPLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameConfig";
            Text = "GameConfig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MaxDumpBox;
        private TextBox LogConsoleLevelBox;
        private TextBox LogFileLevelBox;
        private TextBox SendBufferSizeBox;
        private TextBox RecvBufferSizeBox;
        private TextBox IOCPThreadCountBox;
        private TextBox MaxWorkerCountBox;
        private TextBox MaxGatewaySocketCountBox;
        private TextBox WorldServerConnectPortBox;
        private TextBox WorldServerConnectIPBox;
        private Label MakeDumpLabel;
        private Label LogConsoleLevelLabel;
        private Label LogFileLevelLabel;
        private Label SendBufferSizeLabel;
        private Label RecvBufferSizeLabel;
        private Label IOCPThreadCountLabel;
        private Label MaxWorkerCountLabel;
        private Label MaxGatewaySocketCountLabel;
        private Label WorldServerConnectPortLabel;
        private Label WorldServerConnectIPLabel;
        private TextBox AssertMessageboxBox;
        private TextBox DumpPathBox;
        private TextBox DumpServerPathBox;
        private Label AssertMessageboxLabel;
        private Label DumpPathLabel;
        private Label DumpServerPathLabel;
        private Button OpenButton;
    }
}
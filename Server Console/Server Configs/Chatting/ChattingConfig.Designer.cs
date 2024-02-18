namespace Server_Console.Server_Configs.Chatting
{
    partial class ChattingConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChattingConfig));
            PublicIPLabel = new Label();
            PublicPortLabel = new Label();
            WorldServerConnectIPLabel = new Label();
            WorldServerConnectPortLabel = new Label();
            MaxWorldServerConnectionSocketCountLabel = new Label();
            MaxClientSocketCountLabel = new Label();
            MaxWorkerCountLabel = new Label();
            IOCPThreadCountLabel = new Label();
            RecvBufferSizeLabel = new Label();
            SendBufferSizeLabel = new Label();
            LogFileLevelLabel = new Label();
            LogConsoleLevelLabel = new Label();
            MakeDumpLabel = new Label();
            DumpServerPathLabel = new Label();
            DumpPathLabel = new Label();
            AssertMessageboxLabel = new Label();
            PublicIPBox = new TextBox();
            PublicPortBox = new TextBox();
            WorldServerConnectIPBox = new TextBox();
            WorldServerConnectPortBox = new TextBox();
            MaxWorldServerConnectionSocketCountBox = new TextBox();
            MaxClientSocketCountBox = new TextBox();
            MaxWorkerCountBox = new TextBox();
            IOCPThreadCountBox = new TextBox();
            RecvBufferSizeBox = new TextBox();
            SendBufferSizeBox = new TextBox();
            LogFileLevelBox = new TextBox();
            LogConsoleLevelBox = new TextBox();
            MaxDumpBox = new TextBox();
            DumpServerPathBox = new TextBox();
            DumpPathBox = new TextBox();
            AssertMessageboxBox = new TextBox();
            OpenButton = new Button();
            SuspendLayout();
            // 
            // PublicIPLabel
            // 
            PublicIPLabel.AutoSize = true;
            PublicIPLabel.Location = new Point(5, 25);
            PublicIPLabel.Name = "PublicIPLabel";
            PublicIPLabel.Size = new Size(56, 15);
            PublicIPLabel.TabIndex = 0;
            PublicIPLabel.Text = "Public IP:";
            // 
            // PublicPortLabel
            // 
            PublicPortLabel.AutoSize = true;
            PublicPortLabel.Location = new Point(5, 50);
            PublicPortLabel.Name = "PublicPortLabel";
            PublicPortLabel.Size = new Size(68, 15);
            PublicPortLabel.TabIndex = 1;
            PublicPortLabel.Text = "Public Port:";
            // 
            // WorldServerConnectIPLabel
            // 
            WorldServerConnectIPLabel.AutoSize = true;
            WorldServerConnectIPLabel.Location = new Point(5, 75);
            WorldServerConnectIPLabel.Name = "WorldServerConnectIPLabel";
            WorldServerConnectIPLabel.Size = new Size(138, 15);
            WorldServerConnectIPLabel.TabIndex = 2;
            WorldServerConnectIPLabel.Text = "World Server Connect IP:";
            // 
            // WorldServerConnectPortLabel
            // 
            WorldServerConnectPortLabel.AutoSize = true;
            WorldServerConnectPortLabel.Location = new Point(5, 100);
            WorldServerConnectPortLabel.Name = "WorldServerConnectPortLabel";
            WorldServerConnectPortLabel.Size = new Size(150, 15);
            WorldServerConnectPortLabel.TabIndex = 3;
            WorldServerConnectPortLabel.Text = "World Server Connect Port:";
            // 
            // MaxWorldServerConnectionSocketCountLabel
            // 
            MaxWorldServerConnectionSocketCountLabel.AutoSize = true;
            MaxWorldServerConnectionSocketCountLabel.Location = new Point(5, 125);
            MaxWorldServerConnectionSocketCountLabel.Name = "MaxWorldServerConnectionSocketCountLabel";
            MaxWorldServerConnectionSocketCountLabel.Size = new Size(239, 15);
            MaxWorldServerConnectionSocketCountLabel.TabIndex = 4;
            MaxWorldServerConnectionSocketCountLabel.Text = "Max WorldServer Connection Socket Count:";
            // 
            // MaxClientSocketCountLabel
            // 
            MaxClientSocketCountLabel.AutoSize = true;
            MaxClientSocketCountLabel.Location = new Point(5, 150);
            MaxClientSocketCountLabel.Name = "MaxClientSocketCountLabel";
            MaxClientSocketCountLabel.Size = new Size(141, 15);
            MaxClientSocketCountLabel.TabIndex = 5;
            MaxClientSocketCountLabel.Text = "Max Client Socket Count:";
            // 
            // MaxWorkerCountLabel
            // 
            MaxWorkerCountLabel.AutoSize = true;
            MaxWorkerCountLabel.Location = new Point(5, 175);
            MaxWorkerCountLabel.Name = "MaxWorkerCountLabel";
            MaxWorkerCountLabel.Size = new Size(110, 15);
            MaxWorkerCountLabel.TabIndex = 6;
            MaxWorkerCountLabel.Text = "Max Worker Count:";
            // 
            // IOCPThreadCountLabel
            // 
            IOCPThreadCountLabel.AutoSize = true;
            IOCPThreadCountLabel.Location = new Point(5, 200);
            IOCPThreadCountLabel.Name = "IOCPThreadCountLabel";
            IOCPThreadCountLabel.Size = new Size(112, 15);
            IOCPThreadCountLabel.TabIndex = 7;
            IOCPThreadCountLabel.Text = "IOCP Thread Count:";
            // 
            // RecvBufferSizeLabel
            // 
            RecvBufferSizeLabel.AutoSize = true;
            RecvBufferSizeLabel.Location = new Point(5, 225);
            RecvBufferSizeLabel.Name = "RecvBufferSizeLabel";
            RecvBufferSizeLabel.Size = new Size(93, 15);
            RecvBufferSizeLabel.TabIndex = 8;
            RecvBufferSizeLabel.Text = "Recv Buffer Size:";
            // 
            // SendBufferSizeLabel
            // 
            SendBufferSizeLabel.AutoSize = true;
            SendBufferSizeLabel.Location = new Point(5, 250);
            SendBufferSizeLabel.Name = "SendBufferSizeLabel";
            SendBufferSizeLabel.Size = new Size(94, 15);
            SendBufferSizeLabel.TabIndex = 9;
            SendBufferSizeLabel.Text = "Send Buffer Size:";
            // 
            // LogFileLevelLabel
            // 
            LogFileLevelLabel.AutoSize = true;
            LogFileLevelLabel.Location = new Point(5, 275);
            LogFileLevelLabel.Name = "LogFileLevelLabel";
            LogFileLevelLabel.Size = new Size(81, 15);
            LogFileLevelLabel.TabIndex = 10;
            LogFileLevelLabel.Text = "Log File Level:";
            // 
            // LogConsoleLevelLabel
            // 
            LogConsoleLevelLabel.AutoSize = true;
            LogConsoleLevelLabel.Location = new Point(5, 300);
            LogConsoleLevelLabel.Name = "LogConsoleLevelLabel";
            LogConsoleLevelLabel.Size = new Size(106, 15);
            LogConsoleLevelLabel.TabIndex = 11;
            LogConsoleLevelLabel.Text = "Log Console Level:";
            // 
            // MakeDumpLabel
            // 
            MakeDumpLabel.AutoSize = true;
            MakeDumpLabel.Location = new Point(5, 325);
            MakeDumpLabel.Name = "MakeDumpLabel";
            MakeDumpLabel.Size = new Size(75, 15);
            MakeDumpLabel.TabIndex = 12;
            MakeDumpLabel.Text = "Make Dump:";
            // 
            // DumpServerPathLabel
            // 
            DumpServerPathLabel.AutoSize = true;
            DumpServerPathLabel.Location = new Point(5, 350);
            DumpServerPathLabel.Name = "DumpServerPathLabel";
            DumpServerPathLabel.Size = new Size(105, 15);
            DumpServerPathLabel.TabIndex = 13;
            DumpServerPathLabel.Text = "Dump Server Path:";
            // 
            // DumpPathLabel
            // 
            DumpPathLabel.AutoSize = true;
            DumpPathLabel.Location = new Point(5, 375);
            DumpPathLabel.Name = "DumpPathLabel";
            DumpPathLabel.Size = new Size(70, 15);
            DumpPathLabel.TabIndex = 14;
            DumpPathLabel.Text = "Dump Path:";
            // 
            // AssertMessageboxLabel
            // 
            AssertMessageboxLabel.AutoSize = true;
            AssertMessageboxLabel.Location = new Point(5, 400);
            AssertMessageboxLabel.Name = "AssertMessageboxLabel";
            AssertMessageboxLabel.Size = new Size(111, 15);
            AssertMessageboxLabel.TabIndex = 15;
            AssertMessageboxLabel.Text = "Assert Messagebox:";
            // 
            // PublicIPBox
            // 
            PublicIPBox.Location = new Point(67, 22);
            PublicIPBox.Name = "PublicIPBox";
            PublicIPBox.ReadOnly = true;
            PublicIPBox.Size = new Size(100, 23);
            PublicIPBox.TabIndex = 16;
            // 
            // PublicPortBox
            // 
            PublicPortBox.Location = new Point(79, 47);
            PublicPortBox.Name = "PublicPortBox";
            PublicPortBox.ReadOnly = true;
            PublicPortBox.Size = new Size(100, 23);
            PublicPortBox.TabIndex = 17;
            // 
            // WorldServerConnectIPBox
            // 
            WorldServerConnectIPBox.Location = new Point(149, 72);
            WorldServerConnectIPBox.Name = "WorldServerConnectIPBox";
            WorldServerConnectIPBox.ReadOnly = true;
            WorldServerConnectIPBox.Size = new Size(100, 23);
            WorldServerConnectIPBox.TabIndex = 18;
            // 
            // WorldServerConnectPortBox
            // 
            WorldServerConnectPortBox.Location = new Point(161, 97);
            WorldServerConnectPortBox.Name = "WorldServerConnectPortBox";
            WorldServerConnectPortBox.ReadOnly = true;
            WorldServerConnectPortBox.Size = new Size(100, 23);
            WorldServerConnectPortBox.TabIndex = 19;
            // 
            // MaxWorldServerConnectionSocketCountBox
            // 
            MaxWorldServerConnectionSocketCountBox.Location = new Point(250, 122);
            MaxWorldServerConnectionSocketCountBox.Name = "MaxWorldServerConnectionSocketCountBox";
            MaxWorldServerConnectionSocketCountBox.ReadOnly = true;
            MaxWorldServerConnectionSocketCountBox.Size = new Size(100, 23);
            MaxWorldServerConnectionSocketCountBox.TabIndex = 20;
            // 
            // MaxClientSocketCountBox
            // 
            MaxClientSocketCountBox.Location = new Point(152, 147);
            MaxClientSocketCountBox.Name = "MaxClientSocketCountBox";
            MaxClientSocketCountBox.ReadOnly = true;
            MaxClientSocketCountBox.Size = new Size(100, 23);
            MaxClientSocketCountBox.TabIndex = 21;
            // 
            // MaxWorkerCountBox
            // 
            MaxWorkerCountBox.Location = new Point(121, 172);
            MaxWorkerCountBox.Name = "MaxWorkerCountBox";
            MaxWorkerCountBox.ReadOnly = true;
            MaxWorkerCountBox.Size = new Size(100, 23);
            MaxWorkerCountBox.TabIndex = 22;
            // 
            // IOCPThreadCountBox
            // 
            IOCPThreadCountBox.Location = new Point(123, 197);
            IOCPThreadCountBox.Name = "IOCPThreadCountBox";
            IOCPThreadCountBox.ReadOnly = true;
            IOCPThreadCountBox.Size = new Size(100, 23);
            IOCPThreadCountBox.TabIndex = 23;
            // 
            // RecvBufferSizeBox
            // 
            RecvBufferSizeBox.Location = new Point(104, 222);
            RecvBufferSizeBox.Name = "RecvBufferSizeBox";
            RecvBufferSizeBox.ReadOnly = true;
            RecvBufferSizeBox.Size = new Size(100, 23);
            RecvBufferSizeBox.TabIndex = 24;
            // 
            // SendBufferSizeBox
            // 
            SendBufferSizeBox.Location = new Point(105, 250);
            SendBufferSizeBox.Name = "SendBufferSizeBox";
            SendBufferSizeBox.ReadOnly = true;
            SendBufferSizeBox.Size = new Size(100, 23);
            SendBufferSizeBox.TabIndex = 25;
            // 
            // LogFileLevelBox
            // 
            LogFileLevelBox.Location = new Point(92, 274);
            LogFileLevelBox.Name = "LogFileLevelBox";
            LogFileLevelBox.ReadOnly = true;
            LogFileLevelBox.Size = new Size(100, 23);
            LogFileLevelBox.TabIndex = 26;
            // 
            // LogConsoleLevelBox
            // 
            LogConsoleLevelBox.Location = new Point(117, 300);
            LogConsoleLevelBox.Name = "LogConsoleLevelBox";
            LogConsoleLevelBox.ReadOnly = true;
            LogConsoleLevelBox.Size = new Size(100, 23);
            LogConsoleLevelBox.TabIndex = 27;
            // 
            // MaxDumpBox
            // 
            MaxDumpBox.Location = new Point(80, 324);
            MaxDumpBox.Name = "MaxDumpBox";
            MaxDumpBox.ReadOnly = true;
            MaxDumpBox.Size = new Size(100, 23);
            MaxDumpBox.TabIndex = 28;
            // 
            // DumpServerPathBox
            // 
            DumpServerPathBox.Location = new Point(116, 350);
            DumpServerPathBox.Name = "DumpServerPathBox";
            DumpServerPathBox.ReadOnly = true;
            DumpServerPathBox.Size = new Size(199, 23);
            DumpServerPathBox.TabIndex = 29;
            // 
            // DumpPathBox
            // 
            DumpPathBox.Location = new Point(81, 375);
            DumpPathBox.Name = "DumpPathBox";
            DumpPathBox.ReadOnly = true;
            DumpPathBox.Size = new Size(199, 23);
            DumpPathBox.TabIndex = 30;
            // 
            // AssertMessageboxBox
            // 
            AssertMessageboxBox.Location = new Point(122, 400);
            AssertMessageboxBox.Name = "AssertMessageboxBox";
            AssertMessageboxBox.ReadOnly = true;
            AssertMessageboxBox.Size = new Size(100, 23);
            AssertMessageboxBox.TabIndex = 31;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(142, 459);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(75, 23);
            OpenButton.TabIndex = 32;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // ChattingConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 494);
            Controls.Add(OpenButton);
            Controls.Add(AssertMessageboxBox);
            Controls.Add(DumpPathBox);
            Controls.Add(DumpServerPathBox);
            Controls.Add(MaxDumpBox);
            Controls.Add(LogConsoleLevelBox);
            Controls.Add(LogFileLevelBox);
            Controls.Add(SendBufferSizeBox);
            Controls.Add(RecvBufferSizeBox);
            Controls.Add(IOCPThreadCountBox);
            Controls.Add(MaxWorkerCountBox);
            Controls.Add(MaxClientSocketCountBox);
            Controls.Add(MaxWorldServerConnectionSocketCountBox);
            Controls.Add(WorldServerConnectPortBox);
            Controls.Add(WorldServerConnectIPBox);
            Controls.Add(PublicPortBox);
            Controls.Add(PublicIPBox);
            Controls.Add(AssertMessageboxLabel);
            Controls.Add(DumpPathLabel);
            Controls.Add(DumpServerPathLabel);
            Controls.Add(MakeDumpLabel);
            Controls.Add(LogConsoleLevelLabel);
            Controls.Add(LogFileLevelLabel);
            Controls.Add(SendBufferSizeLabel);
            Controls.Add(RecvBufferSizeLabel);
            Controls.Add(IOCPThreadCountLabel);
            Controls.Add(MaxWorkerCountLabel);
            Controls.Add(MaxClientSocketCountLabel);
            Controls.Add(MaxWorldServerConnectionSocketCountLabel);
            Controls.Add(WorldServerConnectPortLabel);
            Controls.Add(WorldServerConnectIPLabel);
            Controls.Add(PublicPortLabel);
            Controls.Add(PublicIPLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChattingConfig";
            Text = "ChattingConfig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PublicIPLabel;
        private Label PublicPortLabel;
        private Label WorldServerConnectIPLabel;
        private Label WorldServerConnectPortLabel;
        private Label MaxWorldServerConnectionSocketCountLabel;
        private Label MaxClientSocketCountLabel;
        private Label MaxWorkerCountLabel;
        private Label IOCPThreadCountLabel;
        private Label RecvBufferSizeLabel;
        private Label SendBufferSizeLabel;
        private Label LogFileLevelLabel;
        private Label LogConsoleLevelLabel;
        private Label MakeDumpLabel;
        private Label DumpServerPathLabel;
        private Label DumpPathLabel;
        private Label AssertMessageboxLabel;
        private TextBox PublicIPBox;
        private TextBox PublicPortBox;
        private TextBox WorldServerConnectIPBox;
        private TextBox WorldServerConnectPortBox;
        private TextBox MaxWorldServerConnectionSocketCountBox;
        private TextBox MaxClientSocketCountBox;
        private TextBox MaxWorkerCountBox;
        private TextBox IOCPThreadCountBox;
        private TextBox RecvBufferSizeBox;
        private TextBox SendBufferSizeBox;
        private TextBox LogFileLevelBox;
        private TextBox LogConsoleLevelBox;
        private TextBox MaxDumpBox;
        private TextBox DumpServerPathBox;
        private TextBox DumpPathBox;
        private TextBox AssertMessageboxBox;
        private Button OpenButton;
    }
}
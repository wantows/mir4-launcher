namespace Mir_4_Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            LaunchButton = new Button();
            DirextXLabel = new Label();
            DX11 = new Button();
            DX12 = new Button();
            ModeLabel = new Label();
            FullscreenButton = new Button();
            BorderlessButton = new Button();
            KRButton = new Button();
            ENButton = new Button();
            CNButton = new Button();
            LauncherCheckbox = new Label();
            LauncherBox = new CheckBox();
            ResolutionLabel = new Label();
            XBox = new TextBox();
            YBox = new TextBox();
            ConfigButton = new Button();
            SuspendLayout();
            // 
            // LaunchButton
            // 
            LaunchButton.BackColor = SystemColors.Control;
            resources.ApplyResources(LaunchButton, "LaunchButton");
            LaunchButton.Name = "LaunchButton";
            LaunchButton.UseVisualStyleBackColor = false;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // DirextXLabel
            // 
            resources.ApplyResources(DirextXLabel, "DirextXLabel");
            DirextXLabel.BackColor = Color.Transparent;
            DirextXLabel.ForeColor = Color.White;
            DirextXLabel.Name = "DirextXLabel";
            // 
            // DX11
            // 
            resources.ApplyResources(DX11, "DX11");
            DX11.Name = "DX11";
            DX11.UseVisualStyleBackColor = true;
            DX11.Click += DX11_Click;
            // 
            // DX12
            // 
            resources.ApplyResources(DX12, "DX12");
            DX12.Name = "DX12";
            DX12.UseVisualStyleBackColor = true;
            DX12.Click += DX12_Click;
            // 
            // ModeLabel
            // 
            resources.ApplyResources(ModeLabel, "ModeLabel");
            ModeLabel.BackColor = Color.Transparent;
            ModeLabel.ForeColor = Color.White;
            ModeLabel.Name = "ModeLabel";
            // 
            // FullscreenButton
            // 
            resources.ApplyResources(FullscreenButton, "FullscreenButton");
            FullscreenButton.Name = "FullscreenButton";
            FullscreenButton.UseVisualStyleBackColor = true;
            FullscreenButton.Click += FullscreenButton_Click;
            // 
            // BorderlessButton
            // 
            resources.ApplyResources(BorderlessButton, "BorderlessButton");
            BorderlessButton.Name = "BorderlessButton";
            BorderlessButton.UseVisualStyleBackColor = true;
            BorderlessButton.Click += BorderlessButton_Click;
            // 
            // KRButton
            // 
            resources.ApplyResources(KRButton, "KRButton");
            KRButton.Name = "KRButton";
            KRButton.UseVisualStyleBackColor = true;
            KRButton.Click += KRButton_Click;
            // 
            // ENButton
            // 
            resources.ApplyResources(ENButton, "ENButton");
            ENButton.Name = "ENButton";
            ENButton.UseVisualStyleBackColor = true;
            ENButton.Click += ENButton_Click;
            // 
            // CNButton
            // 
            resources.ApplyResources(CNButton, "CNButton");
            CNButton.Name = "CNButton";
            CNButton.UseVisualStyleBackColor = true;
            CNButton.Click += CNButton_Click;
            // 
            // LauncherCheckbox
            // 
            resources.ApplyResources(LauncherCheckbox, "LauncherCheckbox");
            LauncherCheckbox.BackColor = Color.Transparent;
            LauncherCheckbox.ForeColor = Color.White;
            LauncherCheckbox.Name = "LauncherCheckbox";
            // 
            // LauncherBox
            // 
            resources.ApplyResources(LauncherBox, "LauncherBox");
            LauncherBox.Name = "LauncherBox";
            LauncherBox.UseVisualStyleBackColor = true;
            // 
            // ResolutionLabel
            // 
            resources.ApplyResources(ResolutionLabel, "ResolutionLabel");
            ResolutionLabel.BackColor = Color.Transparent;
            ResolutionLabel.ForeColor = Color.White;
            ResolutionLabel.Name = "ResolutionLabel";
            // 
            // XBox
            // 
            resources.ApplyResources(XBox, "XBox");
            XBox.Name = "XBox";
            XBox.ReadOnly = true;
            // 
            // YBox
            // 
            resources.ApplyResources(YBox, "YBox");
            YBox.Name = "YBox";
            YBox.ReadOnly = true;
            // 
            // ConfigButton
            // 
            ConfigButton.BackColor = Color.Transparent;
            resources.ApplyResources(ConfigButton, "ConfigButton");
            ConfigButton.FlatAppearance.BorderSize = 0;
            ConfigButton.ForeColor = Color.Transparent;
            ConfigButton.Image = Properties.Resources.Config;
            ConfigButton.Name = "ConfigButton";
            ConfigButton.UseVisualStyleBackColor = false;
            ConfigButton.Click += ConfigButton_Click;
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Splash;
            Controls.Add(ConfigButton);
            Controls.Add(YBox);
            Controls.Add(XBox);
            Controls.Add(ResolutionLabel);
            Controls.Add(LauncherBox);
            Controls.Add(LauncherCheckbox);
            Controls.Add(CNButton);
            Controls.Add(ENButton);
            Controls.Add(KRButton);
            Controls.Add(FullscreenButton);
            Controls.Add(BorderlessButton);
            Controls.Add(ModeLabel);
            Controls.Add(DX12);
            Controls.Add(DX11);
            Controls.Add(DirextXLabel);
            Controls.Add(LaunchButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LaunchButton;
        private Label DirextXLabel;
        private Button DX11;
        private Button DX12;
        private Label ModeLabel;
        private Button FullscreenButton;
        private Button BorderlessButton;
        private Button KRButton;
        private Button ENButton;
        private Button CNButton;
        private Label LauncherCheckbox;
        private CheckBox LauncherBox;
        private Label ResolutionLabel;
        private TextBox XBox;
        private TextBox YBox;
        private Button ConfigButton;
    }
}

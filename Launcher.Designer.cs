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
            SuspendLayout();
            // 
            // LaunchButton
            // 
            LaunchButton.BackColor = SystemColors.Control;
            LaunchButton.Location = new Point(450, 376);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(161, 51);
            LaunchButton.TabIndex = 0;
            LaunchButton.Text = "LAUNCH";
            LaunchButton.UseVisualStyleBackColor = false;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // DirextXLabel
            // 
            DirextXLabel.AutoSize = true;
            DirextXLabel.BackColor = Color.Transparent;
            DirextXLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DirextXLabel.ForeColor = Color.White;
            DirextXLabel.Location = new Point(12, 357);
            DirextXLabel.Name = "DirextXLabel";
            DirextXLabel.Size = new Size(97, 30);
            DirextXLabel.TabIndex = 1;
            DirextXLabel.Text = "Direct X:";
            // 
            // DX11
            // 
            DX11.Location = new Point(115, 357);
            DX11.Name = "DX11";
            DX11.Size = new Size(30, 30);
            DX11.TabIndex = 2;
            DX11.Text = "11";
            DX11.UseVisualStyleBackColor = true;
            DX11.Click += DX11_Click;
            // 
            // DX12
            // 
            DX12.Location = new Point(151, 357);
            DX12.Name = "DX12";
            DX12.Size = new Size(30, 30);
            DX12.TabIndex = 3;
            DX12.Text = "12";
            DX12.UseVisualStyleBackColor = true;
            DX12.Click += DX12_Click;
            // 
            // ModeLabel
            // 
            ModeLabel.AutoSize = true;
            ModeLabel.BackColor = Color.Transparent;
            ModeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModeLabel.ForeColor = Color.White;
            ModeLabel.Location = new Point(12, 397);
            ModeLabel.Name = "ModeLabel";
            ModeLabel.Size = new Size(76, 30);
            ModeLabel.TabIndex = 4;
            ModeLabel.Text = "Mode:";
            // 
            // FullscreenButton
            // 
            FullscreenButton.Location = new Point(187, 401);
            FullscreenButton.Name = "FullscreenButton";
            FullscreenButton.Size = new Size(87, 30);
            FullscreenButton.TabIndex = 6;
            FullscreenButton.Text = "Fullscreen";
            FullscreenButton.UseVisualStyleBackColor = true;
            FullscreenButton.Click += FullscreenButton_Click;
            // 
            // BorderlessButton
            // 
            BorderlessButton.Location = new Point(94, 401);
            BorderlessButton.Name = "BorderlessButton";
            BorderlessButton.Size = new Size(87, 30);
            BorderlessButton.TabIndex = 5;
            BorderlessButton.Text = "Windowed";
            BorderlessButton.UseVisualStyleBackColor = true;
            BorderlessButton.Click += BorderlessButton_Click;
            // 
            // Launcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Splash;
            ClientSize = new Size(1042, 441);
            Controls.Add(FullscreenButton);
            Controls.Add(BorderlessButton);
            Controls.Add(ModeLabel);
            Controls.Add(DX12);
            Controls.Add(DX11);
            Controls.Add(DirextXLabel);
            Controls.Add(LaunchButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Launcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Legend Of Mir 4 Launcher - LOMCN";
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
    }
}

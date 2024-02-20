namespace Mir_4_Launcher
{
    partial class InfoForm
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
            RZImage = new PictureBox();
            LOMCNImage = new PictureBox();
            LOMCNIconImage = new PictureBox();
            label1 = new Label();
            InfoCloseImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RZImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LOMCNImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LOMCNIconImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoCloseImage).BeginInit();
            SuspendLayout();
            // 
            // RZImage
            // 
            RZImage.BackColor = Color.Transparent;
            RZImage.Dock = DockStyle.Bottom;
            RZImage.Image = Properties.Resources.RZ;
            RZImage.Location = new Point(0, 203);
            RZImage.Name = "RZImage";
            RZImage.Size = new Size(607, 206);
            RZImage.TabIndex = 0;
            RZImage.TabStop = false;
            RZImage.Click += RZImage_Click;
            // 
            // LOMCNImage
            // 
            LOMCNImage.BackColor = Color.Transparent;
            LOMCNImage.Image = Properties.Resources.lomcn_logo;
            LOMCNImage.Location = new Point(198, 87);
            LOMCNImage.Name = "LOMCNImage";
            LOMCNImage.Size = new Size(200, 100);
            LOMCNImage.TabIndex = 1;
            LOMCNImage.TabStop = false;
            LOMCNImage.Click += LOMCNImage_Click;
            // 
            // LOMCNIconImage
            // 
            LOMCNIconImage.BackColor = Color.Transparent;
            LOMCNIconImage.Image = Properties.Resources._3f356b3ac584bd4f6d1c7722ee28a43a;
            LOMCNIconImage.Location = new Point(77, 75);
            LOMCNIconImage.Name = "LOMCNIconImage";
            LOMCNIconImage.Size = new Size(128, 128);
            LOMCNIconImage.TabIndex = 2;
            LOMCNIconImage.TabStop = false;
            LOMCNIconImage.Click += LOMCNIconImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 54);
            label1.TabIndex = 3;
            label1.Text = "Sponsored by";
            // 
            // InfoCloseImage
            // 
            InfoCloseImage.BackColor = Color.Transparent;
            InfoCloseImage.Image = Properties.Resources.Close;
            InfoCloseImage.Location = new Point(584, 12);
            InfoCloseImage.Name = "InfoCloseImage";
            InfoCloseImage.Size = new Size(11, 10);
            InfoCloseImage.TabIndex = 4;
            InfoCloseImage.TabStop = false;
            InfoCloseImage.Click += InfoCloseImage_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(607, 409);
            Controls.Add(InfoCloseImage);
            Controls.Add(label1);
            Controls.Add(LOMCNIconImage);
            Controls.Add(LOMCNImage);
            Controls.Add(RZImage);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InfoForm";
            ((System.ComponentModel.ISupportInitialize)RZImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)LOMCNImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)LOMCNIconImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoCloseImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RZImage;
        private PictureBox LOMCNImage;
        private PictureBox LOMCNIconImage;
        private Label label1;
        private PictureBox InfoCloseImage;
    }
}
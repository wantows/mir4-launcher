using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Mir_4_Launcher
{
    public partial class Launcher : Form
    {
        private CommunityForm CommunityForm;

        // Declare variables for custom dragging behavior
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private System.Windows.Forms.Timer slideshowTimer;
        private int currentImageIndex = 0;
        private Image[] slideshowImages = new Image[]
        {
            Properties.Resources.Splash,
            Properties.Resources.Splash2,
            Properties.Resources.Splash3
        };

        public Launcher()
        {
            InitializeComponent();
            InitializeSlideshowTimer();
            UpdateVersionLabel();
        }

        private void InitializeSlideshowTimer()
        {
            slideshowTimer = new System.Windows.Forms.Timer();
            slideshowTimer.Interval = 5000; // Change interval as needed (in milliseconds)
            slideshowTimer.Tick += SlideshowTimer_Tick;
            slideshowTimer.Start();
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            // Change the image in the PictureBox
            SlideshowImage.Image = slideshowImages[currentImageIndex];

            // Move to the next image
            currentImageIndex++;
            if (currentImageIndex >= slideshowImages.Length)
            {
                currentImageIndex = 0; // Start from the first image if reached the end
            }
        }

        private void CloseImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeImage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WEGREEDLABEL_Click(object sender, EventArgs e)
        {
            string link = "https://www.lomcn.net/forum/threads/mir-4-private-server-information.111906/";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameStartButton1_Click(object sender, EventArgs e)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string mirMobileFolderPath = Path.Combine(currentDirectory, "MirMobile");
            string batFilePath = Path.Combine(mirMobileFolderPath, "MirMobile_DirectX.bat");

            if (File.Exists(batFilePath))
            {
                ProcessStartInfo psi = new ProcessStartInfo(batFilePath)
                {
                    WorkingDirectory = mirMobileFolderPath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(psi);
            }
            else
            {
                MessageBox.Show("MirMobile_DirectX missing from MirMobile directory.");
            }
        }
        private void GameStartButton2_Click(object sender, EventArgs e)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string mirMobileFolderPath = Path.Combine(currentDirectory, "MirMobile");
            string batFilePath = Path.Combine(mirMobileFolderPath, "MirMobile_DirectX2.bat");

            if (File.Exists(batFilePath))
            {
                ProcessStartInfo psi = new ProcessStartInfo(batFilePath)
                {
                    WorkingDirectory = mirMobileFolderPath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(psi);
            }
            else
            {
                MessageBox.Show("MirMobile_DirectX missing from MirMobile directory.");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void CommunityImage_Click(object sender, EventArgs e)
        {
            // Create an instance of CommunityForm
            CommunityForm communityForm = new CommunityForm();

            // Calculate the location relative to the main form
            int offsetX = this.Location.X + 690; // Adjust these values as needed
            int offsetY = this.Location.Y + 40; // Adjust these values as needed
            communityForm.Location = new Point(offsetX, offsetY);

            // Show the form
            communityForm.Show();
        }

        private void CommunityLabel_Click(object sender, EventArgs e)
        {
            // Create an instance of CommunityForm
            CommunityForm communityForm = new CommunityForm();

            // Calculate the location relative to the main form
            int offsetX = this.Location.X + 690; // Adjust these values as needed
            int offsetY = this.Location.Y + 40; // Adjust these values as needed
            communityForm.Location = new Point(offsetX, offsetY);

            // Show the form
            communityForm.Show();
        }

        private void UpdateVersionLabel()
        {
            string buildVersionFilePath = Path.Combine("MirMobile", "MirMobile", "Content", "additional", "buildversion.ini");

            // Check if the build version file exists
            if (File.Exists(buildVersionFilePath))
            {
                // Read the contents of the build version file
                string[] lines = File.ReadAllLines(buildVersionFilePath);

                // Find the line containing BuildRevision
                foreach (string line in lines)
                {
                    if (line.StartsWith("BuildRevision"))
                    {
                        // Extract the BuildRevision number
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string buildRevision = parts[1].Trim();
                            VersionLabel.Text = "ver " + buildRevision;

                        }
                    }
                }
            }
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            // Open the SettingsForm when SettingsLabel is clicked
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
        private void SettingsBox_Click(object sender, EventArgs e)
        {
            // Open the SettingsForm when SettingsLabel is clicked
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void InfoImage_Click(object sender, EventArgs e)
        {
            // Open the InfoForm when Info Image is clicked
            InfoForm InfoForm = new InfoForm();
            InfoForm.ShowDialog();
        }
    }
}

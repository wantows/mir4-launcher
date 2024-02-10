using System.Diagnostics;
using System.Globalization;

namespace Mir_4_Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            Launcher_Load(null, EventArgs.Empty);
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            CheckDX();
            CheckMode();
        }

        private void CheckDX()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string batchFilePath = Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX.bat");

            if (File.Exists(batchFilePath))
            {
                string batchFileContents = File.ReadAllText(batchFilePath);

                // Check if the batch file contains "-dx12"
                if (batchFileContents.Contains("-dx12"))
                {
                    DX12.BackColor = Color.Green;
                    DX11.BackColor = Color.White;
                }
                // Check if the batch file contains "-dx11"
                else if (batchFileContents.Contains("-dx11"))
                {
                    DX11.BackColor = Color.Green;
                    DX12.BackColor = Color.White;
                }
            }
        }

        private void CheckMode()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string batchFilePath = Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX.bat");

            if (File.Exists(batchFilePath))
            {
                string batchFileContents = File.ReadAllText(batchFilePath);

                // Check if the batch file contains "-Windowed"
                if (batchFileContents.Contains("-windowed"))
                {
                    BorderlessButton.BackColor = Color.Green;
                    FullscreenButton.BackColor = Color.White;
                }
                // Check if the batch file contains "-Fullscreen"
                else if (batchFileContents.Contains("-fullscreen"))
                {
                    FullscreenButton.BackColor = Color.Green;
                    BorderlessButton.BackColor = Color.White;
                }
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (LauncherBox.Checked)
            {
                // Launch the application without closing the launcher
                LaunchApplication();
            }
            else
            {
                // Launch the application and close the launcher
                LaunchApplication();
                this.Close();
            }
        }
        private void LaunchApplication()
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

        private void DX11_Click(object sender, EventArgs e)
        {
            UpdateDirectXVersion("dx11");
            CheckDX(); // Update button colors after changing batch file
        }

        private void DX12_Click(object sender, EventArgs e)
        {
            UpdateDirectXVersion("dx12");
            CheckDX(); // Update button colors after changing batch file
        }

        private void BorderlessButton_Click(object sender, EventArgs e)
        {
            UpdateMode("windowed");
            CheckMode(); // Update button colors after changing batch file
        }

        private void FullscreenButton_Click(object sender, EventArgs e)
        {
            UpdateMode("fullscreen");
            CheckMode(); // Update button colors after changing batch file
        }
        private void UpdateDirectXVersion(string dxVersion)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string batchFilePath = Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX.bat");

            if (File.Exists(batchFilePath))
            {
                string batchFileContents = File.ReadAllText(batchFilePath);

                // Replace "dx11" or "dx12" with the new version
                batchFileContents = batchFileContents.Replace("dx11", dxVersion).Replace("dx12", dxVersion);

                // Write the updated content back to the batch file
                File.WriteAllText(batchFilePath, batchFileContents);
            }
        }
        private void UpdateMode(string modeVersion)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string batchFilePath = Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX.bat");

            if (File.Exists(batchFilePath))
            {
                string batchFileContents = File.ReadAllText(batchFilePath);

                // Replace "-windowed" or "-fullscreen" with the new mode version
                batchFileContents = batchFileContents.Replace("-windowed", "-" + modeVersion).Replace("-fullscreen", "-" + modeVersion);

                // Write the updated content back to the batch file
                File.WriteAllText(batchFilePath, batchFileContents);
            }
        }

        private void ENButton_Click(object sender, EventArgs e)
        {
            // Set the current culture back to the default
            Thread.CurrentThread.CurrentUICulture = CultureInfo.DefaultThreadCurrentUICulture ?? CultureInfo.InvariantCulture;

            // Update form's Text property (assuming it's in the default language)
            this.Text = "Legend Of Mir 4 Launcher - LOMCN";

            // Update BorderlessButton's Text property (assuming it's in the default language)
            BorderlessButton.Text = "Windowed";

            // Update FullscreenButton's Text property (assuming it's in the default language)
            FullscreenButton.Text = "Fullscreen";

            // Update LaunchButton's Text property (assuming it's in the default language)
            LaunchButton.Text = "LAUNCH";
        }

        private void KRButton_Click(object sender, EventArgs e)
        {
            // Set the current culture to Korean
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ko-KR");

            // Update form's Text property
            this.Text = "미르의 전설 4 런처 - LOMCN";

            // Update BorderlessButton's Text property
            BorderlessButton.Text = "창가";

            // Update FullscreenButton's Text property
            FullscreenButton.Text = "전체 화면";

            // Update LaunchButton's Text property
            LaunchButton.Text = "시작하다";
        }

        private void CNButton_Click(object sender, EventArgs e)
        {
            // Set the current culture to Chinese
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");

            // Update form's Text property
            this.Text = "热血传奇 4 启动器 - LOMCN";

            // Update BorderlessButton's Text property
            BorderlessButton.Text = "开窗";

            // Update FullscreenButton's Text property
            FullscreenButton.Text = "全屏";

            // Update LaunchButton's Text property
            LaunchButton.Text = "发射";
        }

        private void LOMCNRedirect_Click(object sender, EventArgs e)
        {
            // URL of the website you want to open
            string url = "https://LOMCN.net";

            // Open the default web browser with the specified URL
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
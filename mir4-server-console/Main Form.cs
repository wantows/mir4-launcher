using Server_Console.Logs.Chatting;
using Server_Console.Logs.Game;
using Server_Console.Logs.Gateway;
using Server_Console.Logs.World;
using Server_Console.Server_Configs.Chatting;
using Server_Console.Server_Configs.Game;
using Server_Console.Server_Configs.Gateway;
using Server_Console.Server_Configs.World;
using Server_Console.Server_Data;
using Server_Console.Server_Data.Gateway;
using Server_Console.Server_Data.World;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;

namespace Server_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckServerStatus();
            // Start a timer to periodically check the status every 5 seconds
            timer1.Interval = 5000; // 5 seconds
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Call CheckServerStatus periodically
            CheckServerStatus();
        }

        #region Server Checking
        private void CheckServerStatus()
        {
            CheckExecutableStatus("ChattingServer", ChattingServerButton);
            CheckExecutableStatus("GameServer", GameServerButton);
            CheckExecutableStatus("GatewayServer", GatewayServerButton);
            CheckExecutableStatus("WorldServer", WorldServerButton);
            CheckExecutableStatus("APIServer", APIServerButton);
        }
        private void CheckExecutableStatus(string serverName, Button button)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string serverPath = Path.Combine(baseDirectory, serverName, $"{serverName}.exe");

            Process[] processes = Process.GetProcessesByName(serverName);

            if (processes.Length > 0)
            {
                // Server executable is running
                button.BackColor = Color.Green;
            }
            else
            {
                // Server executable is not running
                button.BackColor = Color.Red;
            }
        }
        #endregion

        #region Launch Buttons
        private void LaunchExecutable(string exePath)
        {
            string exeDirectory = Path.GetDirectoryName(exePath);
            string exeFileName = Path.GetFileName(exePath);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = exePath,
                WorkingDirectory = exeDirectory,
                WindowStyle = ProcessWindowStyle.Minimized
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching {exeFileName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LaunchAllButton_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] exePaths = {
        Path.Combine(baseDirectory, "ChattingServer", "ChattingServer.exe"),
        Path.Combine(baseDirectory, "GameServer", "GameServer.exe"),
        Path.Combine(baseDirectory, "GatewayServer", "GatewayServer.exe"),
        Path.Combine(baseDirectory, "WorldServer", "WorldServer.exe"),
        Path.Combine(baseDirectory, "APIServer", "APIServer.exe")
    };

            foreach (string exePath in exePaths)
            {
                if (File.Exists(exePath))
                {
                    LaunchExecutable(exePath);
                }
                else
                {
                    string exeFileName = Path.GetFileName(exePath);
                    MessageBox.Show($"{exeFileName} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChattingServerButton_Click(object sender, EventArgs e)
        {
            LaunchServer("ChattingServer");
        }

        private void GameServerButton_Click(object sender, EventArgs e)
        {
            LaunchServer("GameServer");
        }

        private void GatewayServerButton_Click(object sender, EventArgs e)
        {
            LaunchServer("GatewayServer");
        }

        private void WorldServerButton_Click(object sender, EventArgs e)
        {
            LaunchServer("WorldServer");
        }
        private void APIServerButton_Click(object sender, EventArgs e)
        {
            LaunchServer("APIServer");
        }
        private void LaunchServer(string serverName)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string serverPath = Path.Combine(baseDirectory, serverName, $"{serverName}.exe");

            if (File.Exists(serverPath))
            {
                LaunchExecutable(serverPath);
            }
            else
            {
                MessageBox.Show($"{serverName}.exe not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckServerStatus();
        }
        #endregion

        #region Log Buttons
        private void ChattingLogsButton_Click(object sender, EventArgs e)
        {
            ChattingLogs chattingLogsForm = new ChattingLogs();

            chattingLogsForm.Show();
        }

        private void GameLogsButton_Click(object sender, EventArgs e)
        {
            GameLogs gameLogsForm = new GameLogs();

            gameLogsForm.Show();
        }

        private void GatewayLogsButton_Click(object sender, EventArgs e)
        {
            GatewayLogs gatewayLogsForm = new GatewayLogs();

            gatewayLogsForm.Show();
        }

        private void WorldLogsButton_Click(object sender, EventArgs e)
        {
            WorldLogs worldLogsForm = new WorldLogs();

            worldLogsForm.Show();
        }
        #endregion

        #region Config Buttons
        private void ChattingConfigButton_Click(object sender, EventArgs e)
        {
            ChattingConfig chattingConfigForm = new ChattingConfig();

            chattingConfigForm.Show();
        }

        private void GameConfigButton_Click(object sender, EventArgs e)
        {
            GameConfig gameConfigForm = new GameConfig();

            gameConfigForm.Show();
        }

        private void GatewayConfigButton_Click(object sender, EventArgs e)
        {
            GatewayConfig gatewayConfigForm = new GatewayConfig();

            gatewayConfigForm.Show();
        }

        private void WorldConfigButton_Click(object sender, EventArgs e)
        {
            WorldConfig worldConfigForm = new WorldConfig();

            worldConfigForm.Show();
        }
        #endregion

        #region Data Buttons
        private void GameDataButton_Click(object sender, EventArgs e)
        {
            GameData gameDataForm = new GameData();

            gameDataForm.Show();
        }

        private void GatewayDataButton_Click(object sender, EventArgs e)
        {
            GatewayData gatewayDataForm = new GatewayData();

            gatewayDataForm.Show();
        }

        private void WorldDataButton_Click(object sender, EventArgs e)
        {
            WorldData worldDataForm = new WorldData();

            worldDataForm.Show();
        }
        #endregion

        //private void AutoPatcherButton_Click(object sender, EventArgs e) //Jev Removed for now
        //{
        //    // Open the AMain.cs form on double-click
        //    AMain aMainForm = new AMain();
        //    aMainForm.Show();
        //}
    }
}

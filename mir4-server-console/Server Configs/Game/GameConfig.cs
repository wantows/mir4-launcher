using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Server_Console.Server_Configs.Game
{
    public partial class GameConfig : Form
    {
        private JObject configJson;
        public GameConfig()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(baseDirectory, "GameServer", "config.json");

                string jsonContent = File.ReadAllText(jsonFilePath);
                configJson = JObject.Parse(jsonContent);

                WorldServerConnectIPBox.Text = (string)configJson["game_server_info"]["world_server_connect_ip"];
                WorldServerConnectPortBox.Text = (string)configJson["game_server_info"]["world_server_connect_port"];
                MaxGatewaySocketCountBox.Text = (string)configJson["game_server_info"]["max_gateway_socket_count"];
                MaxWorkerCountBox.Text = (string)configJson["game_server_info"]["max_worker_count"];
                IOCPThreadCountBox.Text = (string)configJson["game_server_info"]["iocp_thread_count"];
                RecvBufferSizeBox.Text = (string)configJson["game_server_info"]["recv_buffer_size"];
                SendBufferSizeBox.Text = (string)configJson["game_server_info"]["send_buffer_size"];
                LogFileLevelBox.Text = (string)configJson["game_server_info"]["log_file_level"];
                LogConsoleLevelBox.Text = (string)configJson["game_server_info"]["log_console_level"];
                MaxDumpBox.Text = (string)configJson["game_server_info"]["make_dump"];
                DumpServerPathBox.Text = (string)configJson["game_server_info"]["dump_server_path"];
                DumpPathBox.Text = (string)configJson["game_server_info"]["dump_path"];
                AssertMessageboxBox.Text = (string)configJson["game_server_info"]["assert_messagebox"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading config data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of the launcher
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Construct the file path for the config JSON file
                string jsonFilePath = Path.Combine(baseDirectory, "GameServer", "config.json");

                // Open the JSON file using Notepad
                Process.Start("notepad.exe", jsonFilePath);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show($"Error opening config file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

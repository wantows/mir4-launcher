using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Server_Console.Server_Configs.World
{
    public partial class WorldConfig : Form
    {
        private JObject configJson;
        public WorldConfig()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string jsonFilePath = Path.Combine(baseDirectory, "WorldServer", "config.json");

                string jsonContent = File.ReadAllText(jsonFilePath);
                configJson = JObject.Parse(jsonContent);

                ServerIDBox.Text = ((int)configJson["world_server_info"]["server_id"]).ToString();
                GameServerConnectPortBox.Text = ((int)configJson["world_server_info"]["game_server_connect_port"]).ToString();
                MaxGameServerSocketCountBox.Text = ((int)configJson["world_server_info"]["max_game_server_socket_count"]).ToString();
                GatewayServerConnectPortBox.Text = ((int)configJson["world_server_info"]["gateway_server_connect_port"]).ToString();
                MaxGatewayServerSocketCountBox.Text = ((int)configJson["world_server_info"]["max_gateway_server_socket_count"]).ToString();
                MaxWorkerCountBox.Text = ((int)configJson["world_server_info"]["max_worker_count"]).ToString();
                IOCPThreadCountBox.Text = ((int)configJson["world_server_info"]["iocp_thread_count"]).ToString();
                RecvBufferSizeBox.Text = ((int)configJson["world_server_info"]["recv_buffer_size"]).ToString();
                SendBufferSizeBox.Text = ((int)configJson["world_server_info"]["send_buffer_size"]).ToString();
                LogFileLevelBox.Text = ((int)configJson["world_server_info"]["log_file_level"]).ToString();
                LogConsoleLevelBox.Text = ((int)configJson["world_server_info"]["log_console_level"]).ToString();
                MaxDumpBox.Text = ((int)configJson["world_server_info"]["make_dump"]).ToString();
                DumpServerPathBox.Text = (string)configJson["world_server_info"]["dump_server_path"];
                DumpPathBox.Text = (string)configJson["world_server_info"]["dump_path"];
                AssertMessageboxBox.Text = ((int)configJson["world_server_info"]["assert_messagebox"]).ToString();

                FrontDBIPBox.Text = (string)configJson["front_db_info"]["ip"];
                FrontDBPortBox.Text = ((int)configJson["front_db_info"]["port"]).ToString();
                FrontDBUserLabel.Text = (string)configJson["front_db_info"]["user"];
                FrontDBPWLabel.Text = (string)configJson["front_db_info"]["pw"];
                FrontDBBox.Text = (string)configJson["front_db_info"]["db"];
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
                string jsonFilePath = Path.Combine(baseDirectory, "WorldServer", "config.json");

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

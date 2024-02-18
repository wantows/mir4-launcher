using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mir_4_Launcher
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            ConfigTabs.SelectedIndexChanged += ConfigTabs_SelectedIndexChanged;
            LoadFileContentsIntoConfigTextBox(); // Load serverinfo.json when the form is initialized
            LoadFileContentsIntoVersionTextBox(); // Load buildversion.ini when the form is initialized
        }

        private void ConfigTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected tab is the ClientConfigTab
            if (ConfigTabs.SelectedTab == ClientConfigTab)
            {
                // No need to reload serverinfo.json if already loaded during initialization
            }
            // Check if the selected tab is the ClientVersionTab
            else if (ConfigTabs.SelectedTab == ClientVersionTab)
            {
                // No need to reload buildversion.ini if already loaded during initialization
            }
        }
        private void LoadFileContentsIntoConfigTextBox()
        {
            string fileName = "serverinfo.json";
            string directoryPath = Path.Combine(Application.StartupPath, "MirMobile", "MirMobile", "Content", "additional");
            string filePath = Path.Combine(directoryPath, fileName);

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the contents of the file
                    string fileContents = File.ReadAllText(filePath);
                    // Display the contents in the ConfigTextBox control
                    ConfigTextBox.Text = fileContents;
                }
                else
                {
                    MessageBox.Show($"{fileName} not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {fileName}: {ex.Message}");
            }
        }

        private void LoadFileContentsIntoVersionTextBox()
        {
            string fileName = "buildversion.ini";
            string directoryPath = Path.Combine(Application.StartupPath, "MirMobile", "MirMobile", "Content", "additional");
            string filePath = Path.Combine(directoryPath, fileName);

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the contents of the file
                    string fileContents = File.ReadAllText(filePath);
                    // Display the contents in the VersionTextBox control
                    VersionTextBox.Text = fileContents;
                }
                else
                {
                    MessageBox.Show($"{fileName} not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {fileName}: {ex.Message}");
            }
        }
    }
}
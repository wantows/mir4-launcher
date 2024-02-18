using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Console.Logs.Gateway
{
    public partial class GatewayLogs : Form
    {
        public GatewayLogs()
        {
            InitializeComponent();
            PopulateLogFileList();

            // Set up placeholder text
            SearchBox.Text = "Search";
            SearchBox.ForeColor = SystemColors.GrayText; // Change text color to gray
        }
        private void PopulateLogFileList()
        {
            string logDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GatewayServer", "Logs", "GatewayServer");

            // Check if the directory exists
            if (!Directory.Exists(logDirectoryPath))
            {
                MessageBox.Show("Log directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get all log files in the directory and its subdirectories with .txt extension
                string[] logFiles = Directory.GetFiles(logDirectoryPath, "*.log", SearchOption.AllDirectories);

                // Add log file names to the LogsListBox
                foreach (string logFile in logFiles)
                {
                    string fileName = Path.GetFileName(logFile);
                    LogsListBox.Items.Add(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving log files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected log file name
            string selectedLogFile = LogsListBox.SelectedItem?.ToString();

            if (selectedLogFile != null)
            {
                // Combine the log file path
                string logDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GatewayServer", "Logs", "GatewayServer");
                string logFilePath = Path.Combine(logDirectoryPath, selectedLogFile);

                try
                {
                    // Read the contents of the selected log file
                    string logContent = File.ReadAllText(logFilePath);

                    // Display the log content in the LogTextBox
                    LogTextBox.Text = logContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Search
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the SearchBox
            string searchTerm = SearchBox.Text;

            // Check if the search term is the placeholder text
            if (searchTerm == "Search")
            {
                // Restore the placeholder text color
                SearchBox.ForeColor = SystemColors.GrayText;
                return; // Exit the event handler
            }

            // Check if the LogTextBox is not empty and search term is not empty
            if (!string.IsNullOrEmpty(searchTerm) && !string.IsNullOrEmpty(LogTextBox.Text))
            {
                // Reset the selection and scroll position
                LogTextBox.SelectionStart = 0;
                LogTextBox.SelectionLength = 0;
                LogTextBox.ScrollToCaret();

                // Clear previous highlighting
                LogTextBox.SelectionBackColor = LogTextBox.BackColor;

                // Build regular expression pattern to match whole word
                string pattern = @"\b" + Regex.Escape(searchTerm) + @"\b";

                // Find all occurrences of the search term in the LogTextBox text
                MatchCollection matches = Regex.Matches(LogTextBox.Text, pattern, RegexOptions.IgnoreCase);
                foreach (Match match in matches)
                {
                    // Highlight each matched word
                    LogTextBox.Select(match.Index, match.Length);
                    LogTextBox.SelectionBackColor = Color.Yellow;
                }
            }
            else
            {
                // Reset the selection and scroll position if search term is empty
                LogTextBox.SelectionStart = 0;
                LogTextBox.SelectionLength = 0;
                LogTextBox.ScrollToCaret();
            }
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the SearchBox is entered
            if (SearchBox.Text == "Search")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = SystemColors.WindowText; // Restore default text color
            }
            else if (LogsListBox.SelectedItem == null)
            {
                // Set placeholder text to "Select a log first" if no log is selected
                SearchBox.Text = "Select a log first";
                SearchBox.ForeColor = SystemColors.GrayText; // Change text color to gray
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the SearchBox is left empty
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SearchBox.Text = "Search";
                SearchBox.ForeColor = SystemColors.GrayText; // Change text color to gray
            }
        }
        #endregion
    }
}

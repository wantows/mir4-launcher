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

namespace Server_Console.Server_Data.Gateway
{
    public partial class GatewayData : Form
    {
        public GatewayData()
        {
            InitializeComponent();
            PopulateDataListBox();
        }
        private void PopulateDataListBox()
        {
            string logDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GatewayServer", "Data");
            string[] jsonFiles = Directory.GetFiles(logDirectoryPath, "*.json");

            // Clear existing items
            DataListBox.Items.Clear();

            // Add JSON files to the ListBox
            foreach (string file in jsonFiles)
            {
                DataListBox.Items.Add(Path.GetFileName(file));
            }
        }
        private void DataListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Display the contents of the selected JSON file in the DataTextBox
            if (DataListBox.SelectedItem != null)
            {
                string selectedFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GatewayServer", "Data", DataListBox.SelectedItem.ToString());

                try
                {
                    string jsonContent = File.ReadAllText(selectedFilePath);
                    DataTextBox.Text = jsonContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading the selected JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Check if the DataTextBox is not empty and search term is not empty
            if (!string.IsNullOrEmpty(searchTerm) && !string.IsNullOrEmpty(DataTextBox.Text))
            {
                // Reset the selection and scroll position
                DataTextBox.SelectionStart = 0;
                DataTextBox.SelectionLength = 0;
                DataTextBox.ScrollToCaret();

                // Clear previous highlighting
                DataTextBox.SelectionBackColor = DataTextBox.BackColor;

                // Build regular expression pattern to match whole word
                string pattern = @"\b" + Regex.Escape(searchTerm) + @"\b";

                // Find all occurrences of the search term in the DataTextBox text
                MatchCollection matches = Regex.Matches(DataTextBox.Text, pattern, RegexOptions.IgnoreCase);
                foreach (Match match in matches)
                {
                    // Highlight each matched word
                    DataTextBox.Select(match.Index, match.Length);
                    DataTextBox.SelectionBackColor = Color.Yellow;
                }
            }
            else
            {
                // Reset the selection and scroll position if search term is empty
                DataTextBox.SelectionStart = 0;
                DataTextBox.SelectionLength = 0;
                DataTextBox.ScrollToCaret();
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
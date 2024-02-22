using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mir_4_Launcher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            UpdatePictureBoxBasedOnDXValue();
            UpdatePictureBoxBasedOnResolution();
        }
        private void UpdatePictureBoxBasedOnDXValue()
        {
            string dxBatchFilePath = Path.Combine("MirMobile", "MirMobile_DirectX.bat");

            // Check if the batch file exists
            if (File.Exists(dxBatchFilePath))
            {
                // Read the contents of the batch file
                string[] lines = File.ReadAllLines(dxBatchFilePath);

                // Flags to track if either -dx11 or -dx12 is found
                bool dx11Found = false;
                bool dx12Found = false;

                // Check each line for the DX value
                foreach (string line in lines)
                {
                    if (line.Contains("-dx11"))
                    {
                        // Set the image for the DX11Button
                        DX11Button.Image = Properties.Resources.DX11Pressed; // Replace DX11Pressed with your image resource for DirectX 11
                        DX11Button.Size = new Size(127, 37); // Set the size of the DX11Button
                        dx11Found = true;
                    }
                    else if (line.Contains("-dx12"))
                    {
                        // Set the image for the DX12Button
                        DX12Button.Image = Properties.Resources.DX12Pressed; // Replace DX12Pressed with your image resource for DirectX 12
                        DX12Button.Size = new Size(127, 37); // Set the size of the DX12Button
                        dx12Found = true;
                    }
                }

                // If neither -dx11 nor -dx12 is found, set default images and sizes
                if (!dx11Found)
                {
                    // Set default image and size for DX11Button
                    DX11Button.Image = Properties.Resources.DX11; // Replace DX11 with your default image resource
                    DX11Button.Size = new Size(100, 30); // Set the default size of the DX11Button
                }

                if (!dx12Found)
                {
                    // Set default image and size for DX12Button
                    DX12Button.Image = Properties.Resources.DX12; // Replace DX12 with your default image resource
                    DX12Button.Size = new Size(100, 30); // Set the default size of the DX12Button
                }
            }
            else
            {
                // Default images and sizes if batch file is not found
                DX11Button.Image = Properties.Resources.DX11; // Replace DX11 with your default image resource
                DX11Button.Size = new Size(100, 30); // Set the default size of the DX11Button
                DX12Button.Image = Properties.Resources.DX12; // Replace DX12 with your default image resource
                DX12Button.Size = new Size(100, 30); // Set the default size of the DX12Button
            }
        }

        private void CloseImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DX11Button_Click(object sender, EventArgs e)
        {
            UpdateDXValue("-dx11");
        }

        private void DX12Button_Click(object sender, EventArgs e)
        {
            UpdateDXValue("-dx12");
        }
        private void UpdateDXValue(string dxValue)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string[] batchFilePaths = {
        Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX.bat"),
        Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX2.bat")
    };

            foreach (string batchFilePath in batchFilePaths)
            {
                if (File.Exists(batchFilePath))
                {
                    string[] batchFileLines = File.ReadAllLines(batchFilePath);

                    for (int i = 0; i < batchFileLines.Length; i++)
                    {
                        if (batchFileLines[i].Contains("-dx11") || batchFileLines[i].Contains("-dx12"))
                        {
                            // Replace only the DirectX version in the line
                            batchFileLines[i] = batchFileLines[i].Replace("-dx11", dxValue).Replace("-dx12", dxValue);
                            break; // Assuming there's only one occurrence in a line
                        }
                    }

                    // Write the updated content back to the batch file
                    File.WriteAllLines(batchFilePath, batchFileLines);

                    // Update the images based on the new DirectX value
                    UpdatePictureBoxBasedOnDXValue();
                }
                else
                {
                    MessageBox.Show($"{Path.GetFileName(batchFilePath)} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdatePictureBoxBasedOnResolution()
        {
            string dxBatchFilePath = Path.Combine("MirMobile", "MirMobile_DirectX.bat");

            if (File.Exists(dxBatchFilePath))
            {
                string[] lines = File.ReadAllLines(dxBatchFilePath);

                bool windowedFound = lines.Any(line => line.Contains("-Windowed"));
                bool fullscreenFound = lines.Any(line => line.Contains("-Fullscreen"));

                WindowedButton.Image = windowedFound ? Properties.Resources.WindowedButtonPressed : Properties.Resources.WindowedButton;
                FullscreenButton.Image = fullscreenFound ? Properties.Resources.FullscreenButtonPressed : Properties.Resources.FullscreenButton;

                // Set the size of the buttons based on the presence of -Windowed or -Fullscreen
                WindowedButton.Size = windowedFound ? new Size(127, 37) : new Size(118, 38);
                FullscreenButton.Size = fullscreenFound ? new Size(127, 37) : new Size(118, 38);
            }
            else
            {
                // Default images and sizes if batch file is not found
                WindowedButton.Image = Properties.Resources.WindowedButton;
                FullscreenButton.Image = Properties.Resources.FullscreenButton;
                WindowedButton.Size = new Size(118, 38);
                FullscreenButton.Size = new Size(118, 38);
            }
        }

        private void UpdateResolution(string resolution)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string[] batchFilePaths = {
        Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX.bat"),
        Path.Combine(currentDirectory, "MirMobile", "MirMobile_DirectX2.bat")
    };

            foreach (string dxBatchFilePath in batchFilePaths)
            {
                if (File.Exists(dxBatchFilePath))
                {
                    string[] batchFileContents = File.ReadAllLines(dxBatchFilePath);

                    for (int i = 0; i < batchFileContents.Length; i++)
                    {
                        if (batchFileContents[i].Contains("-Windowed") || batchFileContents[i].Contains("-Fullscreen"))
                        {
                            batchFileContents[i] = resolution switch
                            {
                                "Windowed" => batchFileContents[i].Replace("-Fullscreen", "-Windowed"),
                                "Fullscreen" => batchFileContents[i].Replace("-Windowed", "-Fullscreen"),
                                _ => batchFileContents[i]
                            };
                            break; // Assuming there's only one occurrence in a line
                        }
                    }

                    File.WriteAllLines(dxBatchFilePath, batchFileContents);
                }
                else
                {
                    MessageBox.Show($"{Path.GetFileName(dxBatchFilePath)} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UpdatePictureBoxBasedOnResolution();
        }

        private void FullscreenButton_Click(object sender, EventArgs e)
        {
            UpdateResolution("Fullscreen");
        }

        private void WindowedButton_Click(object sender, EventArgs e)
        {
            UpdateResolution("Windowed");
        }
    }
}

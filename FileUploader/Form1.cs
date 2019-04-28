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

namespace FileUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseFilesButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ValidateNames = false;
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;
            dialog.Multiselect = true;
            dialog.FileName = "Must set default";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in dialog.FileNames)
                {
                    filesListbox.Items.Add(filename);
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // We need at least one file or folder:
            if (filesListbox.Items.Count > 0)
            {
                // We need also an ip-address:
                if (ipTextBox.Text != "")
                {
                    // We need also a user:
                    if (userTextBox.Text != "")
                    {
                        startButton.Enabled = false;
                        chooseFilesButton.Enabled = false;
                        sshKeyButton.Enabled = false;
                        passwordTextBox.Enabled = false;
                        ipTextBox.Enabled = false;
                        userTextBox.Enabled = false;
                        destinationTextBox.Enabled = false;
                        filesListbox.Enabled = false;

                        String output = "";
                        foreach (string filename in filesListbox.Items)
                        {
                            String args = "-r ";
                            if (sshKeyTextBox.Text != "")
                            {
                                args += "-i \"" + sshKeyTextBox.Text + "\" ";
                            }
                            if (passwordTextBox.Text != "")
                            {
                                args += "-pw \"" + passwordTextBox.Text + "\" ";
                            }

                            args += "\"" + filename + "\" \"" + userTextBox.Text + "@" + ipTextBox.Text + ":" + destinationTextBox.Text + "\"";

                            var proc = new Process
                            {
                                StartInfo = new ProcessStartInfo
                                {
                                    FileName = "pscp",
                                    Arguments = args,
                                    UseShellExecute = false,
                                    RedirectStandardOutput = true,
                                    CreateNoWindow = true
                                }
                            };

                            proc.Start();
                            while (!proc.StandardOutput.EndOfStream)
                            {
                                string line = proc.StandardOutput.ReadLine();
                                outputTextBox.Text = output + line;
                                Application.DoEvents();
                            }
                            outputTextBox.AppendText(Environment.NewLine);
                            output += outputTextBox.Text;
                        }
                        filesListbox.Items.Clear();
                        startButton.Enabled = true;
                        chooseFilesButton.Enabled = true;
                        sshKeyButton.Enabled = true;
                        passwordTextBox.Enabled = true;
                        ipTextBox.Enabled = true;
                        userTextBox.Enabled = true;
                        destinationTextBox.Enabled = true;
                        filesListbox.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("We need a username", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("We need an ip-address", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Add at least one file for upload.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SshKeyButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ValidateNames = false;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.Multiselect = false;
            dialog.FileName = "Must set default";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sshKeyTextBox.Text = dialog.FileName;
            }
        }
    }
}

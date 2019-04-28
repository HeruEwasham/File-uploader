namespace FileUploader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFilesButton = new System.Windows.Forms.Button();
            this.filesListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sshKeyTextBox = new System.Windows.Forms.TextBox();
            this.sshKeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.convertionCounterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseFilesButton
            // 
            this.chooseFilesButton.Location = new System.Drawing.Point(380, 23);
            this.chooseFilesButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chooseFilesButton.Name = "chooseFilesButton";
            this.chooseFilesButton.Size = new System.Drawing.Size(75, 53);
            this.chooseFilesButton.TabIndex = 0;
            this.chooseFilesButton.Text = "Choose files";
            this.chooseFilesButton.UseVisualStyleBackColor = true;
            this.chooseFilesButton.Click += new System.EventHandler(this.ChooseFilesButton_Click);
            // 
            // filesListbox
            // 
            this.filesListbox.FormattingEnabled = true;
            this.filesListbox.Location = new System.Drawing.Point(12, 23);
            this.filesListbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.filesListbox.Name = "filesListbox";
            this.filesListbox.Size = new System.Drawing.Size(362, 56);
            this.filesListbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SSH-key:";
            // 
            // sshKeyTextBox
            // 
            this.sshKeyTextBox.Location = new System.Drawing.Point(72, 85);
            this.sshKeyTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sshKeyTextBox.Name = "sshKeyTextBox";
            this.sshKeyTextBox.ReadOnly = true;
            this.sshKeyTextBox.Size = new System.Drawing.Size(302, 20);
            this.sshKeyTextBox.TabIndex = 4;
            // 
            // sshKeyButton
            // 
            this.sshKeyButton.Location = new System.Drawing.Point(380, 85);
            this.sshKeyButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sshKeyButton.Name = "sshKeyButton";
            this.sshKeyButton.Size = new System.Drawing.Size(75, 20);
            this.sshKeyButton.TabIndex = 5;
            this.sshKeyButton.Text = "Choose file";
            this.sshKeyButton.UseVisualStyleBackColor = true;
            this.sshKeyButton.Click += new System.EventHandler(this.SshKeyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP-address:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(72, 136);
            this.ipTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(383, 20);
            this.ipTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(72, 109);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(383, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(72, 158);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(383, 20);
            this.userTextBox.TabIndex = 12;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(72, 181);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(383, 20);
            this.destinationTextBox.TabIndex = 13;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 204);
            this.startButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(443, 22);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start uploading";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(11, 258);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(444, 98);
            this.outputTextBox.TabIndex = 15;
            // 
            // convertionCounterLabel
            // 
            this.convertionCounterLabel.AutoSize = true;
            this.convertionCounterLabel.Location = new System.Drawing.Point(10, 236);
            this.convertionCounterLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.convertionCounterLabel.Name = "convertionCounterLabel";
            this.convertionCounterLabel.Size = new System.Drawing.Size(102, 13);
            this.convertionCounterLabel.TabIndex = 16;
            this.convertionCounterLabel.Text = "Files converted: 0/0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 368);
            this.Controls.Add(this.convertionCounterLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sshKeyButton);
            this.Controls.Add(this.sshKeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesListbox);
            this.Controls.Add(this.chooseFilesButton);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "File uploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFilesButton;
        private System.Windows.Forms.ListBox filesListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sshKeyTextBox;
        private System.Windows.Forms.Button sshKeyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label convertionCounterLabel;
    }
}


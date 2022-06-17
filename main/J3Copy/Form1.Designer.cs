namespace J3Copy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.notifyTextBox = new System.Windows.Forms.TextBox();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.notifyCheckLabel = new System.Windows.Forms.Label();
            this.notifyCheckBox = new System.Windows.Forms.CheckBox();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncCheckBox = new System.Windows.Forms.CheckBox();
            this.syncLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.server1Label = new System.Windows.Forms.Label();
            this.server1TextBox = new System.Windows.Forms.TextBox();
            this.server2Label = new System.Windows.Forms.Label();
            this.server2TextBox = new System.Windows.Forms.TextBox();
            this.hardcodedLabel = new System.Windows.Forms.Label();
            this.hardcodeCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 453);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(346, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(12, 206);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(346, 241);
            this.statusTextBox.TabIndex = 4;
            this.statusTextBox.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(9, 157);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(349, 46);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.shrinkToTrayToolStripMenuItem,
            this.stopTimerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem2,
            this.exitToolStripMenuItem3});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // authorToolStripMenuItem2
            // 
            this.authorToolStripMenuItem2.Name = "authorToolStripMenuItem2";
            this.authorToolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem2.Text = "Author";
            this.authorToolStripMenuItem2.Click += new System.EventHandler(this.authorToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            this.exitToolStripMenuItem3.Click += new System.EventHandler(this.exitToolStripMenuItem3_Click);
            // 
            // shrinkToTrayToolStripMenuItem
            // 
            this.shrinkToTrayToolStripMenuItem.Name = "shrinkToTrayToolStripMenuItem";
            this.shrinkToTrayToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.shrinkToTrayToolStripMenuItem.Text = "Shrink to Tray";
            this.shrinkToTrayToolStripMenuItem.Click += new System.EventHandler(this.shrinkToTrayToolStripMenuItem_Click);
            // 
            // stopTimerToolStripMenuItem
            // 
            this.stopTimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem});
            this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
            this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.stopTimerToolStripMenuItem.Text = "Timer";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "J3Copy - Running";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem2,
            this.timerSettingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 70);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // timerSettingsToolStripMenuItem
            // 
            this.timerSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1});
            this.timerSettingsToolStripMenuItem.Name = "timerSettingsToolStripMenuItem";
            this.timerSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.timerSettingsToolStripMenuItem.Text = "Timer Settings";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.stopToolStripMenuItem1_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(125, 134);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(50, 20);
            this.timeTextBox.TabIndex = 16;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(9, 137);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(110, 13);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "Time Between Syncs:";
            // 
            // notifyTextBox
            // 
            this.notifyTextBox.Location = new System.Drawing.Point(147, 106);
            this.notifyTextBox.Name = "notifyTextBox";
            this.notifyTextBox.Size = new System.Drawing.Size(211, 20);
            this.notifyTextBox.TabIndex = 14;
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Location = new System.Drawing.Point(9, 109);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(132, 13);
            this.notifyLabel.TabIndex = 13;
            this.notifyLabel.Text = "Notification Email Address:";
            // 
            // notifyCheckLabel
            // 
            this.notifyCheckLabel.AutoSize = true;
            this.notifyCheckLabel.Location = new System.Drawing.Point(28, 86);
            this.notifyCheckLabel.Name = "notifyCheckLabel";
            this.notifyCheckLabel.Size = new System.Drawing.Size(91, 13);
            this.notifyCheckLabel.TabIndex = 17;
            this.notifyCheckLabel.Text = "Notification Email:";
            // 
            // notifyCheckBox
            // 
            this.notifyCheckBox.AutoSize = true;
            this.notifyCheckBox.Checked = true;
            this.notifyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.notifyCheckBox.Location = new System.Drawing.Point(125, 86);
            this.notifyCheckBox.Name = "notifyCheckBox";
            this.notifyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notifyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.notifyCheckBox.TabIndex = 18;
            this.notifyCheckBox.UseVisualStyleBackColor = true;
            this.notifyCheckBox.CheckedChanged += new System.EventHandler(this.notifyCheckBox_CheckedChanged);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // shrinkToTaskbarToolStripMenuItem
            // 
            this.shrinkToTaskbarToolStripMenuItem.Name = "shrinkToTaskbarToolStripMenuItem";
            this.shrinkToTaskbarToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.shrinkToTaskbarToolStripMenuItem.Text = "Shrink to Taskbar";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // shrinkToolStripMenuItem
            // 
            this.shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            this.shrinkToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.shrinkToolStripMenuItem.Text = "Shrink to Tray";
            // 
            // authorToolStripMenuItem1
            // 
            this.authorToolStripMenuItem1.Name = "authorToolStripMenuItem1";
            this.authorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.authorToolStripMenuItem1.Text = "Author";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // syncCheckBox
            // 
            this.syncCheckBox.AutoSize = true;
            this.syncCheckBox.Checked = true;
            this.syncCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.syncCheckBox.ForeColor = System.Drawing.Color.Black;
            this.syncCheckBox.Location = new System.Drawing.Point(218, 86);
            this.syncCheckBox.Name = "syncCheckBox";
            this.syncCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.syncCheckBox.Size = new System.Drawing.Size(15, 14);
            this.syncCheckBox.TabIndex = 21;
            this.syncCheckBox.UseVisualStyleBackColor = true;
            this.syncCheckBox.CheckedChanged += new System.EventHandler(this.syncCheckBox_CheckedChanged);
            // 
            // syncLabel
            // 
            this.syncLabel.AutoSize = true;
            this.syncLabel.Location = new System.Drawing.Point(146, 86);
            this.syncLabel.Name = "syncLabel";
            this.syncLabel.Size = new System.Drawing.Size(66, 13);
            this.syncLabel.TabIndex = 20;
            this.syncLabel.Text = "Single Sync:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(181, 137);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(33, 13);
            this.minutesLabel.TabIndex = 22;
            this.minutesLabel.Text = "hours";
            // 
            // server1Label
            // 
            this.server1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server1Label.Location = new System.Drawing.Point(9, 50);
            this.server1Label.Name = "server1Label";
            this.server1Label.Size = new System.Drawing.Size(163, 23);
            this.server1Label.TabIndex = 2;
            this.server1Label.Text = "Server 1";
            this.server1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // server1TextBox
            // 
            this.server1TextBox.Location = new System.Drawing.Point(12, 27);
            this.server1TextBox.Name = "server1TextBox";
            this.server1TextBox.Size = new System.Drawing.Size(163, 20);
            this.server1TextBox.TabIndex = 0;
            // 
            // server2Label
            // 
            this.server2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server2Label.Location = new System.Drawing.Point(195, 50);
            this.server2Label.Name = "server2Label";
            this.server2Label.Size = new System.Drawing.Size(163, 23);
            this.server2Label.TabIndex = 3;
            this.server2Label.Text = "Server 2";
            this.server2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // server2TextBox
            // 
            this.server2TextBox.Location = new System.Drawing.Point(195, 27);
            this.server2TextBox.Name = "server2TextBox";
            this.server2TextBox.Size = new System.Drawing.Size(163, 20);
            this.server2TextBox.TabIndex = 1;
            // 
            // hardcodedLabel
            // 
            this.hardcodedLabel.AutoSize = true;
            this.hardcodedLabel.Location = new System.Drawing.Point(239, 86);
            this.hardcodedLabel.Name = "hardcodedLabel";
            this.hardcodedLabel.Size = new System.Drawing.Size(84, 13);
            this.hardcodedLabel.TabIndex = 23;
            this.hardcodedLabel.Text = "Automatic Sync:";
            // 
            // hardcodeCheckBox
            // 
            this.hardcodeCheckBox.AutoSize = true;
            this.hardcodeCheckBox.Location = new System.Drawing.Point(329, 86);
            this.hardcodeCheckBox.Name = "hardcodeCheckBox";
            this.hardcodeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hardcodeCheckBox.TabIndex = 24;
            this.hardcodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 493);
            this.Controls.Add(this.hardcodeCheckBox);
            this.Controls.Add(this.hardcodedLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.syncCheckBox);
            this.Controls.Add(this.syncLabel);
            this.Controls.Add(this.notifyCheckBox);
            this.Controls.Add(this.notifyCheckLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.notifyTextBox);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.server2Label);
            this.Controls.Add(this.server1Label);
            this.Controls.Add(this.server2TextBox);
            this.Controls.Add(this.server1TextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(386, 532);
            this.MinimumSize = new System.Drawing.Size(386, 532);
            this.Name = "Form1";
            this.Text = "J3Copy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox notifyTextBox;
        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.Label notifyCheckLabel;
        private System.Windows.Forms.CheckBox notifyCheckBox;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToTaskbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem shrinkToTrayToolStripMenuItem;
        private System.Windows.Forms.CheckBox syncCheckBox;
        private System.Windows.Forms.Label syncLabel;
        private System.Windows.Forms.ToolStripMenuItem stopTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label server1Label;
        private System.Windows.Forms.TextBox server1TextBox;
        private System.Windows.Forms.Label server2Label;
        private System.Windows.Forms.TextBox server2TextBox;
        private System.Windows.Forms.Label hardcodedLabel;
        private System.Windows.Forms.CheckBox hardcodeCheckBox;
    }
}




//J3Copy
//By: Matt VerLee
//mtverlee@mavs.coloradomesa.edu
//v1.0



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Configuration;
using System.Timers;
using J3Copy.Properties;
using System.Resources;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Security.Principal;

namespace J3Copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyCheckBox.Checked = false;
            notifyTextBox.Enabled = false;
            syncCheckBox.Checked = true;
            timeTextBox.Enabled = false;

            checkLicense();
            if (checkAdmin() != true)
            {
                statusTextBox.AppendText("This application has not been run as administrator.\nYou may still use it but some features may not work correctly.");
            }
        }

        public static bool checkAdmin()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator));
        }

        public void checkLicense()
        {
            string connectionString = "Server=138.68.248.99; Port=3306; Database=j3copy; Uid=j3copy; Pwd=P@ssw0rd!;";

            MySqlConnection connection;
            connection = new MySqlConnection(connectionString);
            try
            {
                string query = "SELECT * FROM licensing;";
                string licenseStatus;

                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    licenseStatus = dataReader.GetString("license_status");
                    if (licenseStatus != "activated")
                    {
                        startButton.Enabled = false;
                        server1TextBox.Enabled = false;
                        server2TextBox.Enabled = false;
                        notifyTextBox.Enabled = false;
                        timeTextBox.Enabled = false;
                        notifyCheckBox.Enabled = false;
                        syncCheckBox.Enabled = false;
                        statusLabel.Text = "Activation error.";
                        statusTextBox.AppendText("This copy of J3Copy is not activated and therefore, cannot be used.\nThe developer has been sent a notification of this error.");
                        string ipAddress = new WebClient().DownloadString(@"http://icanhazip.com").Trim();
                        string messageString = "Hello Administrator,\n\n\nIt looks like someone at the IP address " + ipAddress + " is trying to use your application J3Copy without it being activated. The user has been instructed to contact you.\n\nSincerely,\nJ3Copy";
                        var fromAddress = new MailAddress("j3copynotify@gmail.com", "J3Copy");
                        var toAddress = new MailAddress("mtverlee@mavs.coloradomesa.edu");
                        string fromPassword = "lagfFt%78";
                        string subject = "J3Copy Activation Error";
                        var body = messageString;

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }
                    }
                }
                dataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void logData(ref string syncSuccess)
        {
            string connectionString = "Server=138.68.248.99; Port=3306; Database=j3copy; Uid=j3copy; Pwd=P@ssw0rd!;";

            MySqlConnection connection;
            connection = new MySqlConnection(connectionString);
            try
            {
                string dateTime = DateTime.Now.ToString("MM/dd/yyyy - HH:mm tt");
                string timerUsed;
                if (syncCheckBox.Checked == true)
                {
                    timerUsed = "false";
                }
                else
                {
                    timerUsed = "true";
                }
                string ipAddress = new WebClient().DownloadString(@"http://icanhazip.com").Trim();
                string server1Polled = server1TextBox.Text;
                server1Polled = server1Polled.Replace(@"\", @"\\");
                string server2Polled = server2TextBox.Text;
                server2Polled = server2Polled.Replace(@"\", @"\\");
                string subQuery = server1Polled + " <---> " + server2Polled;
                string syncString = "sync";
                string userName = Environment.UserDomainName + "\\" + Environment.UserName;

                // Set version value.

                string versionNumber = "1.3";

                // End set version value.
                string asAdmin, automatedSync;
                if (checkAdmin() == true)
                {
                    asAdmin = "true";
                }
                else
                {
                    asAdmin = "false";
                }

                if (hardcodeCheckBox.Checked == true)
                {
                    automatedSync = "true";
                }
                else
                {
                    automatedSync = "false";
                }

                string query = "INSERT INTO logging (datetime, ip_address, action, info, version, user, success, timer_used, as_admin, automated) VALUES ('" + dateTime + "', '" + ipAddress + "', '" + syncString + "', '" + subQuery + "', '" + versionNumber + "', '" + userName + "', '" + syncSuccess + "', '" + timerUsed + "', '" + asAdmin + "', '" + automatedSync + "')";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Main sync function.
        public void runSync()
        {
            // Checking.
            if (syncCheckBox.Checked == false)
            {
                if (timeTextBox.Text == null)
                {
                    MessageBox.Show("Sync timer not set!");
                    return;
                }
            }
            if (notifyCheckBox.Checked == true)
            {
                if (notifyTextBox.Text == null)
                {
                    MessageBox.Show("No email address set!");
                    return;
                }
            }
            if (syncCheckBox.Checked == true)
            {
                statusTextBox.Clear();
            }

            // Define variables.
            string server1String, server2String;
            server1String = '"' + server1TextBox.Text + '"';
            server2String = '"' + server2TextBox.Text + '"';

            if (hardcodeCheckBox.Checked == true)
            {
                // Main sync process (runs FileSync.exe with args).
                Process process = new Process();
                {
                    // Sync server 1 to server 2.
                    statusLabel.Text = "Syncing server 1 to server 2.";
                    process.StartInfo.FileName = "FileSync.exe";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.Arguments = server1TextBox.Text + " " + server2TextBox.Text;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    statusLabel.Text = "Syncing servers " + server1TextBox.Text + " and " + server2TextBox.Text + ".";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    string summaryString = process.StandardOutput.ReadToEnd();
                    Console.WriteLine(summaryString);
                    process.WaitForExit();

                    // Define variables.
                    string dateTimeNow = DateTime.Now.ToString("MM/dd/yyyy - HH:mm tt\n");
                    string finalString, emailString, greetingString, signatureString, startString, stopString, status1String, status2String;
                    startString = "---- Starting Sync ----\n";
                    stopString = "---- Finished Sync -----\n\n\n";
                    status1String = "Syncing " + server1TextBox.Text + " to " + server2TextBox.Text + ":\n";
                    status2String = "Syncing " + server2TextBox.Text + " to " + server1TextBox.Text + ":\n";
                    finalString = startString + dateTimeNow + summaryString + stopString;
                    greetingString = "Hello, \n\nA J3Copy Sync has been performed. Below are the details of the sync: \n\n";
                    signatureString = "\nSincerely,\nJ3Copy";
                    emailString = greetingString + finalString + signatureString;
                    statusTextBox.AppendText("\n" + finalString);

                    // If enabled, send notification email.
                    if (notifyCheckBox.Checked == true && notifyTextBox.Text != null)
                    {
                        statusLabel.Text = "Sending notification email.";
                        var fromAddress = new MailAddress("j3copynotify@gmail.com", "J3Copy");
                        var toAddress = new MailAddress(Convert.ToString(notifyTextBox.Text));
                        string fromPassword = "lagfFt%78";
                        string subject = "Your J3Copy Sync Summary";
                        var body = emailString;

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }
                        statusLabel.Text = "Sent notification email.";
                    }
                    else
                    {
                        statusLabel.Text = "Notification email not enabled.";
                    }

                    // Start timer.
                    if (syncCheckBox.Checked == false)
                    {
                        timer1.Interval = Convert.ToInt32(Convert.ToDouble(timeTextBox.Text) * 1000 * 60 * 60);
                        timer1.Enabled = true;
                    }
                    string syncSuccess = "true";
                    logData(ref syncSuccess);
                }
            } else if (hardcodeCheckBox.Checked == false)
            {
                if ((server2TextBox.Text.EndsWith("\\") && server1TextBox.Text.EndsWith("\\"))) {
                    // Main sync process (runs FileSync.exe with args).
                    Process process = new Process();
                    {
                        // Sync server 1 to server 2.
                        statusLabel.Text = "Syncing server 1 to server 2.";
                        process.StartInfo.FileName = "FileSync.exe";
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        process.StartInfo.Arguments = server1TextBox.Text + " " + server2TextBox.Text;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        statusLabel.Text = "Syncing servers " + server1TextBox.Text + " and " + server2TextBox.Text + ".";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                        string summaryString = process.StandardOutput.ReadToEnd();
                        Console.WriteLine(summaryString);
                        process.WaitForExit();

                        // Define variables.
                        string dateTimeNow = DateTime.Now.ToString("MM/dd/yyyy - HH:mm tt\n");
                        string finalString, emailString, greetingString, signatureString, startString, stopString, status1String, status2String;
                        startString = "---- Starting Sync ----\n";
                        stopString = "---- Finished Sync -----\n\n\n";
                        status1String = "Syncing " + server1TextBox.Text + " to " + server2TextBox.Text + ":\n";
                        status2String = "Syncing " + server2TextBox.Text + " to " + server1TextBox.Text + ":\n";
                        finalString = startString + dateTimeNow + summaryString + stopString;
                        greetingString = "Hello, \n\nA J3Copy Sync has been performed. Below are the details of the sync: \n\n";
                        signatureString = "\nSincerely,\nJ3Copy";
                        emailString = greetingString + finalString + signatureString;
                        statusTextBox.AppendText("\n" + finalString);

                        // If enabled, send notification email.
                        if (notifyCheckBox.Checked == true && notifyTextBox.Text != null)
                        {
                            statusLabel.Text = "Sending notification email.";
                            var fromAddress = new MailAddress("j3copynotify@gmail.com", "J3Copy");
                            var toAddress = new MailAddress(Convert.ToString(notifyTextBox.Text));
                            string fromPassword = "lagfFt%78";
                            string subject = "Your J3Copy Sync Summary";
                            var body = emailString;

                            var smtp = new SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                Subject = subject,
                                Body = body
                            })
                            {
                                smtp.Send(message);
                            }
                            statusLabel.Text = "Sent notification email.";
                        }
                        else
                        {
                            statusLabel.Text = "Notification email not enabled.";
                        }

                        // Start timer.
                        if (syncCheckBox.Checked == false)
                        {
                            timer1.Interval = Convert.ToInt32(Convert.ToDouble(timeTextBox.Text) * 1000 * 60 * 60);
                            timer1.Enabled = true;
                        }
                        string syncSuccess = "true";
                        logData(ref syncSuccess);
                    }
                }
                else
                {
                    statusTextBox.AppendText("Please make sure that all of the server locations you have selected end in a '\' and try again.");
                    string syncSuccess = "false";
                    logData(ref syncSuccess);
                }
            } else
            {
                string syncSuccess = "false";
                logData(ref syncSuccess);
            }
        }
                   
        // Start button.
        private void startButton_Click(object sender, EventArgs e)
        {
            checkLicense();
            if (hardcodeCheckBox.Checked == true)
            {
                statusTextBox.AppendText("\nSyncing share set 1 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Jobs\\";
                server2TextBox.Text = "\\\\J3SBS\\Jobs\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 2 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Accounting\\";
                server2TextBox.Text = "\\\\J3SBS\\Accounting\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 3 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Civil3D\\";
                server2TextBox.Text = "\\\\J3SBS\\Civil3D\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 4 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\J3\\";
                server2TextBox.Text = "\\\\J3SBS\\J3\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 5 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Proposals\\";
                server2TextBox.Text = "\\\\J3SBS\\Proposals\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 6 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Public\\";
                server2TextBox.Text = "\\\\J3SBS\\Public\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 7 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Software\\";
                server2TextBox.Text = "\\\\J3SBS\\Software\\";
                runSync();
                server1TextBox.Text = null;
                server2TextBox.Text = null;
            }
            else {
                runSync();
            }
        }

        // When timer expires run sync.
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipText = "J3Copy is syncing the servers you provided.";
            this.notifyIcon1.BalloonTipTitle = "J3Copy";
            this.notifyIcon1.Text = "J3Copy - Running";
            this.notifyIcon1.ShowBalloonTip(3000);
            checkLicense();
            if (hardcodeCheckBox.Checked == true)
            {
                statusTextBox.AppendText("\nSyncing share set 1 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Jobs\\";
                server2TextBox.Text = "\\\\J3SBS\\Jobs\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 2 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Accounting\\";
                server2TextBox.Text = "\\\\J3SBS\\Accounting\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 3 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Civil3D\\";
                server2TextBox.Text = "\\\\J3SBS\\Civil3D\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 4 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\J3\\";
                server2TextBox.Text = "\\\\J3SBS\\J3\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 5 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Proposals\\";
                server2TextBox.Text = "\\\\J3SBS\\Proposals\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 6 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Public\\";
                server2TextBox.Text = "\\\\J3SBS\\Public\\";
                runSync();
                statusTextBox.AppendText("\nSyncing share set 7 of 7.\n");
                server1TextBox.Text = "\\\\Louisvillenas\\Software\\";
                server2TextBox.Text = "\\\\J3SBS\\Software\\";
                runSync();
            }
            else
            {
                runSync();
            }
        }

        // Exit application.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Restore from taskbar tray.
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        // Shrink to taskbar tray.
        private void shrinkToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            this.notifyIcon1.BalloonTipText = "J3Copy has been shrunk to the taskbar! Right click on the icon to see options.";
            this.notifyIcon1.BalloonTipTitle = "J3Copy";
            this.notifyIcon1.Text = "J3Copy - Running";
            this.notifyIcon1.ShowBalloonTip(3000);
        }

        // Author information.
        private void authorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright \u00a9 2016 - Matt VerLee\nmtverlee@mavs.coloradomesa.edu\nhttps://matt-server.info", "Author");
        }

        // Exit application.
        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    
        // Exit application.
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Hide unnecessary boxes if not sending emails.
        private void notifyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (notifyCheckBox.Checked == true)
            {
                notifyTextBox.Enabled = true;
            }
            if (notifyCheckBox.Checked == false)
            {
                notifyTextBox.Enabled = false;
            }
        }

        // Hide unnecessary boxes if not sending emails.
        private void syncCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (syncCheckBox.Checked == true)
            {
                timeTextBox.Enabled = false;
            }
            if (syncCheckBox.Checked == false)
            {
                timeTextBox.Enabled = true;
            }
        }

        // Stop timer.
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            statusLabel.Text = "Stopped timer.";
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timeTextBox.Text != "")
            {
                timer1.Interval = Convert.ToInt32(Convert.ToDouble(timeTextBox.Text) * 1000 * 60);
                timer1.Start();
                statusLabel.Text = "Started timer.";
            } else
            {
                MessageBox.Show("Timer length not set!");
            }
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (timeTextBox.Text != "")
            {
                timer1.Interval = Convert.ToInt32(Convert.ToDouble(timeTextBox.Text) * 1000 * 60);
                timer1.Start();
                this.notifyIcon1.BalloonTipText = "J3Copy's timer has started.";
                this.notifyIcon1.BalloonTipTitle = "J3Copy";
                this.notifyIcon1.Text = "J3Copy - Running";
                this.notifyIcon1.ShowBalloonTip(3000);
            } else
            {
                MessageBox.Show("Timer length not set!");
            }
        }

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                timer1.Stop();
                this.notifyIcon1.BalloonTipText = "J3Copy's timer has stopped.";
                this.notifyIcon1.BalloonTipTitle = "J3Copy";
                this.notifyIcon1.Text = "J3Copy - Running";
                this.notifyIcon1.ShowBalloonTip(3000);
        }
    }
}

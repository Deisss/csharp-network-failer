using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace NetworkFailer
{
    public partial class Main : Form
    {
        private static WMINetworkManager wnm;

        // Control the automatic timer
        private static Timer betweenShutdown, shutdown;

        // Time data
        private static int betweenShutdownPause, shutdownPause, stepBetweenShutdownPause, stepShutdownPause;

        // Static version of some control to use them inside timer system
        private static Label _labelProgression;
        private static ProgressBar _progressBarProgression;

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public Main()
        {
            InitializeComponent();
            wnm = new WMINetworkManager();

            betweenShutdown = new Timer();
            shutdown = new Timer();

            // Register tick
            betweenShutdown.Tick += new EventHandler(doShutdown);
            shutdown.Tick += new EventHandler(doBetweenShutdown);

            if (!IsAdministrator())
            {
                MessageBox.Show("Error: must be run with administrator level (right click => run as administrator)", "Error");
            }
        }

        private void AutoIncreaseBetweenShutdown_CheckedChanged(object sender, EventArgs e)
        {
            increaseBetweenShutdownTime.Enabled = autoIncreaseBetweenShutdown.Checked;
        }

        private void AutoIncreaseShutdown_CheckedChanged(object sender, EventArgs e)
        {
            increaseShutdownTime.Enabled = autoIncreaseShutdown.Checked;
        }

        private void stopNetworkButton_Click(object sender, EventArgs e)
        {
            wnm.stop();
        }

        private void startNetworkButton_Click(object sender, EventArgs e)
        {
            wnm.start();
        }

        // Prepare system to start
        private void startAutoFailerButton_Click(object sender, EventArgs e)
        {
            // When tag is set to 0, we can start timer
            if (startAutoFailerButton.Tag.Equals("0"))
            {
                // First of all we start everything
                wnm.start();
                groupBoxProgression.Visible = true;
                labelProgression.BackColor = Color.ForestGreen;

                // Setting beginning interval
                betweenShutdownPause = (int)betweenShutdownTime.Value;
                shutdownPause = (int)shutdownTime.Value;

                // Detect the step to use (keep 0 if disable)
                stepBetweenShutdownPause = 0;
                if (autoIncreaseBetweenShutdown.Checked == true)
                {
                    stepBetweenShutdownPause = (int)increaseBetweenShutdownTime.Value;
                }

                stepShutdownPause = 0;
                if (autoIncreaseShutdown.Checked == true)
                {
                    stepShutdownPause = (int)increaseShutdownTime.Value;
                }

                _labelProgression = this.labelProgression;
                _progressBarProgression = this.progressBarProgression;

                // We make proggress bar to maximum, to skip a problem
                _progressBarProgression.Value = _progressBarProgression.Maximum;

                startAutoFailerButton.Text = "Stop network auto-failer";
                startAutoFailerButton.Tag = "1";

                groupBoxAutomated.Enabled = false;

                // Start system
                doBetweenShutdown(null, null);
            }
            // In other cases, we stop timer
            else
            {
                startAutoFailerButton.Text = "Start network auto-failer";
                startAutoFailerButton.Tag = "0";
                if (betweenShutdown.Enabled)
                {
                    betweenShutdown.Stop();
                }
                if (shutdown.Enabled)
                {
                    shutdown.Stop();
                }

                groupBoxAutomated.Enabled = true;

                labelProgression.BackColor = Color.ForestGreen;
                progressBarProgression.Value = 0;
                groupBoxProgression.Visible = false;
                wnm.start();
            }
        }

        // Start shutdown release
        private static void doShutdown(object sender, EventArgs e)
        {
            // Progress system
            if (_progressBarProgression.Value < _progressBarProgression.Maximum)
            {
                _progressBarProgression.Value += 1;
                // We exit (it's not time to switch timer)
                return;
            }

            // Stop previous timer
            if (betweenShutdown.Enabled)
            {
                betweenShutdown.Stop();
                betweenShutdownPause += stepBetweenShutdownPause - 1;
            }

            // Prepare graphical shutdown
            _labelProgression.BackColor = Color.Brown;
            wnm.stop();

            // Prepare progress bar
            _progressBarProgression.Minimum = 0;
            _progressBarProgression.Value = 0;
            _progressBarProgression.Maximum = shutdownPause;

            shutdown.Interval = 1000;
            shutdown.Start();
        }

        // Start between shutdown
        private static void doBetweenShutdown(object sender, EventArgs e)
        {
            // Progress system
            if (_progressBarProgression.Value < _progressBarProgression.Maximum)
            {
                _progressBarProgression.Value += 1;
                // We exit (it's not time to switch timer)
                return;
            }

            // Stop previous timer
            if (shutdown.Enabled)
            {
                shutdown.Stop();
                shutdownPause += stepShutdownPause;
            }

            // Prepare graphical release
            _labelProgression.BackColor = Color.ForestGreen;
            wnm.start();

            // Prepare progress bar
            _progressBarProgression.Minimum = 0;
            _progressBarProgression.Value = 0;
            _progressBarProgression.Maximum = betweenShutdownPause - 1;

            betweenShutdown.Interval = 1000;
            betweenShutdown.Start();
        }
    }
}

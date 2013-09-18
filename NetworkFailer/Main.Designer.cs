namespace NetworkFailer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.stopNetworkButton = new System.Windows.Forms.Button();
            this.startNetworkButton = new System.Windows.Forms.Button();
            this.groupBoxDirectAccess = new System.Windows.Forms.GroupBox();
            this.groupBoxAutomated = new System.Windows.Forms.GroupBox();
            this.groupBoxProgression = new System.Windows.Forms.GroupBox();
            this.labelProgression = new System.Windows.Forms.Label();
            this.progressBarProgression = new System.Windows.Forms.ProgressBar();
            this.startAutoFailerButton = new System.Windows.Forms.Button();
            this.increaseShutdownTime = new System.Windows.Forms.NumericUpDown();
            this.autoIncreaseShutdown = new System.Windows.Forms.CheckBox();
            this.increaseBetweenShutdownTime = new System.Windows.Forms.NumericUpDown();
            this.autoIncreaseBetweenShutdown = new System.Windows.Forms.CheckBox();
            this.shutdownTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.betweenShutdownTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDirectAccess.SuspendLayout();
            this.groupBoxAutomated.SuspendLayout();
            this.groupBoxProgression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.increaseShutdownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseBetweenShutdownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betweenShutdownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // stopNetworkButton
            // 
            this.stopNetworkButton.Location = new System.Drawing.Point(6, 19);
            this.stopNetworkButton.Name = "stopNetworkButton";
            this.stopNetworkButton.Size = new System.Drawing.Size(181, 52);
            this.stopNetworkButton.TabIndex = 0;
            this.stopNetworkButton.Text = "Stop network";
            this.stopNetworkButton.UseVisualStyleBackColor = true;
            this.stopNetworkButton.Click += new System.EventHandler(this.stopNetworkButton_Click);
            // 
            // startNetworkButton
            // 
            this.startNetworkButton.Location = new System.Drawing.Point(193, 19);
            this.startNetworkButton.Name = "startNetworkButton";
            this.startNetworkButton.Size = new System.Drawing.Size(181, 52);
            this.startNetworkButton.TabIndex = 1;
            this.startNetworkButton.Text = "Start network";
            this.startNetworkButton.UseVisualStyleBackColor = true;
            this.startNetworkButton.Click += new System.EventHandler(this.startNetworkButton_Click);
            // 
            // groupBoxDirectAccess
            // 
            this.groupBoxDirectAccess.Controls.Add(this.stopNetworkButton);
            this.groupBoxDirectAccess.Controls.Add(this.startNetworkButton);
            this.groupBoxDirectAccess.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDirectAccess.Name = "groupBoxDirectAccess";
            this.groupBoxDirectAccess.Size = new System.Drawing.Size(382, 81);
            this.groupBoxDirectAccess.TabIndex = 2;
            this.groupBoxDirectAccess.TabStop = false;
            this.groupBoxDirectAccess.Text = "Manual";
            // 
            // groupBoxAutomated
            // 
            this.groupBoxAutomated.Controls.Add(this.increaseShutdownTime);
            this.groupBoxAutomated.Controls.Add(this.autoIncreaseShutdown);
            this.groupBoxAutomated.Controls.Add(this.increaseBetweenShutdownTime);
            this.groupBoxAutomated.Controls.Add(this.autoIncreaseBetweenShutdown);
            this.groupBoxAutomated.Controls.Add(this.shutdownTime);
            this.groupBoxAutomated.Controls.Add(this.label2);
            this.groupBoxAutomated.Controls.Add(this.betweenShutdownTime);
            this.groupBoxAutomated.Controls.Add(this.label1);
            this.groupBoxAutomated.Location = new System.Drawing.Point(12, 99);
            this.groupBoxAutomated.Name = "groupBoxAutomated";
            this.groupBoxAutomated.Size = new System.Drawing.Size(382, 148);
            this.groupBoxAutomated.TabIndex = 3;
            this.groupBoxAutomated.TabStop = false;
            this.groupBoxAutomated.Text = "Automatic";
            // 
            // groupBoxProgression
            // 
            this.groupBoxProgression.Controls.Add(this.labelProgression);
            this.groupBoxProgression.Controls.Add(this.progressBarProgression);
            this.groupBoxProgression.Location = new System.Drawing.Point(21, 253);
            this.groupBoxProgression.Name = "groupBoxProgression";
            this.groupBoxProgression.Size = new System.Drawing.Size(178, 55);
            this.groupBoxProgression.TabIndex = 9;
            this.groupBoxProgression.TabStop = false;
            this.groupBoxProgression.Text = "Progression";
            this.groupBoxProgression.Visible = false;
            // 
            // labelProgression
            // 
            this.labelProgression.BackColor = System.Drawing.Color.ForestGreen;
            this.labelProgression.Location = new System.Drawing.Point(6, 20);
            this.labelProgression.Name = "labelProgression";
            this.labelProgression.Size = new System.Drawing.Size(26, 26);
            this.labelProgression.TabIndex = 1;
            // 
            // progressBarProgression
            // 
            this.progressBarProgression.Location = new System.Drawing.Point(38, 20);
            this.progressBarProgression.Name = "progressBarProgression";
            this.progressBarProgression.Size = new System.Drawing.Size(134, 26);
            this.progressBarProgression.TabIndex = 0;
            // 
            // startAutoFailerButton
            // 
            this.startAutoFailerButton.Location = new System.Drawing.Point(205, 253);
            this.startAutoFailerButton.Name = "startAutoFailerButton";
            this.startAutoFailerButton.Size = new System.Drawing.Size(181, 52);
            this.startAutoFailerButton.TabIndex = 8;
            this.startAutoFailerButton.Tag = "0";
            this.startAutoFailerButton.Text = "Start network auto-failer";
            this.startAutoFailerButton.UseVisualStyleBackColor = true;
            this.startAutoFailerButton.Click += new System.EventHandler(this.startAutoFailerButton_Click);
            // 
            // increaseShutdownTime
            // 
            this.increaseShutdownTime.Location = new System.Drawing.Point(290, 116);
            this.increaseShutdownTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.increaseShutdownTime.Name = "increaseShutdownTime";
            this.increaseShutdownTime.Size = new System.Drawing.Size(84, 20);
            this.increaseShutdownTime.TabIndex = 7;
            this.increaseShutdownTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // autoIncreaseShutdown
            // 
            this.autoIncreaseShutdown.AutoSize = true;
            this.autoIncreaseShutdown.Checked = true;
            this.autoIncreaseShutdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIncreaseShutdown.Location = new System.Drawing.Point(9, 117);
            this.autoIncreaseShutdown.Name = "autoIncreaseShutdown";
            this.autoIncreaseShutdown.Size = new System.Drawing.Size(223, 17);
            this.autoIncreaseShutdown.TabIndex = 6;
            this.autoIncreaseShutdown.Text = "Auto increate shutdown time (in seconds):";
            this.autoIncreaseShutdown.UseVisualStyleBackColor = true;
            this.autoIncreaseShutdown.CheckedChanged += new System.EventHandler(this.AutoIncreaseShutdown_CheckedChanged);
            // 
            // increaseBetweenShutdownTime
            // 
            this.increaseBetweenShutdownTime.Location = new System.Drawing.Point(290, 90);
            this.increaseBetweenShutdownTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.increaseBetweenShutdownTime.Name = "increaseBetweenShutdownTime";
            this.increaseBetweenShutdownTime.Size = new System.Drawing.Size(84, 20);
            this.increaseBetweenShutdownTime.TabIndex = 5;
            this.increaseBetweenShutdownTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // autoIncreaseBetweenShutdown
            // 
            this.autoIncreaseBetweenShutdown.AutoSize = true;
            this.autoIncreaseBetweenShutdown.Checked = true;
            this.autoIncreaseBetweenShutdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIncreaseBetweenShutdown.Location = new System.Drawing.Point(9, 91);
            this.autoIncreaseBetweenShutdown.Name = "autoIncreaseBetweenShutdown";
            this.autoIncreaseBetweenShutdown.Size = new System.Drawing.Size(269, 17);
            this.autoIncreaseBetweenShutdown.TabIndex = 4;
            this.autoIncreaseBetweenShutdown.Text = "Auto increase time between shutdown (in seconds):";
            this.autoIncreaseBetweenShutdown.UseVisualStyleBackColor = true;
            this.autoIncreaseBetweenShutdown.CheckedChanged += new System.EventHandler(this.AutoIncreaseBetweenShutdown_CheckedChanged);
            // 
            // shutdownTime
            // 
            this.shutdownTime.Location = new System.Drawing.Point(290, 45);
            this.shutdownTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shutdownTime.Name = "shutdownTime";
            this.shutdownTime.Size = new System.Drawing.Size(84, 20);
            this.shutdownTime.TabIndex = 3;
            this.shutdownTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shutdown time (in seconds):";
            // 
            // betweenShutdownTime
            // 
            this.betweenShutdownTime.Location = new System.Drawing.Point(290, 19);
            this.betweenShutdownTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betweenShutdownTime.Name = "betweenShutdownTime";
            this.betweenShutdownTime.Size = new System.Drawing.Size(84, 20);
            this.betweenShutdownTime.TabIndex = 1;
            this.betweenShutdownTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time between shutdown (in seconds):";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 314);
            this.Controls.Add(this.groupBoxProgression);
            this.Controls.Add(this.groupBoxAutomated);
            this.Controls.Add(this.startAutoFailerButton);
            this.Controls.Add(this.groupBoxDirectAccess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 115);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkFailer";
            this.groupBoxDirectAccess.ResumeLayout(false);
            this.groupBoxAutomated.ResumeLayout(false);
            this.groupBoxAutomated.PerformLayout();
            this.groupBoxProgression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.increaseShutdownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseBetweenShutdownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betweenShutdownTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopNetworkButton;
        private System.Windows.Forms.Button startNetworkButton;
        private System.Windows.Forms.GroupBox groupBoxDirectAccess;
        private System.Windows.Forms.GroupBox groupBoxAutomated;
        private System.Windows.Forms.NumericUpDown increaseShutdownTime;
        private System.Windows.Forms.CheckBox autoIncreaseShutdown;
        private System.Windows.Forms.NumericUpDown increaseBetweenShutdownTime;
        private System.Windows.Forms.CheckBox autoIncreaseBetweenShutdown;
        private System.Windows.Forms.NumericUpDown shutdownTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betweenShutdownTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startAutoFailerButton;
        private System.Windows.Forms.GroupBox groupBoxProgression;
        private System.Windows.Forms.Label labelProgression;
        private System.Windows.Forms.ProgressBar progressBarProgression;
    }
}


namespace Lego_Robot
{
    partial class defender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defender));
            this.rockPaperScissorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mazeRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.defenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblConnnection = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbLight = new System.Windows.Forms.CheckBox();
            this.pbIR = new System.Windows.Forms.ProgressBar();
            this.pbTouch = new System.Windows.Forms.ProgressBar();
            this.pbColour = new System.Windows.Forms.ProgressBar();
            this.lblInfrared = new System.Windows.Forms.Label();
            this.lblTouch = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.bttnStop = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rockPaperScissorsToolStripMenuItem
            // 
            this.rockPaperScissorsToolStripMenuItem.Name = "rockPaperScissorsToolStripMenuItem";
            this.rockPaperScissorsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.rockPaperScissorsToolStripMenuItem.Text = "Rock, Paper, Scissors";
            this.rockPaperScissorsToolStripMenuItem.Click += new System.EventHandler(this.rockPaperScissorsToolStripMenuItem_Click);
            // 
            // mazeRunnerToolStripMenuItem
            // 
            this.mazeRunnerToolStripMenuItem.Name = "mazeRunnerToolStripMenuItem";
            this.mazeRunnerToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.mazeRunnerToolStripMenuItem.Text = "Maze Runner";
            this.mazeRunnerToolStripMenuItem.Click += new System.EventHandler(this.mazeRunnerToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mazeRunnerToolStripMenuItem,
            this.defenderToolStripMenuItem,
            this.rockPaperScissorsToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(684, 24);
            this.ms.TabIndex = 37;
            this.ms.Text = "menuStrip1";
            // 
            // defenderToolStripMenuItem
            // 
            this.defenderToolStripMenuItem.Name = "defenderToolStripMenuItem";
            this.defenderToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.defenderToolStripMenuItem.Text = "Defender";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblConnnection
            // 
            this.lblConnnection.AutoSize = true;
            this.lblConnnection.Location = new System.Drawing.Point(102, 41);
            this.lblConnnection.Name = "lblConnnection";
            this.lblConnnection.Size = new System.Drawing.Size(0, 13);
            this.lblConnnection.TabIndex = 36;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(9, 41);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(97, 13);
            this.lblCon.TabIndex = 35;
            this.lblCon.Text = "Connection Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cbLight
            // 
            this.cbLight.AutoSize = true;
            this.cbLight.Location = new System.Drawing.Point(119, 97);
            this.cbLight.Name = "cbLight";
            this.cbLight.Size = new System.Drawing.Size(96, 17);
            this.cbLight.TabIndex = 32;
            this.cbLight.Text = "Light Intesnsity";
            this.cbLight.UseVisualStyleBackColor = true;
            // 
            // pbIR
            // 
            this.pbIR.Location = new System.Drawing.Point(12, 254);
            this.pbIR.Name = "pbIR";
            this.pbIR.Size = new System.Drawing.Size(100, 23);
            this.pbIR.TabIndex = 31;
            // 
            // pbTouch
            // 
            this.pbTouch.Location = new System.Drawing.Point(12, 173);
            this.pbTouch.Maximum = 1;
            this.pbTouch.Name = "pbTouch";
            this.pbTouch.Size = new System.Drawing.Size(100, 23);
            this.pbTouch.TabIndex = 30;
            // 
            // pbColour
            // 
            this.pbColour.Location = new System.Drawing.Point(12, 97);
            this.pbColour.Name = "pbColour";
            this.pbColour.Size = new System.Drawing.Size(100, 23);
            this.pbColour.TabIndex = 29;
            // 
            // lblInfrared
            // 
            this.lblInfrared.AutoSize = true;
            this.lblInfrared.Location = new System.Drawing.Point(12, 217);
            this.lblInfrared.Name = "lblInfrared";
            this.lblInfrared.Size = new System.Drawing.Size(82, 13);
            this.lblInfrared.TabIndex = 28;
            this.lblInfrared.Text = "Infrared Sensor:";
            // 
            // lblTouch
            // 
            this.lblTouch.AutoSize = true;
            this.lblTouch.Location = new System.Drawing.Point(12, 142);
            this.lblTouch.Name = "lblTouch";
            this.lblTouch.Size = new System.Drawing.Size(77, 13);
            this.lblTouch.TabIndex = 27;
            this.lblTouch.Text = "Touch Sensor:";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(12, 72);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(76, 13);
            this.lblColour.TabIndex = 26;
            this.lblColour.Text = "Colour Sensor:";
            // 
            // bttnStop
            // 
            this.bttnStop.Location = new System.Drawing.Point(456, 91);
            this.bttnStop.Name = "bttnStop";
            this.bttnStop.Size = new System.Drawing.Size(216, 23);
            this.bttnStop.TabIndex = 41;
            this.bttnStop.Text = "Stop Defender";
            this.bttnStop.UseVisualStyleBackColor = true;
            // 
            // bttnStart
            // 
            this.bttnStart.Location = new System.Drawing.Point(456, 41);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(216, 23);
            this.bttnStart.TabIndex = 40;
            this.bttnStart.Text = "Start Defender";
            this.bttnStart.UseVisualStyleBackColor = true;
            // 
            // defender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.bttnStop);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.lblConnnection);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbLight);
            this.Controls.Add(this.pbIR);
            this.Controls.Add(this.pbTouch);
            this.Controls.Add(this.pbColour);
            this.Controls.Add(this.lblInfrared);
            this.Controls.Add(this.lblTouch);
            this.Controls.Add(this.lblColour);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "defender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Defender";
            this.Load += new System.EventHandler(this.defender_Load);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem rockPaperScissorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mazeRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem defenderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblConnnection;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbLight;
        private System.Windows.Forms.ProgressBar pbIR;
        private System.Windows.Forms.ProgressBar pbTouch;
        private System.Windows.Forms.ProgressBar pbColour;
        private System.Windows.Forms.Label lblInfrared;
        private System.Windows.Forms.Label lblTouch;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Button bttnStop;
        private System.Windows.Forms.Button bttnStart;
    }
}
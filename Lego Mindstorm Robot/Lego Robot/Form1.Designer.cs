namespace Lego_Robot
{
    partial class Robot_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot_Control));
            this.bttnF = new System.Windows.Forms.Button();
            this.bttnB = new System.Windows.Forms.Button();
            this.bttnL = new System.Windows.Forms.Button();
            this.bttnR = new System.Windows.Forms.Button();
            this.bttnE = new System.Windows.Forms.Button();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblTouch = new System.Windows.Forms.Label();
            this.lblInfrared = new System.Windows.Forms.Label();
            this.pbColour = new System.Windows.Forms.ProgressBar();
            this.pbTouch = new System.Windows.Forms.ProgressBar();
            this.pbIR = new System.Windows.Forms.ProgressBar();
            this.cbLight = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnStop = new System.Windows.Forms.Button();
            this.lblConnnection = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ms = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mazeRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockPaperScissorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnF
            // 
            this.bttnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnF.Location = new System.Drawing.Point(479, 30);
            this.bttnF.Name = "bttnF";
            this.bttnF.Size = new System.Drawing.Size(75, 23);
            this.bttnF.TabIndex = 0;
            this.bttnF.Text = "Forward";
            this.bttnF.UseVisualStyleBackColor = true;
            this.bttnF.Click += new System.EventHandler(this.bttnF_Click);
            // 
            // bttnB
            // 
            this.bttnB.Location = new System.Drawing.Point(479, 120);
            this.bttnB.Name = "bttnB";
            this.bttnB.Size = new System.Drawing.Size(75, 23);
            this.bttnB.TabIndex = 1;
            this.bttnB.Text = "Backwards";
            this.bttnB.UseVisualStyleBackColor = true;
            this.bttnB.Click += new System.EventHandler(this.bttnB_Click);
            // 
            // bttnL
            // 
            this.bttnL.Location = new System.Drawing.Point(379, 75);
            this.bttnL.Name = "bttnL";
            this.bttnL.Size = new System.Drawing.Size(75, 23);
            this.bttnL.TabIndex = 2;
            this.bttnL.Text = "Left";
            this.bttnL.UseVisualStyleBackColor = true;
            this.bttnL.Click += new System.EventHandler(this.bttnL_Click);
            // 
            // bttnR
            // 
            this.bttnR.Location = new System.Drawing.Point(579, 75);
            this.bttnR.Name = "bttnR";
            this.bttnR.Size = new System.Drawing.Size(75, 23);
            this.bttnR.TabIndex = 3;
            this.bttnR.Text = "&R&ight";
            this.bttnR.UseVisualStyleBackColor = true;
            this.bttnR.Click += new System.EventHandler(this.bttnR_Click);
            this.bttnR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bttnR_KeyDown);
            // 
            // bttnE
            // 
            this.bttnE.Location = new System.Drawing.Point(295, 326);
            this.bttnE.Name = "bttnE";
            this.bttnE.Size = new System.Drawing.Size(75, 23);
            this.bttnE.TabIndex = 5;
            this.bttnE.Text = "Exit";
            this.bttnE.UseVisualStyleBackColor = true;
            this.bttnE.Click += new System.EventHandler(this.bttnE_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(12, 66);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(76, 13);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour Sensor:";
            // 
            // lblTouch
            // 
            this.lblTouch.AutoSize = true;
            this.lblTouch.Location = new System.Drawing.Point(12, 136);
            this.lblTouch.Name = "lblTouch";
            this.lblTouch.Size = new System.Drawing.Size(77, 13);
            this.lblTouch.TabIndex = 7;
            this.lblTouch.Text = "Touch Sensor:";
            // 
            // lblInfrared
            // 
            this.lblInfrared.AutoSize = true;
            this.lblInfrared.Location = new System.Drawing.Point(12, 211);
            this.lblInfrared.Name = "lblInfrared";
            this.lblInfrared.Size = new System.Drawing.Size(82, 13);
            this.lblInfrared.TabIndex = 8;
            this.lblInfrared.Text = "Infrared Sensor:";
            // 
            // pbColour
            // 
            this.pbColour.Location = new System.Drawing.Point(12, 91);
            this.pbColour.Name = "pbColour";
            this.pbColour.Size = new System.Drawing.Size(100, 23);
            this.pbColour.TabIndex = 9;
            // 
            // pbTouch
            // 
            this.pbTouch.Location = new System.Drawing.Point(12, 167);
            this.pbTouch.Maximum = 1;
            this.pbTouch.Name = "pbTouch";
            this.pbTouch.Size = new System.Drawing.Size(100, 23);
            this.pbTouch.TabIndex = 10;
            // 
            // pbIR
            // 
            this.pbIR.Location = new System.Drawing.Point(12, 248);
            this.pbIR.Name = "pbIR";
            this.pbIR.Size = new System.Drawing.Size(100, 23);
            this.pbIR.TabIndex = 11;
            // 
            // cbLight
            // 
            this.cbLight.AutoSize = true;
            this.cbLight.Location = new System.Drawing.Point(119, 91);
            this.cbLight.Name = "cbLight";
            this.cbLight.Size = new System.Drawing.Size(96, 17);
            this.cbLight.TabIndex = 12;
            this.cbLight.Text = "Light Intesnsity";
            this.cbLight.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bttnStop
            // 
            this.bttnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnStop.Location = new System.Drawing.Point(479, 75);
            this.bttnStop.Name = "bttnStop";
            this.bttnStop.Size = new System.Drawing.Size(75, 23);
            this.bttnStop.TabIndex = 16;
            this.bttnStop.Text = "Stop";
            this.bttnStop.UseVisualStyleBackColor = true;
            this.bttnStop.Click += new System.EventHandler(this.bttnStop_Click);
            // 
            // lblConnnection
            // 
            this.lblConnnection.AutoSize = true;
            this.lblConnnection.Location = new System.Drawing.Point(102, 35);
            this.lblConnnection.Name = "lblConnnection";
            this.lblConnnection.Size = new System.Drawing.Size(0, 13);
            this.lblConnnection.TabIndex = 19;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(9, 35);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(97, 13);
            this.lblCon.TabIndex = 18;
            this.lblCon.Text = "Connection Status:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
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
            this.ms.TabIndex = 20;
            this.ms.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // mazeRunnerToolStripMenuItem
            // 
            this.mazeRunnerToolStripMenuItem.Name = "mazeRunnerToolStripMenuItem";
            this.mazeRunnerToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.mazeRunnerToolStripMenuItem.Text = "Maze Runner";
            this.mazeRunnerToolStripMenuItem.Click += new System.EventHandler(this.mazeRunnerToolStripMenuItem_Click);
            // 
            // defenderToolStripMenuItem
            // 
            this.defenderToolStripMenuItem.Name = "defenderToolStripMenuItem";
            this.defenderToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.defenderToolStripMenuItem.Text = "Defender";
            this.defenderToolStripMenuItem.Click += new System.EventHandler(this.defenderToolStripMenuItem_Click);
            // 
            // rockPaperScissorsToolStripMenuItem
            // 
            this.rockPaperScissorsToolStripMenuItem.Name = "rockPaperScissorsToolStripMenuItem";
            this.rockPaperScissorsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.rockPaperScissorsToolStripMenuItem.Text = "Rock, Paper, Scissors";
            this.rockPaperScissorsToolStripMenuItem.Click += new System.EventHandler(this.rockPaperScissorsToolStripMenuItem_Click);
            // 
            // Robot_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.lblConnnection);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.bttnStop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbLight);
            this.Controls.Add(this.pbIR);
            this.Controls.Add(this.pbTouch);
            this.Controls.Add(this.pbColour);
            this.Controls.Add(this.lblInfrared);
            this.Controls.Add(this.lblTouch);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.bttnE);
            this.Controls.Add(this.bttnR);
            this.Controls.Add(this.bttnL);
            this.Controls.Add(this.bttnB);
            this.Controls.Add(this.bttnF);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(600, 200);
            this.MainMenuStrip = this.ms;
            this.Name = "Robot_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Robot Control";
            this.Load += new System.EventHandler(this.Robot_Control_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Robot_Control_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Robot_Control_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnF;
        private System.Windows.Forms.Button bttnB;
        private System.Windows.Forms.Button bttnL;
        private System.Windows.Forms.Button bttnR;
        private System.Windows.Forms.Button bttnE;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblTouch;
        private System.Windows.Forms.Label lblInfrared;
        private System.Windows.Forms.ProgressBar pbColour;
        private System.Windows.Forms.ProgressBar pbTouch;
        private System.Windows.Forms.ProgressBar pbIR;
        private System.Windows.Forms.CheckBox cbLight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnStop;
        private System.Windows.Forms.Label lblConnnection;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mazeRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rockPaperScissorsToolStripMenuItem;
    }
}


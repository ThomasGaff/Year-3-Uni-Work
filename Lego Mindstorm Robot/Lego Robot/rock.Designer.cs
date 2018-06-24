namespace Lego_Robot
{
    partial class rock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rock));
            this.ms = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mazeRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockPaperScissorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConnnection = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnplay = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblUC = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblUResult = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.lblTieR = new System.Windows.Forms.Label();
            this.lblLossR = new System.Windows.Forms.Label();
            this.lblWinR = new System.Windows.Forms.Label();
            this.ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(456, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // bttnplay
            // 
            this.bttnplay.Location = new System.Drawing.Point(270, 183);
            this.bttnplay.Name = "bttnplay";
            this.bttnplay.Size = new System.Drawing.Size(114, 46);
            this.bttnplay.TabIndex = 38;
            this.bttnplay.Text = "Play";
            this.bttnplay.UseVisualStyleBackColor = true;
            this.bttnplay.Click += new System.EventHandler(this.bttnplay_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(13, 325);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(75, 23);
            this.bttnReset.TabIndex = 39;
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 40;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(66, 130);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 41;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(12, 76);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(96, 13);
            this.lblCC.TabIndex = 42;
            this.lblCC.Text = "PUPP3R\'s Choice:";
            // 
            // lblUC
            // 
            this.lblUC.AutoSize = true;
            this.lblUC.Location = new System.Drawing.Point(12, 103);
            this.lblUC.Name = "lblUC";
            this.lblUC.Size = new System.Drawing.Size(75, 13);
            this.lblUC.TabIndex = 43;
            this.lblUC.Text = "User\'s Choice:";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(13, 130);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(53, 13);
            this.lblOutcome.TabIndex = 44;
            this.lblOutcome.Text = "Outcome:";
            // 
            // lblUResult
            // 
            this.lblUResult.AutoSize = true;
            this.lblUResult.Location = new System.Drawing.Point(86, 103);
            this.lblUResult.Name = "lblUResult";
            this.lblUResult.Size = new System.Drawing.Size(0, 13);
            this.lblUResult.TabIndex = 45;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(13, 152);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(86, 13);
            this.v.TabIndex = 46;
            this.v.Text = "Number of Wins:";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Location = new System.Drawing.Point(13, 174);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(95, 13);
            this.lblLoss.TabIndex = 47;
            this.lblLoss.Text = "Number of Losses:";
            this.lblLoss.Click += new System.EventHandler(this.lblLoss_Click);
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Location = new System.Drawing.Point(13, 195);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(82, 13);
            this.lblTie.TabIndex = 48;
            this.lblTie.Text = "Number of Ties:";
            // 
            // lblTieR
            // 
            this.lblTieR.AutoSize = true;
            this.lblTieR.Location = new System.Drawing.Point(95, 195);
            this.lblTieR.Name = "lblTieR";
            this.lblTieR.Size = new System.Drawing.Size(13, 13);
            this.lblTieR.TabIndex = 49;
            this.lblTieR.Text = "0";
            // 
            // lblLossR
            // 
            this.lblLossR.AutoSize = true;
            this.lblLossR.Location = new System.Drawing.Point(106, 174);
            this.lblLossR.Name = "lblLossR";
            this.lblLossR.Size = new System.Drawing.Size(13, 13);
            this.lblLossR.TabIndex = 50;
            this.lblLossR.Text = "0";
            // 
            // lblWinR
            // 
            this.lblWinR.AutoSize = true;
            this.lblWinR.Location = new System.Drawing.Point(97, 152);
            this.lblWinR.Name = "lblWinR";
            this.lblWinR.Size = new System.Drawing.Size(13, 13);
            this.lblWinR.TabIndex = 51;
            this.lblWinR.Text = "0";
            // 
            // rock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lblWinR);
            this.Controls.Add(this.lblLossR);
            this.Controls.Add(this.lblTieR);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.v);
            this.Controls.Add(this.lblUResult);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblUC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.bttnplay);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.lblConnnection);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "rock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.rock_Load);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mazeRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rockPaperScissorsToolStripMenuItem;
        private System.Windows.Forms.Label lblConnnection;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnplay;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblUC;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblUResult;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.Label lblTieR;
        private System.Windows.Forms.Label lblLossR;
        private System.Windows.Forms.Label lblWinR;
    }
}
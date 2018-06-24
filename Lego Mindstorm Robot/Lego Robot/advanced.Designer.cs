namespace Lego_Robot
{
    partial class advanced
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
            this.bttnRB = new System.Windows.Forms.Button();
            this.bttnLB = new System.Windows.Forms.Button();
            this.txtRB = new System.Windows.Forms.TextBox();
            this.txtLB = new System.Windows.Forms.TextBox();
            this.bttnFB = new System.Windows.Forms.Button();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.bttnBB = new System.Windows.Forms.Button();
            this.txtBB = new System.Windows.Forms.TextBox();
            this.bttnB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnRB
            // 
            this.bttnRB.Location = new System.Drawing.Point(13, 61);
            this.bttnRB.Name = "bttnRB";
            this.bttnRB.Size = new System.Drawing.Size(75, 23);
            this.bttnRB.TabIndex = 0;
            this.bttnRB.Text = "Right by:";
            this.bttnRB.UseVisualStyleBackColor = true;
            // 
            // bttnLB
            // 
            this.bttnLB.Location = new System.Drawing.Point(297, 61);
            this.bttnLB.Name = "bttnLB";
            this.bttnLB.Size = new System.Drawing.Size(75, 23);
            this.bttnLB.TabIndex = 1;
            this.bttnLB.Text = "Left by:";
            this.bttnLB.UseVisualStyleBackColor = true;
            // 
            // txtRB
            // 
            this.txtRB.Location = new System.Drawing.Point(13, 91);
            this.txtRB.Name = "txtRB";
            this.txtRB.Size = new System.Drawing.Size(75, 20);
            this.txtRB.TabIndex = 2;
            // 
            // txtLB
            // 
            this.txtLB.Location = new System.Drawing.Point(297, 90);
            this.txtLB.Name = "txtLB";
            this.txtLB.Size = new System.Drawing.Size(75, 20);
            this.txtLB.TabIndex = 3;
            // 
            // bttnFB
            // 
            this.bttnFB.Location = new System.Drawing.Point(154, 13);
            this.bttnFB.Name = "bttnFB";
            this.bttnFB.Size = new System.Drawing.Size(75, 23);
            this.bttnFB.TabIndex = 4;
            this.bttnFB.Text = "Forward by:";
            this.bttnFB.UseVisualStyleBackColor = true;
            // 
            // txtFB
            // 
            this.txtFB.Location = new System.Drawing.Point(154, 42);
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(75, 20);
            this.txtFB.TabIndex = 5;
            // 
            // bttnBB
            // 
            this.bttnBB.Location = new System.Drawing.Point(154, 124);
            this.bttnBB.Name = "bttnBB";
            this.bttnBB.Size = new System.Drawing.Size(75, 23);
            this.bttnBB.TabIndex = 6;
            this.bttnBB.Text = "Back by:";
            this.bttnBB.UseVisualStyleBackColor = true;
            // 
            // txtBB
            // 
            this.txtBB.Location = new System.Drawing.Point(154, 153);
            this.txtBB.Name = "txtBB";
            this.txtBB.Size = new System.Drawing.Size(75, 20);
            this.txtBB.TabIndex = 7;
            // 
            // bttnB
            // 
            this.bttnB.Location = new System.Drawing.Point(13, 13);
            this.bttnB.Name = "bttnB";
            this.bttnB.Size = new System.Drawing.Size(75, 23);
            this.bttnB.TabIndex = 8;
            this.bttnB.Text = "Basic";
            this.bttnB.UseVisualStyleBackColor = true;
            this.bttnB.Click += new System.EventHandler(this.bttnB_Click);
            // 
            // advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.bttnB);
            this.Controls.Add(this.txtBB);
            this.Controls.Add(this.bttnBB);
            this.Controls.Add(this.txtFB);
            this.Controls.Add(this.bttnFB);
            this.Controls.Add(this.txtLB);
            this.Controls.Add(this.txtRB);
            this.Controls.Add(this.bttnLB);
            this.Controls.Add(this.bttnRB);
            this.Name = "advanced";
            this.Text = "Robot Control";
            this.Load += new System.EventHandler(this.advanced_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnRB;
        private System.Windows.Forms.Button bttnLB;
        private System.Windows.Forms.TextBox txtRB;
        private System.Windows.Forms.TextBox txtLB;
        private System.Windows.Forms.Button bttnFB;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.Button bttnBB;
        private System.Windows.Forms.TextBox txtBB;
        private System.Windows.Forms.Button bttnB;
    }
}
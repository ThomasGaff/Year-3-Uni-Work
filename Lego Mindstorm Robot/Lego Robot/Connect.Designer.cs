namespace Lego_Robot
{
    partial class Connect
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
            this.bttnConnnect = new System.Windows.Forms.Button();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnConnnect
            // 
            this.bttnConnnect.Location = new System.Drawing.Point(29, 126);
            this.bttnConnnect.Name = "bttnConnnect";
            this.bttnConnnect.Size = new System.Drawing.Size(75, 23);
            this.bttnConnnect.TabIndex = 0;
            this.bttnConnnect.Text = "Connect";
            this.bttnConnnect.UseVisualStyleBackColor = true;
            this.bttnConnnect.Click += new System.EventHandler(this.bttnConnnect_Click);
            // 
            // txtcom
            // 
            this.txtcom.Location = new System.Drawing.Point(18, 75);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(100, 20);
            this.txtcom.TabIndex = 1;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(18, 27);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(93, 13);
            this.lblCom.TabIndex = 2;
            this.lblCom.Text = "Com Port Number:";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(134, 161);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.bttnConnnect);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "Connect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.Connect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnConnnect;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.Label lblCom;
    }
}
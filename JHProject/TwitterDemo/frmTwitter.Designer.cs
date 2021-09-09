namespace TwitterDemo
{
    partial class frmTwitter
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
            this.tabTwitter = new System.Windows.Forms.TabControl();
            this.tabTotalTweet = new System.Windows.Forms.TabPage();
            this.tabAverage = new System.Windows.Forms.TabPage();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.tabTwitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTwitter
            // 
            this.tabTwitter.Controls.Add(this.tabWelcome);
            this.tabTwitter.Controls.Add(this.tabTotalTweet);
            this.tabTwitter.Controls.Add(this.tabAverage);
            this.tabTwitter.Location = new System.Drawing.Point(14, 41);
            this.tabTwitter.Name = "tabTwitter";
            this.tabTwitter.SelectedIndex = 0;
            this.tabTwitter.Size = new System.Drawing.Size(770, 344);
            this.tabTwitter.TabIndex = 0;
            // 
            // tabTotalTweet
            // 
            this.tabTotalTweet.Location = new System.Drawing.Point(4, 25);
            this.tabTotalTweet.Name = "tabTotalTweet";
            this.tabTotalTweet.Padding = new System.Windows.Forms.Padding(3);
            this.tabTotalTweet.Size = new System.Drawing.Size(762, 315);
            this.tabTotalTweet.TabIndex = 0;
            this.tabTotalTweet.Text = "Total number of Tweets received";
            this.tabTotalTweet.UseVisualStyleBackColor = true;
            // 
            // tabAverage
            // 
            this.tabAverage.Location = new System.Drawing.Point(4, 25);
            this.tabAverage.Name = "tabAverage";
            this.tabAverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabAverage.Size = new System.Drawing.Size(762, 315);
            this.tabAverage.TabIndex = 1;
            this.tabAverage.Text = "Average tweets per minute";
            this.tabAverage.UseVisualStyleBackColor = true;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Location = new System.Drawing.Point(4, 25);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Size = new System.Drawing.Size(762, 315);
            this.tabWelcome.TabIndex = 2;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // frmTwitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabTwitter);
            this.Name = "frmTwitter";
            this.Text = "Twitter API  Demo";
            this.Load += new System.EventHandler(this.frmTwitter_Load);
            this.tabTwitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTwitter;
        private System.Windows.Forms.TabPage tabTotalTweet;
        private System.Windows.Forms.TabPage tabAverage;
        private System.Windows.Forms.TabPage tabWelcome;
    }
}


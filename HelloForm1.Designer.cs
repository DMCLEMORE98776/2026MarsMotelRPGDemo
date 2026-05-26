namespace _2026MarsMotelRPGDEMO
{
    partial class HelloForm1
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
            this.BTNExplore = new System.Windows.Forms.Button();
            this.LBLStats = new System.Windows.Forms.Label();
            this.CMBLocations = new System.Windows.Forms.ComboBox();
            this.lblStory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNExplore
            // 
            this.BTNExplore.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BTNExplore.Location = new System.Drawing.Point(632, 371);
            this.BTNExplore.Name = "BTNExplore";
            this.BTNExplore.Size = new System.Drawing.Size(146, 58);
            this.BTNExplore.TabIndex = 0;
            this.BTNExplore.Text = "Explore";
            this.BTNExplore.UseVisualStyleBackColor = true;
            this.BTNExplore.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLStats
            // 
            this.LBLStats.AutoSize = true;
            this.LBLStats.Location = new System.Drawing.Point(640, 281);
            this.LBLStats.Name = "LBLStats";
            this.LBLStats.Size = new System.Drawing.Size(31, 13);
            this.LBLStats.TabIndex = 1;
            this.LBLStats.Text = "Stats";
            this.LBLStats.Click += new System.EventHandler(this.TitleFlyer_Click);
            // 
            // CMBLocations
            // 
            this.CMBLocations.FormattingEnabled = true;
            this.CMBLocations.Location = new System.Drawing.Point(643, 332);
            this.CMBLocations.Name = "CMBLocations";
            this.CMBLocations.Size = new System.Drawing.Size(121, 21);
            this.CMBLocations.TabIndex = 2;
            this.CMBLocations.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.Location = new System.Drawing.Point(27, 31);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(31, 13);
            this.lblStory.TabIndex = 3;
            this.lblStory.Text = "Story";
            // 
            // HelloForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2026MarsMotelRPGDEMO.Properties.Resources.MarsSpaceStationBG_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStory);
            this.Controls.Add(this.CMBLocations);
            this.Controls.Add(this.LBLStats);
            this.Controls.Add(this.BTNExplore);
            this.Name = "HelloForm1";
            this.Text = "2026MarsMotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNExplore;
        private System.Windows.Forms.Label LBLStats;
        private System.Windows.Forms.ComboBox CMBLocations;
        private System.Windows.Forms.Label lblStory;
    }
}


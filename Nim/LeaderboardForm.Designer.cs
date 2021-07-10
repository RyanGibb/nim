namespace Nim {
    partial class LeaderboardForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ListView = new System.Windows.Forms.ListView();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.LeaderboardGameModeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListView.GridLines = true;
            this.ListView.Location = new System.Drawing.Point(50, 108);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(900, 328);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // ExitToMainMenuButton
            // 
            this.ExitToMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitToMainMenuButton.Location = new System.Drawing.Point(50, 74);
            this.ExitToMainMenuButton.Name = "ExitToMainMenuButton";
            this.ExitToMainMenuButton.Size = new System.Drawing.Size(159, 28);
            this.ExitToMainMenuButton.TabIndex = 7;
            this.ExitToMainMenuButton.Text = "Exit To Main Menu";
            this.ExitToMainMenuButton.UseVisualStyleBackColor = true;
            this.ExitToMainMenuButton.Click += new System.EventHandler(this.ExitToMainMenuButton_Click);
            // 
            // LeaderboardGameModeLabel
            // 
            this.LeaderboardGameModeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeaderboardGameModeLabel.AutoSize = true;
            this.LeaderboardGameModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.LeaderboardGameModeLabel.Location = new System.Drawing.Point(399, 78);
            this.LeaderboardGameModeLabel.Name = "LeaderboardGameModeLabel";
            this.LeaderboardGameModeLabel.Size = new System.Drawing.Size(213, 20);
            this.LeaderboardGameModeLabel.TabIndex = 8;
            this.LeaderboardGameModeLabel.Text = "Player vs Player Leaderboard";
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.LeaderboardGameModeLabel);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.ListView);
            this.Name = "LeaderboardForm";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.LeaderboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button ExitToMainMenuButton;
        private System.Windows.Forms.Label LeaderboardGameModeLabel;
    }
}
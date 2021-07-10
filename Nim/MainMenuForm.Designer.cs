namespace Nim
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerVSPlayerButton = new System.Windows.Forms.Button();
            this.PlayerVSAIButton = new System.Windows.Forms.Button();
            this.PlayerVSPlayerLeaderboardButton = new System.Windows.Forms.Button();
            this.PlayerVSAILeaderboard = new System.Windows.Forms.Button();
            this.ExitProgramButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(422, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerVSPlayerButton
            // 
            this.PlayerVSPlayerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerVSPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerVSPlayerButton.Location = new System.Drawing.Point(272, 74);
            this.PlayerVSPlayerButton.Name = "PlayerVSPlayerButton";
            this.PlayerVSPlayerButton.Size = new System.Drawing.Size(144, 89);
            this.PlayerVSPlayerButton.TabIndex = 1;
            this.PlayerVSPlayerButton.Text = "Player VS Player";
            this.PlayerVSPlayerButton.UseVisualStyleBackColor = true;
            this.PlayerVSPlayerButton.Click += new System.EventHandler(this.PlayerVSPlayerButton_Click);
            // 
            // PlayerVSAIButton
            // 
            this.PlayerVSAIButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerVSAIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerVSAIButton.Location = new System.Drawing.Point(572, 74);
            this.PlayerVSAIButton.Name = "PlayerVSAIButton";
            this.PlayerVSAIButton.Size = new System.Drawing.Size(144, 89);
            this.PlayerVSAIButton.TabIndex = 2;
            this.PlayerVSAIButton.Text = "Player VS AI";
            this.PlayerVSAIButton.UseVisualStyleBackColor = true;
            this.PlayerVSAIButton.Click += new System.EventHandler(this.PlayerVSAIButton_Click);
            // 
            // PlayerVSPlayerLeaderboardButton
            // 
            this.PlayerVSPlayerLeaderboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerVSPlayerLeaderboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerVSPlayerLeaderboardButton.Location = new System.Drawing.Point(272, 374);
            this.PlayerVSPlayerLeaderboardButton.Name = "PlayerVSPlayerLeaderboardButton";
            this.PlayerVSPlayerLeaderboardButton.Size = new System.Drawing.Size(144, 89);
            this.PlayerVSPlayerLeaderboardButton.TabIndex = 3;
            this.PlayerVSPlayerLeaderboardButton.Text = "Player VS Player Leaderboard";
            this.PlayerVSPlayerLeaderboardButton.UseVisualStyleBackColor = true;
            this.PlayerVSPlayerLeaderboardButton.Click += new System.EventHandler(this.PlayerVSPlayerLeaderboardButton_Click);
            // 
            // PlayerVSAILeaderboard
            // 
            this.PlayerVSAILeaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerVSAILeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerVSAILeaderboard.Location = new System.Drawing.Point(572, 374);
            this.PlayerVSAILeaderboard.Name = "PlayerVSAILeaderboard";
            this.PlayerVSAILeaderboard.Size = new System.Drawing.Size(144, 89);
            this.PlayerVSAILeaderboard.TabIndex = 4;
            this.PlayerVSAILeaderboard.Text = "Player VS AI Leaderboard";
            this.PlayerVSAILeaderboard.UseVisualStyleBackColor = true;
            this.PlayerVSAILeaderboard.Click += new System.EventHandler(this.PlayerVSAILeaderboard_Click);
            // 
            // ExitProgramButton
            // 
            this.ExitProgramButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitProgramButton.Location = new System.Drawing.Point(156, 74);
            this.ExitProgramButton.Name = "ExitProgramButton";
            this.ExitProgramButton.Size = new System.Drawing.Size(110, 28);
            this.ExitProgramButton.TabIndex = 5;
            this.ExitProgramButton.Text = "Exit Program";
            this.ExitProgramButton.UseVisualStyleBackColor = true;
            this.ExitProgramButton.Click += new System.EventHandler(this.ExitProgramButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.ExitProgramButton);
            this.Controls.Add(this.PlayerVSAILeaderboard);
            this.Controls.Add(this.PlayerVSPlayerLeaderboardButton);
            this.Controls.Add(this.PlayerVSAIButton);
            this.Controls.Add(this.PlayerVSPlayerButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayerVSPlayerButton;
        private System.Windows.Forms.Button PlayerVSAIButton;
        private System.Windows.Forms.Button PlayerVSPlayerLeaderboardButton;
        private System.Windows.Forms.Button PlayerVSAILeaderboard;
        private System.Windows.Forms.Button ExitProgramButton;

    }
}


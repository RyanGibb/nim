namespace Nim {
    partial class GameForm {
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
            this.components = new System.ComponentModel.Container();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.PlayerTurnLabel = new System.Windows.Forms.Label();
            this.EnterNameTextbox = new System.Windows.Forms.TextBox();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.EnterNameButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Stack1 = new System.Windows.Forms.Label();
            this.Stack2 = new System.Windows.Forms.Label();
            this.Stack3 = new System.Windows.Forms.Label();
            this.Stack4 = new System.Windows.Forms.Label();
            this.Stack5 = new System.Windows.Forms.Label();
            this.WarningMessageLabel = new System.Windows.Forms.Label();
            this.EasyDifficultyButton = new System.Windows.Forms.Button();
            this.MediumDifficultyButton = new System.Windows.Forms.Button();
            this.HardDifficultyButton = new System.Windows.Forms.Button();
            this.MasterDifficultyButton = new System.Windows.Forms.Button();
            this.SelectAIDifficultyLabel = new System.Windows.Forms.Label();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.Disk1 = new System.Windows.Forms.PictureBox();
            this.Disk2 = new System.Windows.Forms.PictureBox();
            this.Disk3 = new System.Windows.Forms.PictureBox();
            this.Disk4 = new System.Windows.Forms.PictureBox();
            this.Disk5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Disk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk5)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitToMainMenuButton
            // 
            this.ExitToMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitToMainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitToMainMenuButton.Location = new System.Drawing.Point(107, 74);
            this.ExitToMainMenuButton.Name = "ExitToMainMenuButton";
            this.ExitToMainMenuButton.Size = new System.Drawing.Size(159, 28);
            this.ExitToMainMenuButton.TabIndex = 6;
            this.ExitToMainMenuButton.Text = "Exit To Main Menu";
            this.ExitToMainMenuButton.UseVisualStyleBackColor = true;
            this.ExitToMainMenuButton.Click += new System.EventHandler(this.ExitToMainMenuButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RestartButton.Location = new System.Drawing.Point(107, 108);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(159, 28);
            this.RestartButton.TabIndex = 7;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // PlayerTurnLabel
            // 
            this.PlayerTurnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerTurnLabel.AutoSize = true;
            this.PlayerTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerTurnLabel.Location = new System.Drawing.Point(272, 78);
            this.PlayerTurnLabel.Name = "PlayerTurnLabel";
            this.PlayerTurnLabel.Size = new System.Drawing.Size(114, 20);
            this.PlayerTurnLabel.TabIndex = 8;
            this.PlayerTurnLabel.Text = "Player ---\'s turn";
            // 
            // EnterNameTextbox
            // 
            this.EnterNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnterNameTextbox.Location = new System.Drawing.Point(363, 182);
            this.EnterNameTextbox.Name = "EnterNameTextbox";
            this.EnterNameTextbox.Size = new System.Drawing.Size(366, 26);
            this.EnterNameTextbox.TabIndex = 9;
            this.EnterNameTextbox.Click += new System.EventHandler(this.EnterNameTextbox_Clicked);
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnterNameLabel.Location = new System.Drawing.Point(172, 184);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(185, 20);
            this.EnterNameLabel.TabIndex = 13;
            this.EnterNameLabel.Text = "Enter Player one\'s name:";
            // 
            // EnterNameButton
            // 
            this.EnterNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnterNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnterNameButton.Location = new System.Drawing.Point(735, 181);
            this.EnterNameButton.Name = "EnterNameButton";
            this.EnterNameButton.Size = new System.Drawing.Size(75, 28);
            this.EnterNameButton.TabIndex = 15;
            this.EnterNameButton.Text = "Enter";
            this.EnterNameButton.UseVisualStyleBackColor = true;
            this.EnterNameButton.Click += new System.EventHandler(this.EnterNameButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Stack1
            // 
            this.Stack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stack1.AutoSize = true;
            this.Stack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Stack1.Location = new System.Drawing.Point(350, 300);
            this.Stack1.Name = "Stack1";
            this.Stack1.Size = new System.Drawing.Size(104, 31);
            this.Stack1.TabIndex = 17;
            this.Stack1.Text = "Stack1";
            this.Stack1.Click += new System.EventHandler(this.Stack1_Click);
            // 
            // Stack2
            // 
            this.Stack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stack2.AutoSize = true;
            this.Stack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Stack2.Location = new System.Drawing.Point(450, 300);
            this.Stack2.Name = "Stack2";
            this.Stack2.Size = new System.Drawing.Size(104, 31);
            this.Stack2.TabIndex = 18;
            this.Stack2.Text = "Stack2";
            this.Stack2.Click += new System.EventHandler(this.Stack2_Click);
            // 
            // Stack3
            // 
            this.Stack3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stack3.AutoSize = true;
            this.Stack3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Stack3.Location = new System.Drawing.Point(550, 300);
            this.Stack3.Name = "Stack3";
            this.Stack3.Size = new System.Drawing.Size(104, 31);
            this.Stack3.TabIndex = 19;
            this.Stack3.Text = "Stack3";
            this.Stack3.Click += new System.EventHandler(this.Stack3_Click);
            // 
            // Stack4
            // 
            this.Stack4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stack4.AutoSize = true;
            this.Stack4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Stack4.Location = new System.Drawing.Point(650, 300);
            this.Stack4.Name = "Stack4";
            this.Stack4.Size = new System.Drawing.Size(104, 31);
            this.Stack4.TabIndex = 20;
            this.Stack4.Text = "Stack4";
            this.Stack4.Click += new System.EventHandler(this.Stack4_Click);
            // 
            // Stack5
            // 
            this.Stack5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stack5.AutoSize = true;
            this.Stack5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Stack5.Location = new System.Drawing.Point(734, 300);
            this.Stack5.Name = "Stack5";
            this.Stack5.Size = new System.Drawing.Size(104, 31);
            this.Stack5.TabIndex = 21;
            this.Stack5.Text = "Stack5";
            this.Stack5.Click += new System.EventHandler(this.Stack5_Click);
            // 
            // WarningMessageLabel
            // 
            this.WarningMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarningMessageLabel.AutoSize = true;
            this.WarningMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WarningMessageLabel.Location = new System.Drawing.Point(103, 139);
            this.WarningMessageLabel.Name = "WarningMessageLabel";
            this.WarningMessageLabel.Size = new System.Drawing.Size(137, 20);
            this.WarningMessageLabel.TabIndex = 27;
            this.WarningMessageLabel.Text = "Warning Message";
            // 
            // EasyDifficultyButton
            // 
            this.EasyDifficultyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EasyDifficultyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EasyDifficultyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EasyDifficultyButton.Location = new System.Drawing.Point(392, 180);
            this.EasyDifficultyButton.Name = "EasyDifficultyButton";
            this.EasyDifficultyButton.Size = new System.Drawing.Size(75, 28);
            this.EasyDifficultyButton.TabIndex = 28;
            this.EasyDifficultyButton.Text = "Easy";
            this.EasyDifficultyButton.UseVisualStyleBackColor = true;
            this.EasyDifficultyButton.Click += new System.EventHandler(this.EasyDifficultyButton_Click);
            // 
            // MediumDifficultyButton
            // 
            this.MediumDifficultyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MediumDifficultyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MediumDifficultyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MediumDifficultyButton.Location = new System.Drawing.Point(473, 180);
            this.MediumDifficultyButton.Name = "MediumDifficultyButton";
            this.MediumDifficultyButton.Size = new System.Drawing.Size(75, 28);
            this.MediumDifficultyButton.TabIndex = 29;
            this.MediumDifficultyButton.Text = "Medium";
            this.MediumDifficultyButton.UseVisualStyleBackColor = true;
            this.MediumDifficultyButton.Click += new System.EventHandler(this.MediumDifficultyButton_Click);
            // 
            // HardDifficultyButton
            // 
            this.HardDifficultyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HardDifficultyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HardDifficultyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HardDifficultyButton.Location = new System.Drawing.Point(554, 180);
            this.HardDifficultyButton.Name = "HardDifficultyButton";
            this.HardDifficultyButton.Size = new System.Drawing.Size(75, 28);
            this.HardDifficultyButton.TabIndex = 30;
            this.HardDifficultyButton.Text = "Hard";
            this.HardDifficultyButton.UseVisualStyleBackColor = true;
            this.HardDifficultyButton.Click += new System.EventHandler(this.HardDifficultyButton_Click);
            // 
            // MasterDifficultyButton
            // 
            this.MasterDifficultyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasterDifficultyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterDifficultyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MasterDifficultyButton.Location = new System.Drawing.Point(635, 180);
            this.MasterDifficultyButton.Name = "MasterDifficultyButton";
            this.MasterDifficultyButton.Size = new System.Drawing.Size(75, 28);
            this.MasterDifficultyButton.TabIndex = 31;
            this.MasterDifficultyButton.Text = "Master";
            this.MasterDifficultyButton.UseVisualStyleBackColor = true;
            this.MasterDifficultyButton.Click += new System.EventHandler(this.MasterDifficultyButton_Click);
            // 
            // SelectAIDifficultyLabel
            // 
            this.SelectAIDifficultyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectAIDifficultyLabel.AutoSize = true;
            this.SelectAIDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SelectAIDifficultyLabel.Location = new System.Drawing.Point(251, 185);
            this.SelectAIDifficultyLabel.Name = "SelectAIDifficultyLabel";
            this.SelectAIDifficultyLabel.Size = new System.Drawing.Size(135, 20);
            this.SelectAIDifficultyLabel.TabIndex = 32;
            this.SelectAIDifficultyLabel.Text = "Select AI difficulty";
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndTurnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EndTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EndTurnButton.Location = new System.Drawing.Point(272, 108);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(110, 28);
            this.EndTurnButton.TabIndex = 26;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // Disk1
            // 
            this.Disk1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Disk1.Image = global::Nim.Properties.Resources.cropped_gold_doubloon;
            this.Disk1.Location = new System.Drawing.Point(310, 250);
            this.Disk1.Name = "Disk1";
            this.Disk1.Size = new System.Drawing.Size(100, 100);
            this.Disk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disk1.TabIndex = 22;
            this.Disk1.TabStop = false;
            this.Disk1.Click += new System.EventHandler(this.Stack1_Click);
            // 
            // Disk2
            // 
            this.Disk2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Disk2.Image = global::Nim.Properties.Resources.cropped_gold_doubloon;
            this.Disk2.Location = new System.Drawing.Point(416, 250);
            this.Disk2.Name = "Disk2";
            this.Disk2.Size = new System.Drawing.Size(100, 100);
            this.Disk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disk2.TabIndex = 22;
            this.Disk2.TabStop = false;
            this.Disk2.Click += new System.EventHandler(this.Stack2_Click);
            // 
            // Disk3
            // 
            this.Disk3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Disk3.Image = global::Nim.Properties.Resources.cropped_gold_doubloon;
            this.Disk3.Location = new System.Drawing.Point(522, 250);
            this.Disk3.Name = "Disk3";
            this.Disk3.Size = new System.Drawing.Size(100, 100);
            this.Disk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disk3.TabIndex = 23;
            this.Disk3.TabStop = false;
            this.Disk3.Click += new System.EventHandler(this.Stack3_Click);
            // 
            // Disk4
            // 
            this.Disk4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Disk4.Image = global::Nim.Properties.Resources.cropped_gold_doubloon;
            this.Disk4.Location = new System.Drawing.Point(618, 250);
            this.Disk4.Name = "Disk4";
            this.Disk4.Size = new System.Drawing.Size(100, 100);
            this.Disk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disk4.TabIndex = 24;
            this.Disk4.TabStop = false;
            this.Disk4.Click += new System.EventHandler(this.Stack4_Click);
            // 
            // Disk5
            // 
            this.Disk5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Disk5.Image = global::Nim.Properties.Resources.cropped_gold_doubloon;
            this.Disk5.Location = new System.Drawing.Point(715, 250);
            this.Disk5.Name = "Disk5";
            this.Disk5.Size = new System.Drawing.Size(100, 100);
            this.Disk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disk5.TabIndex = 25;
            this.Disk5.TabStop = false;
            this.Disk5.Click += new System.EventHandler(this.Stack5_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.SelectAIDifficultyLabel);
            this.Controls.Add(this.MasterDifficultyButton);
            this.Controls.Add(this.HardDifficultyButton);
            this.Controls.Add(this.MediumDifficultyButton);
            this.Controls.Add(this.EasyDifficultyButton);
            this.Controls.Add(this.WarningMessageLabel);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.Stack5);
            this.Controls.Add(this.Stack4);
            this.Controls.Add(this.Stack3);
            this.Controls.Add(this.Stack2);
            this.Controls.Add(this.Stack1);
            this.Controls.Add(this.EnterNameButton);
            this.Controls.Add(this.EnterNameLabel);
            this.Controls.Add(this.EnterNameTextbox);
            this.Controls.Add(this.PlayerTurnLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.Disk1);
            this.Controls.Add(this.Disk2);
            this.Controls.Add(this.Disk3);
            this.Controls.Add(this.Disk4);
            this.Controls.Add(this.Disk5);
            this.Name = "GameForm";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.Disk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitToMainMenuButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label PlayerTurnLabel;
        private System.Windows.Forms.TextBox EnterNameTextbox;
        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.Button EnterNameButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Stack1;
        private System.Windows.Forms.Label Stack2;
        private System.Windows.Forms.Label Stack3;
        private System.Windows.Forms.Label Stack4;
        private System.Windows.Forms.Label Stack5;
        private System.Windows.Forms.PictureBox Disk1;
        private System.Windows.Forms.PictureBox Disk2;
        private System.Windows.Forms.PictureBox Disk3;
        private System.Windows.Forms.PictureBox Disk4;
        private System.Windows.Forms.PictureBox Disk5;
        private System.Windows.Forms.Button EndTurnButton;
        private System.Windows.Forms.Label WarningMessageLabel;
        private System.Windows.Forms.Button EasyDifficultyButton;
        private System.Windows.Forms.Button MediumDifficultyButton;
        private System.Windows.Forms.Button HardDifficultyButton;
        private System.Windows.Forms.Button MasterDifficultyButton;
        private System.Windows.Forms.Label SelectAIDifficultyLabel;
    }
}
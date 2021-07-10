using System;
using System.Windows.Forms;

namespace Nim {
    public partial class MainMenuForm : Form { //class that defines how the main menu works
        public MainMenuForm() { //constructor, run when a MainMenuForm object is created. Initializes the form.
            InitializeComponent(); //runs the code created by the IDE for the UI
            this.FormBorderStyle = FormBorderStyle.None; //removes the form border
            this.WindowState = FormWindowState.Maximized; //sets the form to fullscreen
        }

        private void PlayerVSPlayerButton_Click(object sender, EventArgs e) { //creates a player vs player game when the PlayerVSPlayerButton is clicked
            GameForm game = new GameForm(true); //creates the game form in player vs player mode
            game.Show(); //shows the game form
            this.Hide(); //hides the main menu form
        }

        private void PlayerVSAIButton_Click(object sender, EventArgs e) { //creates a player vs AI game when the PlayerVSAIButton is clicked
            GameForm game = new GameForm(false); //creates the game form in player vs AI mode
            game.Show(); //shows the game form
            this.Hide(); //hides the main menu form
        }

        private void PlayerVSPlayerLeaderboardButton_Click(object sender, EventArgs e) { //shows the player vs player leaderboard when the PlayerVSPlayerLeaderboardButton button is clicked
            LeaderboardForm leaderboard = new LeaderboardForm(true); //creates the leaderboard form in player vs player mode
            leaderboard.Show(); //shows the leaderboard form
            this.Hide(); //hides the main menu form
        }

        private void PlayerVSAILeaderboard_Click(object sender, EventArgs e) { //shows the player vs AI leaderboard when the PlayerVSAILeaderboardButton button is clicked
            LeaderboardForm leaderboard = new LeaderboardForm(false); //creates the leaderboard form in player vs AI mode
            leaderboard.Show(); //shows the leaderboard form
            this.Hide(); //hides the main menu form
        }

        private void ExitProgramButton_Click(object sender, EventArgs e) { //exits the main menu, and program, when the ExitProgramButton button is clicked
            this.Close(); //closes the main menu form
        }
    }
}

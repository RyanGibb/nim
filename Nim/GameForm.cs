using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nim {
    public partial class GameForm : Form { //class that defines how the game (Nim) works
        private Random random = new Random(); //used for creating random numbers
        private string player_1_name; //stores the name of player 1
        private string player_2_name; //stores the name of player 2
        private bool current_player; //Stores which player's turn it is at any point. If it's true it's player1's turn, if false it's player2's turn.
        private int number_of_stacks; //stores how many stacks have been created for a specific game
        private int? current_stack; //Keeps track of what stack has had coins removed from it in a specific turn. It hast the datatype nullable integer so it can have a null value when no stack has coins removed from it yet in a turn.
        private bool game_mode; //Stores this game's game mode. If it's true it's player vs player, if false player vs AI.
        private bool game_over = false; //Stores whether the game is finished or not
        private bool game_start = false; //Stores whether the game has started or not (if player name(s) (and difficulty if in AI mode) have been selected the game starts). Used to prevent disks being taken before the game starts.
        private Double AIdifficulty; //Stores the AIdifficulty, only used in player vs AI mode
        private List<Label> Stacks; //Stores an list (array) of label's. Used to store references to all the Stacks - which are label's - for easy access and iteration through.
        private List<PictureBox> Disks; //Stores an list (array) of picture boxes. Used to store references to all the Stacks - which are picture boxes - for easy access and iteration through.

        public GameForm(bool game_mode_input) { //constructor that intilizes the game
            InitializeComponent(); //runs the code created by the IDE for the UI
            this.FormBorderStyle = FormBorderStyle.None; //removes the form border
            this.WindowState = FormWindowState.Maximized; //sets the form to fullscreen
            game_mode = game_mode_input; //sets the GameForm object's game mode to the value input into the constructor
            if (game_mode) {
                EnterNameLabel.Text = "Enter Player one's name:"; //if the game mode is player vs player set the enter name label to ask for player one's name
            } else {
                EnterNameLabel.Text = "Enter Player's name:"; //if the game mode is player vs AI set the enter name label to ask for the player's name
            }
            PlayerTurnLabel.Hide();
            WarningMessageLabel.Hide();
            EndTurnButton.Hide();
            EasyDifficultyButton.Hide();
            MediumDifficultyButton.Hide();
            HardDifficultyButton.Hide();
            MasterDifficultyButton.Hide();
            SelectAIDifficultyLabel.Hide();
            //hides all the UI elements not to be initially shown
            Stacks = new List<Label>(new Label[] { Stack1, Stack2, Stack3, Stack4, Stack5 }); //sets the Stacks array to the references of the stack labels
            Disks = new List<PictureBox>(new PictureBox[] { Disk1, Disk2, Disk3, Disk4, Disk5 }); //sets the Disks array to the references of the disk pictureboxes
            CalculateStackLocations(); //calls the method to calculate the locations for the stacks
        }

        private void ExitToMainMenuButton_Click(object sender, EventArgs e) { //exits the game form to the main menu form when the ExitToMainMenuButton button is clicked
            Program.MainMenu.Show(); //shows the main menu form
            this.Close(); //closes this game form
        }
        private void RestartButton_Click(object sender, EventArgs e) { //creates a new game form and closes the current one when the RestartButton is clicked
            GameForm Game = new GameForm(game_mode); //creates a new game form of the same game mode as the current one
            Game.Show(); //shows the new game form
            this.Close(); //closes this game form
        }
        private void EndTurnButton_Click(object sender, EventArgs e) { //calls the TurnTaken() method when the EndTurnButton button is clicked
            TurnTaken(); //calls the method to process a turn being taken
        }

        private void EnterNameButton_Click(object sender, EventArgs e) { //processes the data in the EnterNameTextbox whenever the EnterNamenButton button is clicked
            if (EnterNameTextbox.Text == "" || EnterNameTextbox.Text == "Please enter a name" || EnterNameTextbox.Text == "Please enter a name different from player 1's name" || EnterNameTextbox.Text == "Please enter a name without commas" || EnterNameTextbox.Text == "Please enter a name with less than 70 characters") { //If the text box is blank or contains an error message (the error messages are included in this if statement so they can't be input as a name accidentally),
                EnterNameTextbox.Text = "Please enter a name"; //don't accept it as an input and change the text in the EnterNameTextbox to an error message.
            } else if (EnterNameTextbox.Text.Length > 70) { //If the input name is larger that 70 characters,
                EnterNameTextbox.Text = "Please enter a name with less than 70 characters"; //display an error message in the EnterNameTextbox.
            } else if (EnterNameTextbox.Text.Contains(",")) { //If there is a comma in the input name,
                EnterNameTextbox.Text = "Please enter a name without commas"; //display an error message in the EnterNameTextbox.
            } else if (game_mode) { //if the game mode is player vs player, and there are no input validation errors (so far),
                if (EnterNameLabel.Text == "Enter Player one's name:") { //If the EnterNameLabel is asking for Player one's name,
                    player_1_name = EnterNameTextbox.Text; //set player one's name to the text input through the EnterNameTextbox,
                    EnterNameTextbox.Text = ""; //clear the EnterNameTextbox,
                    EnterNameLabel.Text = "Enter Player two's name:"; //and set the EnterNameLabel to ask for player two's name
                } else if (EnterNameLabel.Text == "Enter Player two's name:") { //If the EnterNameLabel is asking for player two's name
                    if (EnterNameTextbox.Text == player_1_name) { //If the input name is the same as player one's,
                        EnterNameTextbox.Text = "Please enter a name different from player 1's name"; //display an error message in the EnterNameTextbox
                    } else { //otherwise (if player two's name is different from player one's),
                        player_2_name = EnterNameTextbox.Text; //set player two's name to the text input through the EnterNameTextbox,
                        InitiateGamePlayerVSPlayer(); //calls the method to initiate the game in player vs player mode
                    }
                }
            } else { //If the game mode is player vs AI, and there are no input validation errors,
                player_1_name = EnterNameTextbox.Text; //set player one's name to the text input through the EnterNameTextbox,
                player_2_name = "The AI"; //set player two's name to "The AI"
                EnterNameLabel.Hide();
                EnterNameTextbox.Hide();
                EnterNameButton.Hide();
                //hides all the input name related UI elements
                EasyDifficultyButton.Show();
                MediumDifficultyButton.Show();
                HardDifficultyButton.Show();
                MasterDifficultyButton.Show();
                SelectAIDifficultyLabel.Show();
                //shows all the AI difficulty selection UI elements
            }
        }
        private void EnterNameTextbox_Clicked(object sender, EventArgs e) { //clears the EnterNameTextbox when it is clicked (so no error messages have to be deleted by the user, or accidentally input)
            EnterNameTextbox.Text = ""; //sets the EnterNameTextbox's text to blank
        }

        private void Stack1_Click(object sender, EventArgs e) { //when stack one is clicked call the stack click method with the parameter stack_number as 1
            Stack_Click(1); //call the stack click method with the parameter stack_number as 1
        }
        private void Stack2_Click(object sender, EventArgs e) { //when stack two is clicked call the stack click method with the parameter stack_number as 2
            Stack_Click(2); //call the stack click method with the parameter stack_number as 2
        }
        private void Stack3_Click(object sender, EventArgs e) { //when stack three is clicked call the stack click method with the parameter stack_number as 3
            Stack_Click(3); //call the stack click method with the parameter stack_number as 3
        }
        private void Stack4_Click(object sender, EventArgs e) { //when stack four is clicked call the stack click method with the parameter stack_number as 4
            Stack_Click(4); //call the stack click method with the parameter stack_number as 4
        }
        private void Stack5_Click(object sender, EventArgs e) { //when stack five is clicked call the stack click method with the parameter stack_number as 5
            Stack_Click(5); //call the stack click method with the parameter stack_number as 5
        }
        private void Stack_Click(int stack_number) { //processes a stack being clicked
            if (game_start) { //If the game has started,
                int stack_index = stack_number - 1; //set the stack index to the stack number minus 1, as the stack number starts from 1 but the stack index starts from 0
                if (current_stack == null) { //if the current stack is null (no stack has had any disks removed from it yet),
                    current_stack = stack_number; //sets the current stack to the stack number.
                }
                if (current_stack == stack_number) { //If the current stack is the stack number (either disks have been removed from this stacks before or this is the first stack clicked),
                    if (int.Parse(Stacks[stack_index].Text) <= 1) { //if the number of disks in the stack (the stack's text) is less than or equal to 1, (Note: the stack is accessed with the Stacks array of the references to the stack labels, and the stack index)
                        Stacks[stack_index].Text = "0"; //set the stack's number of disks to 0 (set the stack's text to 0)
                        Stacks[stack_index].Hide(); //hide the stack
                        Disks[stack_index].Hide(); //hide the disk (the disk is accessed in the same way as the stack)
                    } else { //if the number of disks in the stack is greater than 1,
                        Stacks[stack_index].Text = (int.Parse(Stacks[stack_index].Text) - 1).ToString(); //removed one from the stack's number of disks (convert the stack's text to an integer, remove one, and convert back to string)
                    }
                } else { //If the current stack isn't the stack number (disks have been removed from another stack
                    WarningMessageLabel.Text = "You may only remove coins from one stack per turn";
                    WarningMessageLabel.Show();
                    //display a warning message
                }
            }
        }

        private void TurnTaken() {
            WarningMessageLabel.Hide(); //hides any warning messages that have been shown
            if (!game_over) { //If the game isn't over,
                if (Stack1.Text == "0" && Stack2.Text == "0" && Stack3.Text == "0" && Stack4.Text == "0" && Stack5.Text == "0") { //if all the stacks have 0 disks (the current player has won),
                    if (game_mode) { //if the game mode is player vs player
                        if (current_player) { //if the current player is player one (player one has won), 
                            PlayerTurnLabel.Text = "Player 1 " + player_1_name + " wins!"; //show that player one has won on the PlayerTurnLabel
                            LeaderboardForm.UpdateData(player_1_name, true, true); //call the leaderboard form method that updates the leaderboard, saying player one has won in the game mode player vs player
                            LeaderboardForm.UpdateData(player_2_name, false, true); //call the leaderboard form method that updates the leaderboard, saying player two has lost in the game mode player vs player
                        } else { //if the current player is player two (player two has won), 
                            PlayerTurnLabel.Text = "Player 2 " + player_2_name + " wins!"; //show that player two has won on the PlayerTurnLabel
                            LeaderboardForm.UpdateData(player_1_name, false, true); //call the leaderboard form method that updates the leaderboard, saying player one has lost in the game mode player vs player
                            LeaderboardForm.UpdateData(player_2_name, true, true); //call the leaderboard form method that updates the leaderboard, saying player two has won in the game mode player vs player
                        }
                    } else { //if the game mode is player vs AI,
                        if (current_player) { //if the current player is player one (the human player has won),  
                            PlayerTurnLabel.Text = "Player " + player_1_name + " wins!";  //show that the human player has won on the PlayerTurnLabel
                            LeaderboardForm.UpdateData(player_1_name, true, false); //call the leaderboard form method that updates the leaderboard, saying player one (the human player) has won in the game mode player vs AI
                        } else { //if the current player is player two (player two has won), 
                            PlayerTurnLabel.Text = player_2_name + " wins!"; //show that the AI has won on the PlayerTurnLabel
                            LeaderboardForm.UpdateData(player_1_name, false, false); //call the leaderboard form method that updates the leaderboard, saying player one (the human player) has lost in the game mode player vs AI
                        }
                    }
                } else { //If all the stacks aren't 0 (the current player hasn't won),
                    if (current_stack != null) { //if the current stack isn't null (a stack has had coins removed from it),
                        current_player = !current_player; //set the current player to the the other player (true goes to false, false goes to true)
                        if (game_mode) { //if the game mode is player vs player,
                            if (current_player) { //if the current player is player one,
                                PlayerTurnLabel.Text = "Player 1 " + player_1_name + "'s turn"; //show player one's turn on the player turn label
                            } else { //if the current player is player two,
                                PlayerTurnLabel.Text = "Player 2 " + player_2_name + "'s turn"; //show player two's turn on the player turn label
                            }
                        } else { //if the game mode is player vs AI,
                            if (!current_player) { //if the current player isn't the human player (is the AI),
                                AITurn(); //call the method to calculate the AI's turn.
                                //the reason why no labels are changed is because the label will always read the human players turn in player vs AI mode, as the AI takes it's turn instantly
                            }
                        }
                    } else { //If the current stack is null (no disks have been taken from ant stack),
                        WarningMessageLabel.Text = "You must take at least one coin per turn";
                        WarningMessageLabel.Show();
                        //display a warning message
                    }
                }
                current_stack = null; //sets the current stack to null, as no stack has had disks taken from it yet for the next turn
            }
        }

        private void InitiateGame() {
            PlayerTurnLabel.Show(); //shows the PlayerTurnLabel
            EndTurnButton.Show(); //shows the EndTurnButton
            current_player = (random.NextDouble() >= 0.5); //sets the current player to true or false randomly (if a random number from 0 to 1 is bigger or equal to 0.5 or not)
            current_stack = 0; //sets the current stack to 0 to simulate a turn being taken so the TurnTaken() method can be called to start the game
            game_start = true; //sets the game start variable to true
            TurnTaken(); //calls the turn taken method, to start the game
        }
        private void InitiateGamePlayerVSPlayer() {
            EnterNameLabel.Hide();
            EnterNameTextbox.Hide();
            EnterNameButton.Hide();
            //hides all the input name related UI elements
            PlayerTurnLabel.Text = ""; //sets the PlayerTurnLabel to blank, as the current player is not know yet
            InitiateGame(); //calls the method to initiate the game, exectuing the operations common to both game modes
        }
        private void InitiateGamePlayerVSAI() {
            EasyDifficultyButton.Hide();
            MediumDifficultyButton.Hide();
            HardDifficultyButton.Hide();
            MasterDifficultyButton.Hide();
            SelectAIDifficultyLabel.Hide();
            //hides all the AI difficulty selection UI elements
            PlayerTurnLabel.Text = "Player " + player_1_name + "'s turn"; //sets the PlayerTurnLabel to the human player's turn, as it will always display this as the AI takes it's turn instantly
            InitiateGame(); //calls the method to initiate the game, exectuing the operations common to both game modes
        }

        private void CalculateStackLocations() {
            number_of_stacks = random.Next(3, 6); //sets the number of stacks for this game to a random number from 3 to 5
            int disk_width = 100; //set the width of disks (coins) to 100
            int disk_height = 100; //set the hieght of disks (coins) to 100
            int combined_width = number_of_stacks * disk_width; //sets the combined width of all the disks/stacks to the number of stacks times the width of one disk
            int x_middle = Width / 2; //sets the x coordinate of the middle of the screen to the width of the form divided by two
            int x_left = x_middle - combined_width / 2; //sets the x coordinate of the leftmost point of the combined disks/stacks to the x coordinate of the middle of the screen minus half the combined width of the stacks/disks
            int y_middle = Height / 2; //sets the y coordinate of the middle of the screen to the hieght of the form divided by two
            for (int i = 0; i < 5; i++) { //five iterations (for i from 0 to 4),
                Stacks[i].Text = "0"; //sets every stack's text to 0
                Stacks[i].Hide(); //hides every stack
                Disks[i].Hide(); //hides every disk
            }
            for (int i = 0; i < number_of_stacks; i++) { //five iterations (for i from 0 to 4),
                Disks[i].Location = new System.Drawing.Point(x_left + disk_width * i, y_middle - disk_height / 2); //sets every disks x coordinate to the left most x coordinate of all the stacks/disks combined, plus the disk width times i the counter (giving the leftmost values of each disk, seperated by 100). Sets every disks y coordinate to the y coordinate of the middle of the screen, minus half the disks height (as this gives the coordinate for the topmost part of the disk).
                Disks[i].Show(); //shows every disk
                Stacks[i].Parent = Disks[i]; //sets every stacks parent to the corresponding disk, so the background shown for the stack is the disk behind it, not the previous parent's colour (the form)
                Stacks[i].BackColor = Color.Transparent; //sets every stacks background to transparent
                Stacks[i].Location = new System.Drawing.Point(39, 33); //sets the location of every stack to the centre of each disk (location relative to disk, as the disk is the parent)
                Stacks[i].Text = random.Next(1, 10).ToString(); //sets every stack's number of disks to a random number from 1 to 9
                Stacks[i].Show(); //shows every stack
            }
        }

        private void AITurn() { //method for calculating the AI's turn
            //see the requirements specification for a more detailed explination of the process
            int nim_sum = 0x0; //set the nim sum equal to a binary literal of decimal value 0
            int[] Stacks_binary_values = new int[number_of_stacks]; //creates an array of intergers called Stacks_binary_values to store the binary values of the stacks decimanl number of disks
            for (int i = 0; i < number_of_stacks; i++) { //a number of iterations equal to the number of stacks (for i from 0 to number of stacks), 
                Stacks_binary_values[i] = Convert.ToByte(Stacks[i].Text); //converts each stack's text to a byte, and stores them in the Stacks_binary_values array
                nim_sum = nim_sum ^ Stacks_binary_values[i]; //sets the nim sum to the nim sum XOR the current stack's binary value (looped for each stack), so the end result is the nim sum equal to the XOR operation between all the stacks binary values
            }
            if (nim_sum == 0x0 || random.NextDouble() > AIdifficulty) { //If the nim sum is zero (the human player is winning), or a random number between 0 and 1 is bigger than the AIdifficulty (the chance for a random move to be played instead of the optimal move, depending on the AIdifficulty),
                int stack_index = random.Next(number_of_stacks); //selects a random stack index from 0 to the number of stacks
                Stacks[stack_index].Text = random.Next(int.Parse(Stacks[stack_index].Text)-1).ToString(); //removes a random number of disks from this stack (by setting it to a random number from 0 to it's previous value - 1)
                if (Stacks[stack_index].Text == "0") { //if the stack is equal to 0
                    Stacks[stack_index].Hide(); //hide the stack
                    Disks[stack_index].Hide(); //hide the disk
                }
                current_stack = stack_index + 1; //set the current stack (the stack number) equal to the stack index plus one, as the stack indexes start from 0 but the stack numbers start from 1
            } else { //If the nim sum isn't zero and the random chance for a random move (with the probability depending on difficulty) unsuccesfull (the random number was smaller than the AI difficulty),
                for (int i = 0; i < number_of_stacks; i++) { //a number of iterations equal to the number of stacks (for i from 0 to number of stacks), 
                    if ((nim_sum ^ Stacks_binary_values[i]) < Stacks_binary_values[i]) { //If the nim sum XOR the current stacks binary value is smaller than the current stacks binary value,
                        Stacks_binary_values[i] = nim_sum ^ Stacks_binary_values[i]; //set the current stacks binary value to the nim sum XOR the current stacks binary value
                        Stacks[i].Text = Convert.ToString(Stacks_binary_values[i]); //set the current stacks text to the current stacks binary value converted to decimal string
                        if (Stacks[i].Text == "0") { //if the stacks text (value/number of disks) is 0,
                            Stacks[i].Hide(); //hide the stack
                            Disks[i].Hide(); //hide the disk
                        }
                        current_stack = i + 1;
                        break; //stops the AI taking coins from more than 1 stack
                    }
                }
            }
            TurnTaken(); //call the turn taken method, as the AI has taken it's turn
        }

        private void EasyDifficultyButton_Click(object sender, EventArgs e) { //selects the easy difficulty and initiates the game when the EasyDifficultyButton is clicked
            AIdifficulty = 0.7; //sets the AI difficulty to 0.7, or 70% correct moves (as it is compared to a random number from 0 to 1)
            InitiateGamePlayerVSAI(); //calls the method to initiate the game in player vs AI mode
        }
        private void MediumDifficultyButton_Click(object sender, EventArgs e) { //selects the medium difficulty and initiates the game when the MediumDifficultyButton is clicked
            AIdifficulty = 0.85; //sets the AI difficulty to 0.85, or 85% correct moves (as it is compared to a random number from 0 to 1)
            InitiateGamePlayerVSAI(); //calls the method to initiate the game in player vs AI mode
        }
        private void HardDifficultyButton_Click(object sender, EventArgs e) { //selects the hard difficulty and initiates the game when the HardDifficultyButton is clicked
            AIdifficulty = 0.95; //sets the AI difficulty to 0.95, or 95% correct moves (as it is compared to a random number from 0 to 1)
            InitiateGamePlayerVSAI(); //calls the method to initiate the game in player vs AI mode
        }
        private void MasterDifficultyButton_Click(object sender, EventArgs e) { //selects the master difficulty and initiates the game when the MasterDifficultyButton is clicked
            AIdifficulty = 1; //sets the AI difficulty to 1, or 100% correct moves (as it is compared to a random number from 0 to 1)
            InitiateGamePlayerVSAI(); //calls the method to initiate the game in player vs AI mode
        }
    }
}

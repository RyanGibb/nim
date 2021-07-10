using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nim {
    public partial class LeaderboardForm : Form { //class that defines how the leaderboard works
        private bool game_mode; //Stores the game mode. If it's true it's player vs player, if false player vs AI.
        private int? sorted_column = null; //Stores what coloumn the sorting is currently on, if it's null there is no sorting - so it's inital value is null
        private bool sorted_ascending; //stores whether the sorting is ascending or descending

        public LeaderboardForm(bool game_mode_input) { //constructor that initializes the leaderboard
            InitializeComponent(); //runs the code created by the IDE for the UI
            game_mode = game_mode_input; //sets the game mode to the value input into the constructor
            this.FormBorderStyle = FormBorderStyle.None; //removes the form border
            this.WindowState = FormWindowState.Maximized; //sets the form to fullscreen
            this.ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick); //calls ListVew_ColumnClick method when a coloumn is clicked with the event parameters
            if (game_mode) { //If the game mode is player vs player,
                LeaderboardGameModeLabel.Text = "Player vs Player Leaderboard"; //show the heading player vs player leaderboard
            } else { //If the game mode is player vs AI,
                LeaderboardGameModeLabel.Text = "Player vs AI Leaderboard"; //show the heading player vs AI leaderboard
            }
            DisplayData(ReadData(game_mode)); //calls the display data method with the data to display coming from calling the read data method, and passes the leaderboards game mode so the correct file is read from
        }

        private static List<string[]> ReadData(bool game_mode_static) { //static (so it can be accessed without initiating a LeaderboardForm object - when updating the data from the GameForm) method to read and validated the data from the leaderboard csv files, a new variable game_mode_static is used to store the game mode as a static method can't use variables specific to an instance of a class (an object)
            string file_path = AppDomain.CurrentDomain.BaseDirectory; //sets the file path to the directory of the executable
            if (game_mode_static) { //If the game mode is player vs player,
                file_path += "PlayerVSPlayerleaderboard.csv"; //append the file path with the player vs player leaderboard csv file.
            } else { //If the game mode is player vs AI,
                file_path += "PlayerVSAIleaderboard.csv"; //append the file path with the player vs AI leaderboard csv file
            }
            List<string[]> data = new List<string[]>(); //sets up an empty list of array of strings (similar to a 2D array of strings, but lists have differences from arrays - like a variable length)
            FileStream file; //create a variable to store the reference to the file to read from
            if (File.Exists(file_path)) { //If the file specificed in the file path exisits,
                try { //try doing the following operations
                    file = File.OpenRead(file_path); //open the file to be read from
                    StreamReader file_stream_reader = new StreamReader(file); //open a stream reader of the file (to input the data from)
                    while (!file_stream_reader.EndOfStream) { //while not at the end of the stream reader
                        data.Add(file_stream_reader.ReadLine().Split(',')); //split the input file by commas (as it's a comma seperated value file) and add the array of string to the data list of array of string
                        //note the array of string will be refered to as a record, as it is storing data associated with specific fields, therefor the data list of array of string will be refered to as an array of records
                    }
                    file.Close(); //close the file
                    file_stream_reader.Close(); //close the stream reader
                } catch (Exception e) { //If an error occurs while trying these operations,
                    MessageBox.Show("Reading data failed: " + e.ToString()); //display an error message saying reading the data failed with the specific error printed alonside it
                }
                for (int i = 0; i < data.Count(); i++) { //a number of iterations equal to the number of records in the data array (for i from 0 to the lenght of data) (iterates through all the records in the data array), 
                    if (data[i][0] == "") { //If the player's name is empty,
                        MessageBox.Show("There was a player name that was empty so the record has been removed"); //show an error messgage
                        data.RemoveAt(i); //remove this record from the list
                        i -= 1; //decreased the index by one, as a record has been removed from the data array so the next record will be at an index of 1 less than before
                        continue; //contines the for loop onto the next record, as this one has been removed so no other input validation is required
                    }
                    if (data[i][0].Count() > 70) { //If lenght of the player's name for the current record is larger than 70,
                        MessageBox.Show("\"" + data[i][0] + "\"'s name was too long so has been shortened to 70 chacaters"); //show an error message
                        data[i][0] = data[i][0].Substring(0, 70); //shorten the name to 70 characters
                    }
                    int wins; //create a variable for storing the nunber of wins for the current record
                    bool result; //create an boolean varaible for storing whether the currect records win/loss value is converted to an integer succesfully
                    result = int.TryParse(data[i][1], out wins); //Trys to convert the current records win value to an interger, and stores whether it was successful or not in the results variable. It will be successful if the wins value is an integer as a string, it will be unsuccessful otherwise.
                    if (!result) { //If the current records win value isn't an interger,
                        MessageBox.Show("\"" + data[i][0] + "\"'s number of wins was not an integer so has been set to 0"); //show an error message
                        data[i][1] = "0"; //set the current recrods win value to 0
                    } else if (wins < 0) {  //If the current records win value is less than 0,
                        MessageBox.Show("\"" + data[i][0] + "\"'s number of wins was less than 0 so has been set to 0"); //show an error message
                        data[i][1] = "0"; //set the current records win value to 0
                    }
                    int losses; //create a variable for storing the nunber of losses for the current record
                    result = int.TryParse(data[i][2], out losses); //trys to convert the current records loss value to an interger, and stores whether it was successful or not in the results variable (with the result determined by the same factors as the win value)
                    if (!result) { //If the current records loss value isn't an interger,
                        MessageBox.Show("\"" + data[i][0] + "\"'s number of losses was not an integer so has been set to 0"); //show an error message
                        data[i][2] = "0"; //set the current records loss value to 0
                    } else if (losses < 0) {
                        MessageBox.Show("\"" + data[i][0] + "\"'s number of losses was less than 0 so has been set to 0"); //show an error message
                        data[i][2] = "0"; //set the current records loss value to 0
                    }
                }
                return data; //returns the result of the method the list of records (or list of array of string), the variable data
            } else { //If the file doesn't exist,
                try { //try doing the following operations
                    file = File.Create(file_path); //create the file
                    file.Close(); //close the file
                } catch (Exception e) { //If an error occurs while trying these operations,
                    MessageBox.Show("File not found, creating file failed: " + (e.ToString())); //display an error message saying the file wasn't found and creating the file failed with the specific error printed alonside it
                }
                return data; //return the (empty) list of records (or list of array of string) data
            }
        }

        private void DisplayData(List<string[]> data) { //method to display the data read from file
            ListView.View = View.Details; //sets the leaderboard mode to view details
            ListView.Columns.Add("Name", 756); //adds a coloumn name "Name" with width 756
            ListView.Columns.Add("Wins", 70); //adds a coloumn name "Name" with width 70
            ListView.Columns.Add("Losses", 70); //adds a coloumn name "Name" with width 70
            for (int i = 0; i < data.Count(); i++) { //a number of iterations equal to the number of records in the data array (for i from 0 to the lenght of data) (iterates through all the records in the data array),
                ListView.Items.Add(new ListViewItem(data[i])); //adds the current record to the ListViewLeaderboard (adds the current record to the display) 
            }
        }

        public static void UpdateData(string player_name, bool win, bool game_mode_static) { //static (so it can be accessed without initiating a LeaderboardForm object - when updating the data from the GameForm) method to update the data in the leaderboard csv files, a new variable game_mode_static is used to store the game mode as a static method can't use variables specific to an instance of a class (an object)
            List<string[]> data = ReadData(game_mode_static); //sets up a list of array of strings (similar to a 2D array of strings, but lists have differences from arrays - like a variable length), which is then set the the result of the read data method (with the game mode as the parameter)
            //note the array of string will be refered to as a record, as it is storing data associated with specific fields, therefor the data list of array of string will be refered to as an array of records
            bool new_player_name = true; //Stores wether a new record needs to be added to the data array. It is set to initially true and will be changed to false if a the same player name as the on input in the game form is found in a record in the data array
            for (int i = 0; i < data.Count(); i++) { //a number of iterations equal to the number of records in the data array (for i from 0 to the lenght of data) (iterates through all the records in the data array), 
                if (data[i][0] == player_name) { //If the current records player name is the same as the players name input in the game form,
                    new_player_name = false; //set the name to not be a new same (so no record is appended to the data array)
                    if (win) { //If the current player won the match (input from the game form),
                        data[i][1] = (int.Parse(data[i][1]) + 1).ToString(); //increase the current players number of wins by one
                    } else { //If the current player lost the match (input from the game form),
                        data[i][2] = (int.Parse(data[i][2]) + 1).ToString(); //increase the current players number of losses by one
                    }
                    break;//stop the for loop, as the player has already been found
                }
            }
            if (new_player_name) { //If the player namne is a new name (it is not already stored in the csv file),
                if (win) { //If the new player won,
                    data.Add(new string[] { player_name, "1", "0" }); //add a record to the data array with the new player name, one win, and zero losses
                } else { //If the new player lost,
                    data.Add(new string[] { player_name, "0", "1" }); //add a record to the data array with the new player name, zero wins, and one loss
                }
            }
            string file_path = AppDomain.CurrentDomain.BaseDirectory; //sets the file path to the directory of the executable
            if (game_mode_static) { //If the game mode is player vs player,
                file_path += "PlayerVSPlayerleaderboard.csv"; //append the file path with the player vs player leaderboard csv file.
            } else { //If the game mode is player vs AI,
                file_path += "PlayerVSAIleaderboard.csv"; //append the file path with the player vs AI leaderboard csv file
            }
            try { //try doing the following operations
                FileStream file; //create a variable to store the reference to the file to write from
                file = File.OpenWrite(file_path); //open the file to be written to
                StreamWriter file_stream_writer = new StreamWriter(file); //open a stream writer of the file (to write the data to)
                for (int i = 0; i < data.Count(); i++) { //a number of iterations equal to the number of records in the data array (for i from 0 to the lenght of data) (iterates through all the records in the data array), 
                    file_stream_writer.WriteLine(string.Join(",", data[i])); //write the current record to the file
                }
                file_stream_writer.Close(); //close the stream reader
                file.Close(); //close the file
            } catch (Exception e) { //If an error occurs while trying these operations,
                MessageBox.Show("Writing data failed: " + e.ToString()); //display an error message saying writing the data failed with the specific error printed alonside it
            }
        }

        private void ExitToMainMenuButton_Click(object sender, EventArgs e) {  //exits the leaderboard form to the main menu form when the ExitToMainMenuButton button is clicked
            Program.MainMenu.Show(); //shows the main menu form
            this.Close(); //closes this game form
        }

        private void ListView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e) { //method that is called when a coloum in the ListViewLeaderboard is clicked. Sorts the data.
            List<string[]> data = ReadData(game_mode); //sets up a list of array of strings (similar to a 2D array of strings, but lists have differences from arrays - like a variable length), which is then set the the result of the read data method (with the game mode as the parameter)
            if (e.Column == 0) { //If the first ("Names") Coloumn was the clicked coloumn (e.Column gives the index of the clicked coloumn)
                if (sorted_column != 0 || (sorted_column == 0 && sorted_ascending == false)) { //If the leaderboard is sorted on the wins or losses coloumn, or is sorted on the names coloumn in descending order, sort the names in ascending order:
                    //sorts the names in ascending order
                    for (int i = 0; i < data.Count(); i++) { //for every record in the data array
                        for (int j = i + 1; j < data.Count(); j++) { //for every record from the i'th record in the data array
                            if (data[i][0].ToLower().ToCharArray()[0] > data[j][0].ToLower().ToCharArray()[0]) { //If the lower case first character of the i'th record's player name is larger that the lower case first character of the j'th record's player name,
                                //swap the i'th and j'th records
                                string[] temp = data[i]; //set the i'th record to a temporary array of string
                                data[i] = data[j]; //set the i'th record to the j'th record
                                data[j] = temp; //set the j'th record to the original i'th record stored in the temporary array of string
                            }
                        }
                    }
                    sorted_column = 0; //set the sorted coloumn to 0, indicating sorting on the "Names" coloumn
                    sorted_ascending = true; //set the sorted ascending variable to true, indicating ascending sorting
                } else if (sorted_column == 0 && sorted_ascending == true) { //If the leaderboard is sorted on the names coloumn in ascending order, sort the names in descending order:
                    //sorts the names in descending order
                    for (int i = 0; i < data.Count(); i++) { //for every record in the data array
                        for (int j = i + 1; j < data.Count(); j++) { //for every record from the i'th record in the data array
                            if (data[i][0].ToLower().ToCharArray()[0] < data[j][0].ToLower().ToCharArray()[0]) { //If the lower case first character of the i'th record's player name is smaller that the lower case first character of the j'th record's player name,
                                //swap the i'th and j'th records
                                string[] temp = data[i]; //set the i'th record to a temporary array of string
                                data[i] = data[j]; //set the i'th record to the j'th record
                                data[j] = temp;
                            }
                        }
                    }
                    sorted_column = 0; //set the sorted coloumn to 0, indicating sorting on the "Names" coloumn
                    sorted_ascending = false; //set the sorted ascending variable to false, indicating descending sorting
                }
            } else if (e.Column == 1 || e.Column == 2) { //If the second or third, "Wins" or "Losses," coloumns were clicked (e.Column gives the index of the clicked coloumn)
                if (sorted_column != e.Column || (sorted_column == e.Column && sorted_ascending == false)) { //If the leaderboard isn't sorted on the clicked coloumn, or is sorted on the clicked coloumn in descending order, sort this column in ascending order:
                    //sorts the wins or losses (the clicked coloumn) in ascending order
                    for (int i = 0; i < data.Count(); i++) { //for every record in the data array
                        for (int j = i + 1; j < data.Count(); j++) { //for every record from the i'th record in the data array
                            if (int.Parse(data[i][e.Column]) < int.Parse(data[j][e.Column])) { //If the wins/losses of the i'th record is smaller than the wins/losses of the j'th record,
                                //swap the i'th and j'th records
                                string[] temp = data[i]; //set the i'th record to a temporary array of string
                                data[i] = data[j];
                                data[j] = temp;
                            }
                        }
                    }
                    sorted_column = e.Column; //set the sorted coloumn to the clicked coloumn index (given by e.Coloumn), indicating sorting on either the "Wins" or "Losses" coloumn
                    sorted_ascending = true; //set the sorted ascending variable to true, indicating ascending sorting
                } else if (sorted_column == e.Column && sorted_ascending == true) { //If the leaderboard is sorted on the clicked coloumn in ascending order, sort the names in descending order:
                    //sorts the wins or losses (the clicked coloumn) in descending order
                    for (int i = 0; i < data.Count(); i++) { //for every record in the data array
                        for (int j = i + 1; j < data.Count(); j++) { //for every record from the i'th record in the data array
                            if (int.Parse(data[i][e.Column]) > int.Parse(data[j][e.Column])) { //If the wins/losses of the i'th record is larger than the wins/losses of the j'th record,
                                //swap the i'th and j'th records
                                string[] temp = data[i]; //set the i'th record to a temporary array of string
                                data[i] = data[j]; //set the i'th record to the j'th record
                                data[j] = temp; //set the j'th record to the original i'th record stored in the temporary array of string
                            }
                        }
                    }
                    sorted_column = e.Column; //set the sorted coloumn to the clicked coloumn index (given by e.Coloumn), indicating sorting on either the "Wins" or "Losses" coloumn
                    sorted_ascending = false; //set the sorted ascending variable to false, indicating descending sorting
                }
            }
            ListView.Clear(); //clears the ListViewLeaderboard of any previous data
            DisplayData(data); //displays the sorted data
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}

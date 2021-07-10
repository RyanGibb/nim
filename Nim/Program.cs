using System.Windows.Forms;

namespace Nim {
    class Program { //class that is initialized when the program is run
        static public MainMenuForm MainMenu; //creates a static public attribute MainMenu, that is of type MainMenuForm, so that the main menu can be acceesses (specifically shown) from other classes through the program class
        static private void Main() { //constructor, creates the main menu when the program is run
            MainMenu = new MainMenuForm(); //initializes a MainMenuForm object as MainMenu
            Application.Run(MainMenu); //runs the main menu
        }
    }
}

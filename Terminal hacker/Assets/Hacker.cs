using UnityEngine;

public class Hacker : MonoBehaviour
{
    //game config data
    string[] level1passwords = { "password", "books", "children", "mother", "grounded", "dinner" };
    string[] level2passwords = { "random numbers", "math is fun", "detention", "headteacher", "english", "science" };
    string[] level3passwords = { "nebula", "dwarf star", "white dwarf", "intersteller", "the red planet", "dark matter" };

    //game state
    int level;
    string password;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen = Screen.MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    private void Update()
    {
        
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Terminal Hacker");
        Terminal.WriteLine("Who would you like to hack into? Press the number of your choice");
        Terminal.WriteLine("");
        Terminal.WriteLine("1: Your mum's laptop");
        Terminal.WriteLine("2: Your school");
        Terminal.WriteLine("3: NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }


    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    private void CheckPassword(string input)
    {
        if (input == password)
        {
            WinGame();
        }
        else
        {
            Terminal.WriteLine("incorrect password try again");
        }
    }

    private void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "69")
        {
            Terminal.WriteLine("uwu");
        }
        else
        {
            Terminal.WriteLine("please enter a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("please enter your password: ");
        switch (level) //like an if
        {
            case 1:
                password = level1passwords[Random.Range(0, (level1passwords.Length))];
                break;
            case 2:
                password = level2passwords[Random.Range(0, (level2passwords.Length))];
                break;
            case 3:
                password = level3passwords[Random.Range(0, (level3passwords.Length))];
                break;
            default:
                Debug.LogError("invalid level");
                break;
        }
    }

    void WinGame()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("You've won a cookie");
                Terminal.WriteLine(@"
                 _    _      
                | |  (_)     
  ___ ___   ___ | | ___  ___ 
 / __/ _ \ / _ \| |/ / |/ _ \
| (_| (_) | (_) |   <| |  __/
 \___\___/ \___/|_|\_\_|\___|
");
                break;
            case 2:
                Terminal.WriteLine("You've won a pen");
                break;
            case 3:
                Terminal.WriteLine("You've won a planet");
                Terminal.WriteLine(@"
                  .:'  .:
        ,MMM8&&&.:'   .:'
       MMMMM88&&&&  .:'
      MMMMM88&&&&&&:'
      MMMMM88&&&&&&
    .:MMMMM88&&&&&&
  .:'  MMMMM88&&&&
.:'   .:'MMM8&&&'
");
                break;
        }
    }
}
   


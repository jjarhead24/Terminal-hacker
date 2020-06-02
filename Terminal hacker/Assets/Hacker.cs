using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //game config data
    string[] level1passwords = {"password", "books", "children", "mother", "grounded", "dinner" };
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
        if (input == "1")
        {
            level = 1;
            password = level1passwords[2]; // make random
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = level2passwords[5];
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = level3passwords[0];
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
        Terminal.WriteLine("you selected level " + level);
        Terminal.WriteLine("please enter your password: ");

    }

    void WinGame()
    {
        currentScreen = Screen.Win;
    }
}

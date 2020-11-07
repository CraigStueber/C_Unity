using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Craig");

    }

    void ShowMainMenu(string Name)
    {
        Terminal.ClearScreen();
        var greeting = Name;
        Terminal.WriteLine("Hello " + greeting + "!");
        Terminal.WriteLine("Would you like to hack into....");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the Mayor's Office");
        Terminal.WriteLine("Press 2 for the Governor's Office");
        Terminal.WriteLine("Press 3 for the White House");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");

    }
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Craig");
        }
        else if(input == "1")
        {
            Terminal.WriteLine("You picked Mayor's Office!");
        }
        else if (input == "2")
        {
            Terminal.WriteLine("You picked Governor's Office!");
        }
        else if(input =="3")
        {
            Terminal.WriteLine("You picked the White House");
        }
        else if (input == "Megan")
        {
            Terminal.WriteLine("Megan is the prettiest lady ever!!");
        }
        else
        {
            Terminal.WriteLine("You picked nothing....");
        }

    }
}

   

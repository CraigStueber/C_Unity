using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();

    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        var greeting = "Hello Craig!";
        Terminal.WriteLine(greeting); 
        Terminal.WriteLine("Would you like to hack into....");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the Mayor's Office");
        Terminal.WriteLine("Press 2 for the Governor's Office");
        Terminal.WriteLine("Press 3 for the White House");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("Welcome to Terminal Hacker");
        Terminal.WriteLine("Who would you like to hack into? Press the number of your choice");
        Terminal.WriteLine("");
        Terminal.WriteLine("1: Your mum's laptop");
        Terminal.WriteLine("2: Your school");
        Terminal.WriteLine("3: NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

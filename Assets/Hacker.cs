﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void ShowMainMenu()
    {
        Terminal.WriteLine("Access Granted.");
        Terminal.WriteLine("Bypass Options Generated..");
        Terminal.WriteLine("1 - Library");
        Terminal.WriteLine("2 - Police Station");
    }
    
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "First String to Life";
        strings[1] = "Second String to Life";
        strings[2] = "Third String to Life";

        foreach(string item in strings)
        {
            print(item);
        }
    }

 
    void Update()
    {
        
    }
}

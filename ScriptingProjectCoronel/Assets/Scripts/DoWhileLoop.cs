using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hola don camaron");
        }
        while (shouldContinue == true);
    }

    void Update()
    {
        
    }
}

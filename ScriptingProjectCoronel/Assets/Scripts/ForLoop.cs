using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;


    void Start()
    {
       for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Ill create as much enemies as needed to keep this company alive!!");
        }
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 120.0f;
    float hotLimitTemperature = 90.0f;
    float coldLimitTemperature = 45.0f;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 7f;
    }


    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffe is too damn hot!!");
        }

        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("how is this coffee too damn cold fools!!");
        }

        else

        {
            print("Finally some good damn coffe");
        }
    }
}

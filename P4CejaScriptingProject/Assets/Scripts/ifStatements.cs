using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatements : MonoBehaviour
{
    //creating variables for the script.
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("This coffee is too hot mane!");
        }

        else if(coffeeTemperature < coldlimitTemperature)
        {
            print("This coffee taste like ice mane!");
        }

        else
        {
            print("Coffee is perfect mane!");
        }
    }
}

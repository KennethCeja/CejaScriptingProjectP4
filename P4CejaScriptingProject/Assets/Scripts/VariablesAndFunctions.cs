using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    // this is a variable
    int myInt = 48;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myInt);
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // this is a function
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}

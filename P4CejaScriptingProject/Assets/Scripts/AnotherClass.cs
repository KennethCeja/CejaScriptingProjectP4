using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples = 4;
    public int bananas = 8;
    private int stapler;
    private int sellotape;
    //Add two public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        

    }
    public void FruitMachine(int a, int b)
    {
        int answer;

        answer = a + b;

        Debug.Log("Fruit total is: " + answer);
    }
    public void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("");
    }
   
}


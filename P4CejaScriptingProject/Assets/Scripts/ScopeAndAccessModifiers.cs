using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //adding a public variable in the class.
    public int alpha = 5;
    private int beta = 0;
    private int gamma = 5;
    private AnotherClass myOtherClass;
    // Start is called before the first frame update

    void Start()
    {
        //change starting value of alpha.
        alpha = 48;
            myOtherClass = new AnotherClass();
        //i am going to use this method in another class.
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    public void ExampleMethod(int pens, int crayons)
    {
        int answer;

        answer = pens * crayons * alpha;

        Debug.Log("The answer is: " + answer);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("The value of alpha is: " + alpha);
    }
}

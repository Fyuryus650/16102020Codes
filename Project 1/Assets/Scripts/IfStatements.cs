using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "1111";
    public bool canRun = true;
    void Start()
    {

        if (a + b == c)
        {
            print("that is true");
        }

        if (password == "1111")
        {
            print("That is the correct password");
        }

        if (canRun)
        {
            print("we can run");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

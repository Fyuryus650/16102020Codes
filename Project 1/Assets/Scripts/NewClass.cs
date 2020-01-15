using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gamObj;
    private int solutionNum;
    public int x;
    public int y;
    public void Start()
    {
        solutionNum = x + y;
        print(nameString);
        print(intNum);
        print(floatNum); 
        print(gameObject);
        print(solutionNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

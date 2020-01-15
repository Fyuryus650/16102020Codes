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
    
    public void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum); 
        print(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int number;
    public float otherNumber;
    public UnityEvent enterEvent;
    public UnityEvent stayEvent;
    public UnityEvent exitEvent;
    public string stringName;

    private void OnTriggerEnter(Collider other)
    {
       enterEvent.Invoke();
       print(number);
    }

    private void OnTriggerStay(Collider other)
    {
       stayEvent.Invoke();
       print(otherNumber);
    }

    private void OnTriggerExit(Collider other)
    {
      exitEvent.Invoke();
      print(stringName);
    }
}

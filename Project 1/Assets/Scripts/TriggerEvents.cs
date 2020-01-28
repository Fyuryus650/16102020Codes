using System;
using System.Timers;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;
    public Timer duration;
    public int T;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

}

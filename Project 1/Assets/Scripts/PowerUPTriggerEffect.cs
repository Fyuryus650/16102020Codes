
using System;
using UnityEngine;
using UnityEngine.Events;

public class PowerUPTriggerEffect : MonoBehaviour
{
   public UnityEvent entryEvent;
   public UnityEvent exitEvent;
   public UnityEvent stayEvent;
   private void OnTriggerEnter(Collider other)
   {
      entryEvent.Invoke();
   }

   private void OnTriggerStay(Collider other)
   {
      stayEvent.Invoke();
   }

   private void OnTriggerExit(Collider other)
   {
      exitEvent.Invoke();
   }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event : MonoBehaviour
{
    public float floatNumber;
    public int scoreValue;
    public UnityEvent uEvent;
    
    void Start()
    {
    uEvent.Invoke();
    }

    void Update()
    {
        
    }
}

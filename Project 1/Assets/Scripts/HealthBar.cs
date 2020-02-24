using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
    private Image imageObj;
    public float health = 1f;

    public void OnCollisionEnter(Collision other)
    {
        
    }
}

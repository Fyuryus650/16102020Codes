using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightOnEvent : MonoBehaviour
{
    private Light lightObj;

    private void Start()
    {
        lightObj = GetComponent<Light>();
        lightObj.intensity = 0f;
    }

    private void Update()
    {
        
    }
}
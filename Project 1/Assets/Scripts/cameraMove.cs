using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraMove : MonoBehaviour
{
    private Camera cameraObj;

    private void Start()
    {
        cameraObj = GetComponent<Camera>();
    }
}
 

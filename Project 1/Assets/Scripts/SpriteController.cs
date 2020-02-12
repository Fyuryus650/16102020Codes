using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    public Color offColor = Color.red;
    public Color spriteColor = Color.red;
    private SpriteRenderer spriteObj;
    
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
        spriteObj.color = spriteColor;
    }

    private void OnEnable()
    {
        print("This is on");
        spriteObj.color = spriteColor;
    }

    private void OnDisable()
    {
        spriteObj.color = offColor;
    }

    void Update()
    {
        
    }
}

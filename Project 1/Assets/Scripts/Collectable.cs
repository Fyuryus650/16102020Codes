using UnityEngine;
using UnityEngine.Networking.Match;

[CreateAssetMenu]
public class Collectable : ScriptableObject
{
    public int powerLevel = 10;
    public Color colectableColor = Color.red;
    public Sprite collectableSprite;
    
}

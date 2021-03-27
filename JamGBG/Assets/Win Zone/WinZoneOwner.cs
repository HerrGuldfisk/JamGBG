using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZoneOwner : MonoBehaviour
{
    [SerializeField]
    public string playerID = "newPlayer";

    SpriteRenderer mySpriteRenderer;
    SpriteRenderer childSpriteRenderer;

    Color newColor;

    Color[] colors = {Color.blue, Color.red, 
        Color.green, Color.yellow, Color.magenta};

    public MyColor myColor;

    // Start is called before the first frame update
    void Start()
    {
        updateMyColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateMyColor()
    {
        newColor = colors[(int)myColor];
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.color = newColor;

        childSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        childSpriteRenderer.color = newColor;
    }

    public enum MyColor
    {
        Blue = 0,
        Red = 1,
        Green = 2,
        Yellow = 3,
        Magenta = 4
    };
}

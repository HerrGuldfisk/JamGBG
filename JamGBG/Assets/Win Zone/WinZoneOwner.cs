using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZoneOwner : MonoBehaviour
{
    [SerializeField]
    public string playerID = "newPlayer";

    SpriteRenderer mySpriteRenderer;

    Color newColor;

    public MyColor myColor = new MyColor();

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public enum MyColor
    {
        Blue,
        Red,
        Green,
        Yellow,
        Orange
    };

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZoneOwner : MonoBehaviour
{
    [SerializeField]
    private string playerID = "newPlayer";

    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;

    float m_Red, m_Blue, m_Green;

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = m_NewColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

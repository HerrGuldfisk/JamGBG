using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSize : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;

    private void Awake()
    {
        int choose = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[choose];

        if (choose == 1)
        {
            GetComponent<BoxCollider2D>().size = new Vector2(1.33f * 1.5f, 1.33f);
        }
        else if (choose == 2)
        {
            GetComponent<BoxCollider2D>().size = new Vector2(1.33f * 2f, 1.33f);
        }
    }

}

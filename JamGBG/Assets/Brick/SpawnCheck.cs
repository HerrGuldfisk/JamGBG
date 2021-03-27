using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheck : MonoBehaviour
{
    float delay = 0.05f;

    private void Update()
    {
        delay -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (delay > 0)
        {
            if (collision.transform.CompareTag("Brick"))
            {
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 6)
        {
            if (collision.collider.CompareTag("Brick"))
            {
                AudioManager.Instance.PlayAudio("contvcont");
            }
            else if (!collision.collider.CompareTag("Brick"))
            {
                AudioManager.Instance.PlayAudio("contvground");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float power = 25f;
    private float radius = 1.8f;

    private List<Rigidbody2D> rbList = new List<Rigidbody2D>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D cldr = collision.collider;

        if (cldr != null)
        {
            Rigidbody2D rb = cldr.GetComponent<Rigidbody2D>();

            rbList.Clear();

            if (cldr.CompareTag("Brick"))
            {
                rbList.Add(rb);
            }

            // Kan optimeras med OverlapCircle
            Collider2D[] radiusCheck = Physics2D.OverlapCircleAll(transform.position, radius);

            for (int i = 0; i < radiusCheck.Length; i++)
            {
                if (radiusCheck[i].CompareTag("Brick"))
                {
                    rbList.Add(radiusCheck[i].GetComponent<Rigidbody2D>());
                }
            }
            _explode(rbList);
        }
    }

    void _explode(List<Rigidbody2D> rbodies)
    {
        if (rbList != null)
        {
            foreach (Rigidbody2D rb in rbodies)
            {
                Vector2 direction = rb.transform.position - transform.position;
                rb.AddForceAtPosition(direction.normalized * power, transform.position, ForceMode2D.Impulse);
            } 
        }
        Destroy(gameObject);
    }
}

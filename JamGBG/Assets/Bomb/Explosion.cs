using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float power = 10f;
    private float radius = 1.5f;

    private List<Rigidbody2D> rbList = new List<Rigidbody2D>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rbList.Clear();
            rbList.Add(rb);
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
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    private float radius = 5f;
    private float bouncy = 0.10f;

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
            _freeze(rbList);
        }
    }

    void _freeze(List<Rigidbody2D> rbodies)
    {
        if (rbList != null)
        {
            foreach (Rigidbody2D rb in rbodies)
            {
                Collider2D cldr = rb.GetComponent<Collider2D>();
                cldr.enabled = false;
                PhysicsMaterial2D newMaterial = Instantiate(cldr.sharedMaterial);
                newMaterial.bounciness = bouncy;
                cldr.sharedMaterial = newMaterial;
                cldr.enabled = true;
				rb.constraints = RigidbodyConstraints2D.FreezeAll;
                // rb.bodyType = RigidbodyType2D.Static;
                rb.GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
        AudioManager.Instance.PlayAudio("freeze");
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.main.duration);
    }
}

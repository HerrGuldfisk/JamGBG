using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private float radius = 5.0f;
    private float bouncy = 0.35f;

    private List<Collider2D> cldrList = new List<Collider2D>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D cldr = collision.collider;

        if (cldr != null)
        {
            cldrList.Clear();

            if (cldr.CompareTag("Brick"))
            {
                cldrList.Add(cldr);
            }

            // Kan optimeras med OverlapCircle
            Collider2D[] radiusCheck = Physics2D.OverlapCircleAll(transform.position, radius);

            for (int i = 0; i < radiusCheck.Length; i++)
            {
                if (radiusCheck[i].CompareTag("Brick"))
                {
                    cldrList.Add(radiusCheck[i].GetComponent<Collider2D>());
                }
            }
            _bounce(cldrList);
        }
    }

    void _bounce(List<Collider2D> cldrs)
    {
        if (cldrList != null)
        {
            foreach (Collider2D cldr in cldrs)
            {
				if (cldr.GetComponent<Rigidbody2D>().constraints == RigidbodyConstraints2D.FreezeAll)
				{
					cldr.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
				}
				/*
				if (cldr.GetComponent<Rigidbody2D>().bodyType != RigidbodyType2D.Dynamic)
                {
                    cldr.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
				*/
                cldr.enabled = false;
                PhysicsMaterial2D newMaterial = Instantiate(cldr.sharedMaterial);
                newMaterial.bounciness = bouncy;
                cldr.sharedMaterial = newMaterial;
                cldr.enabled = true;

                cldr.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
        AudioManager.Instance.PlayAudio("bouncy");
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.main.duration);
    }
}

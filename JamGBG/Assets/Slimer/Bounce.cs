using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private float power = 25f;
    private float radius = 5f;

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
            _freeze(cldrList);
        }
    }

    void _freeze(List<Collider2D> cldrs)
    {
        if (cldrList != null)
        {
            foreach (Collider2D cldr in cldrs)
            {
                cldr.enabled = false;
                PhysicsMaterial2D newMaterial = Instantiate(cldr.sharedMaterial);
                newMaterial.bounciness = 1;
                cldr.sharedMaterial = newMaterial;
                cldr.enabled = true;
            } 
        }
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.main.duration);
    }
}

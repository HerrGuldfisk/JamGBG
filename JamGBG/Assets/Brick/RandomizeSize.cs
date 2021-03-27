using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSize : MonoBehaviour
{
    [SerializeField] float Wmin = 0.8f;
    [SerializeField] float Wmax = 1.6f;
    [SerializeField] float Hmin = 0.6f;
    [SerializeField] float Hmax = 1.2f;

    private void Awake()
    {
        float width = transform.localScale.x * Random.Range(Wmin, Wmax);
        float height = transform.localScale.y * Random.Range(Hmin, Hmax);
        Vector3 scale = new Vector3(width, height, transform.localScale.z);

        transform.localScale = scale;
    }

}

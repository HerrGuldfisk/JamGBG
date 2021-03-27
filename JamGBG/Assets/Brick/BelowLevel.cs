using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelowLevel : MonoBehaviour
{
	float threshold;

	private void Start()
	{
		threshold = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
	}

	// Update is called once per frame
	void FixedUpdate()
    {
        if(transform.position.y < threshold)
		{
			Destroy(gameObject);
		}
    }
}

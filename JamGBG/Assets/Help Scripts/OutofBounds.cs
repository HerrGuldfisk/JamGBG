using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
	float minX;
	float maxX;

    // Start is called before the first frame update
    void Start()
    {
		minX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
		maxX = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.scaledPixelWidth, 0, 0)).x;
	}

	private void Update()
	{
		if(transform.position.x < minX - (transform.localScale.x / 2))
		{
			transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
		}
		if(transform.position.x > maxX + (transform.localScale.x / 2))
		{
			transform.position = new Vector3(minX, transform.position.y, transform.position.z);
		}
	}

}

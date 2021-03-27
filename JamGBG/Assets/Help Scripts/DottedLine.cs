using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DottedLine : MonoBehaviour
{

	public GameObject rayCast;

	private float distance;


    // Update is called once per frame
    void Update()
    {
		RaycastHit hit;
		if (Physics.Raycast(rayCast.transform.position, new Vector3(0, -1, 0), out hit))
		{
			if(hit.collider != null)
			{
				transform.localScale = new Vector3(1f, distance, 1f);
			}

			distance = hit.distance;
		}
    }
}

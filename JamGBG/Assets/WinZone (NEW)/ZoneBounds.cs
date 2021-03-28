using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneBounds : MonoBehaviour
{
	ZoneBrain brain;

	private void Start()
	{
		brain = GetComponentInParent<ZoneBrain>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Brick"))
		{
			brain.AddPoint();
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Brick"))
		{
			brain.RemovePoint();
		}
	}
}

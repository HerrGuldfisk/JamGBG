using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllZones : MonoBehaviour
{

	[SerializeField] public GameObject[] zones;

	private void Start()
	{
		foreach (GameObject zone in zones)
		{
			zone.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0.3f);
		}
	}

	public void SetColor(Color _color)
	{
		foreach(GameObject zone in zones)
		{
			zone.GetComponent<SpriteRenderer>().color = _color;
		}
	}
}

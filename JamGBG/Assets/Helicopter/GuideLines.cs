using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideLines : MonoBehaviour
{

	public GameObject line1;
	public GameObject line2;

	public GameObject square;

	public void SetLines(Vector3 pos, float scaleX)
	{
		line1.transform.position = new Vector3(pos.x - (scaleX / 2), transform.position.y - 15, 0);
		line2.transform.position = new Vector3(pos.x + (scaleX / 2), transform.position.y - 15, 0);
	}

	public void SetRect(Vector3 pos, float scaleX)
	{
		square.transform.localScale = new Vector3(scaleX, square.transform.localScale.y, square.transform.localScale.z);
	}
}

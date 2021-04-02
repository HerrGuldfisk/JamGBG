using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetUI : MonoBehaviour
{
	public void Reset()
	{
		foreach(Transform child in transform)
		{
			if (!child.gameObject.CompareTag("WinScreen"))
			{
				Destroy(child.gameObject);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(AddPlayer());

    }
	IEnumerator AddPlayer()
	{
		yield return new WaitForSeconds(0.3f);
		FindObjectOfType<DropManager>().NewPlayerJoin(GetComponent<Drop>());
	}
}

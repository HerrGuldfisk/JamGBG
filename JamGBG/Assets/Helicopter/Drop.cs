using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Drop : MonoBehaviour
{
	public GameObject brick;

	public bool autoDrop;
	public float timer = 3f;

	public float horizontalSpeed = 5f;

	float timeLeft;

	[HideInInspector] public bool isOverlap;

	AudioSource audioSource;

	Rigidbody2D nextBody2D;

    // Start is called before the first frame update
    void Start()
    {
		audioSource = GetComponent<AudioSource>();
		timeLeft = timer;
    }

	public void OnAction(InputValue action)
	{
		if (autoDrop)
		{
			return;
		}

	}

	public void DropBrick()
	{
		if (isOverlap)
		{
			audioSource.Play();
			return;
		}

		if (nextBody2D)
		{
			nextBody2D.simulated = true;
			nextBody2D.transform.SetParent(null);
			nextBody2D.velocity = new Vector2(GetComponent<HeliMove>().dir.x * horizontalSpeed / 5f, 0);
		}

		StartCoroutine(SpawnAfterDelay(0.8f));
	}

	IEnumerator SpawnAfterDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
		nextBody2D = Instantiate(brick, transform.position + new Vector3(0, -1, 0), Quaternion.identity, transform).GetComponent<Rigidbody2D>();
	}


	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Brick"))
		{
			isOverlap = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Brick"))
		{
			isOverlap = false;
		}
	}
}

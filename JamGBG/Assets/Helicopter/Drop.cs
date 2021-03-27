using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Drop : MonoBehaviour
{
	public GameObject brick;

	public bool autoDrop;
	public float timer = 3f;

	float timeLeft;

	[HideInInspector] public bool isOverlap;

	AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
		audioSource = GetComponent<AudioSource>();
		timeLeft = timer;
    }

    // Update is called once per frame
    void Update()
    {
		if (autoDrop)
		{
			timeLeft -= Time.deltaTime;

			if(timeLeft <= 0f)
			{
				DropBrick();
				timeLeft = timer;
			}
		}
    }

	public void OnAction(InputValue action)
	{
		if (autoDrop)
		{
			return;
		}

		DropBrick();
	}

	void DropBrick()
	{
		if (isOverlap)
		{
			audioSource.Play();
			return;
		}

		Instantiate(brick, transform.position, Quaternion.identity);
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

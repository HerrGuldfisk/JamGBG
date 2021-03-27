using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
	public float timeBetweenRounds;
	private float timeBetweenPlayers;

	private float timeLeft;

	public GameObject[] dropables;

	private int[] dropChance;
	private int maxChance;

	Drop[] playerDrops;

	private int currentPlayer = 0;

    // Start is called before the first frame update
    void Start()
    {
		playerDrops = FindObjectsOfType<Drop>();

		timeBetweenPlayers = timeBetweenRounds / playerDrops.Length;

		timeLeft = timeBetweenRounds;

		dropChance = new int[dropables.Length];

		CreateDropNumber();

		print(maxChance);
    }

	// Update is called once per frame
	void Update()
    {
		timeLeft -= Time.deltaTime;

		if (timeLeft <= 0f)
		{
			playerDrops[currentPlayer].DropBrick();

			NextDrop();

			currentPlayer++;
			if(currentPlayer >= playerDrops.Length)
			{
				currentPlayer = 0;
			}

			timeLeft = timeBetweenPlayers;
		}
    }

	private void NextDrop()
	{
		GameObject nextBrick = GetBrick();
		playerDrops[currentPlayer].brick = nextBrick;
	}

	private void CreateDropNumber()
	{
		for(int i = 0; i < dropables.Length; i++)
		{
			float tempChance = dropables[i].GetComponent<BrickChance>().chance * 10;
			maxChance += (int)tempChance;
			dropChance[i] = (int)maxChance;
		}
	}

	private GameObject GetBrick()
	{
		int tempNumber = UnityEngine.Random.Range(0, maxChance);
		for(int i = 0; i < dropChance.Length; i++)
		{
			if(tempNumber <= dropChance[i])
			{
				return dropables[i];
			}
		}

		Debug.LogWarning("Shouldn't get here...");
		return null;
	}
}

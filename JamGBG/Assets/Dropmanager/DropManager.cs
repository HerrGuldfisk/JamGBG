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

	[HideInInspector] public List<Drop> playerDrops;

	private int currentPlayer = 0;

    // Start is called before the first frame update
    void Start()
    {
		Drop[] tempdrop = FindObjectsOfType<Drop>();

		for(int i = 0; i < tempdrop.Length; i++)
		{
			playerDrops.Add(tempdrop[i]);
		}

		timeBetweenPlayers = timeBetweenRounds / playerDrops.Count;

		timeLeft = timeBetweenRounds;

		dropChance = new int[dropables.Length];

		CreateDropNumber();

		foreach(int i in dropChance)
		{
			print(i);
		}
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
			if(currentPlayer >= playerDrops.Count)
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
			dropChance[i] = maxChance;
		}
	}

	private GameObject GetBrick()
	{
		int tempNumber = UnityEngine.Random.Range(0, maxChance);
		for(int i = 0; i < dropChance.Length; i++)
		{
			if(tempNumber <= dropChance[i])
			{
				Debug.Log(dropables[i].name);
				return dropables[i];
			}
		}

		Debug.LogWarning("Shouldn't get here...");
		return null;
	}

	public void NewPlayerJoin(Drop newPlayer)
	{
		playerDrops.Add(newPlayer);
		timeBetweenPlayers = timeBetweenRounds / playerDrops.Count;
	}
}

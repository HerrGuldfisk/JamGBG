using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
	public float timeBetweenRounds;
	float timeBetweenPlayers;
	float timeLeft;

	[SerializeField] GameObject defaultBrick;
	[SerializeField] GameObject[] specialBricks;
	[HideInInspector] public List<PlayerDropAndChance> playerDrops = new List<PlayerDropAndChance>();
	[Range(0, 1)] [SerializeField] float specialStartChance = 0;
	[Range(0, 1)] [SerializeField] float specialChanceIncrease = 0.1f;

	private int currentPlayer = 0;

	public class PlayerDropAndChance
    {
		public Drop playerDropScript;
		float specialDropChance;

        public PlayerDropAndChance(Drop _playerDropScript, float _specialDropChance)
        {
			playerDropScript = _playerDropScript;
			specialDropChance = _specialDropChance;
        }

		public void IncreaseDropChance(float _amount)
        {
			specialDropChance += _amount;
		}

		public float DropChance()
        {
			return specialDropChance;
        }

		public void SetDropChance(float _amount)
        {
			specialDropChance = _amount;
        }
    }

    void Start()
    {
		Drop[] dropScriptsInWorld = FindObjectsOfType<Drop>();

		for(int i = 0; i < dropScriptsInWorld.Length; i++)
		{
			playerDrops.Add(new PlayerDropAndChance(dropScriptsInWorld[i], specialStartChance));
		}

		timeBetweenPlayers = timeBetweenRounds / playerDrops.Count;

		timeLeft = timeBetweenRounds;
    }

	void Update()
    {
		timeLeft -= Time.deltaTime;

		if (timeLeft <= 0f)
		{
			PlayerBrickSwap(playerDrops[currentPlayer]);

			currentPlayer++;
			if(currentPlayer >= playerDrops.Count)
			{
				currentPlayer = 0;
			}

			timeLeft = timeBetweenPlayers;
		}
    }

	private void PlayerBrickSwap(PlayerDropAndChance _playerDropAndChance)
	{
		_playerDropAndChance.playerDropScript.DropBrick();

		if (UnityEngine.Random.value < _playerDropAndChance.DropChance())
        {
			_playerDropAndChance.playerDropScript.brick = specialBricks[UnityEngine.Random.Range(0, specialBricks.Length)];
			_playerDropAndChance.SetDropChance(specialStartChance);
		}
        else
        {
			_playerDropAndChance.playerDropScript.brick = defaultBrick;
			_playerDropAndChance.IncreaseDropChance(specialChanceIncrease);
		}
	}

	public void NewPlayerJoin(Drop newPlayer)
	{
		playerDrops.Add(new PlayerDropAndChance(newPlayer, 0));
		timeBetweenPlayers = timeBetweenRounds / playerDrops.Count;
	}
}

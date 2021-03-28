using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
	#region Singleton

	public static GameManager Instance { get; private set; } = null;

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this.gameObject);
			return;
		}

		Instance = this;
		DontDestroyOnLoad(this.gameObject);
	}

	#endregion

	public int numberOfPlayers;

	public GameObject winZone;
	public GameObject player;
	public GameObject scoreCounterText;

	[Tooltip("Time in seconds")]
	public float roundTimer;

	public TextMeshProUGUI timerText;

	// Start is called before the first frame update
	void Start()
    {
		StartCoroutine(DelayMainTheme());
    }

    // Update is called once per frame
    void Update()
    {

    }

	IEnumerator DelayMainTheme()
	{
		yield return new WaitForSecondsRealtime(0.1f);
		AudioManager.Instance.PlayAudio("mainTheme");
	}

	public void LoadScene(int index)
	{
		if (index == 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			GameState.winstate = false;
			GameState.winScreen.alpha = 0;
		}
		else
		{
			SceneManager.LoadScene(index);
			Debug.Log(numberOfPlayers);
			StartCoroutine(GetComponent<Spawner>().PlaceObjects());
			StartCoroutine(CountdownTimer());
		}
	}

	IEnumerator CountdownTimer()
	{
		yield return new WaitForSeconds(0.01f);
		float startDelay = FindObjectOfType<DropManager>().timeBetweenRounds;
		// yield return new WaitForSecondsRealtime(startDelay);

		float currentTime = roundTimer + startDelay;

		float minutes = Mathf.FloorToInt(currentTime / 60);
		float seconds = Mathf.FloorToInt(currentTime % 60);
		timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

		while (currentTime > 0)
		{
			currentTime -= Time.deltaTime;
			minutes = Mathf.FloorToInt(currentTime / 60);
			seconds = Mathf.FloorToInt(currentTime % 60);
			timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
			yield return new WaitForSeconds(Time.deltaTime);
		}
		currentTime = 0f;

		minutes = Mathf.FloorToInt(currentTime / 60);
		seconds = Mathf.FloorToInt(currentTime % 60);
		timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

		WinnerIs();
	}

	void WinnerIs()
	{
		ZoneBrain[] zones = FindObjectsOfType<ZoneBrain>();
		int maxPoints = 0;
		int playerIndex = 0;

		for(int i = 0; i < zones.Length; i++)
		{
			if(zones[i].totalPoints > maxPoints)
			{
				maxPoints = zones[i].totalPoints;
				Debug.Log("max points " + maxPoints);
				playerIndex =  zones.Length - i;
				Debug.Log("Player index: " + playerIndex);
			}
		}

		int playersWithMaxPoints = 0;

		for (int i = 0; i < zones.Length; i++)
		{
			if (zones[i].totalPoints == maxPoints)
			{
				playersWithMaxPoints += 1;

				if(playersWithMaxPoints > 1)
				{
					GameState.Win("Game is a draw!");
					return;
				}
			}
		}
		AudioManager.Instance.PlayAudio("win");
		GameState.Win("Player " + playerIndex.ToString() + " is the winner!");
	}
}

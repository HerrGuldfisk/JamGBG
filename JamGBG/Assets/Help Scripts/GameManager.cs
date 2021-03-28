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

	public float numberOfPlayers;

	public GameObject winZone;
	public GameObject ground;
	public GameObject player;
	public GameObject scoreCounterText;

	[Tooltip("Time in seconds")]
	public float roundTimer;

	public TextMeshProUGUI timerText;

	// Start is called before the first frame update
	void Start()
    {
		AudioManager.Instance.PlayAudio("mainTheme");
    }

    // Update is called once per frame
    void Update()
    {

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
			StartCoroutine(PlaceObjects());
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

		WinnerIs();
	}

	void WinnerIs()
	{
		ZoneBrain[] zones = FindObjectsOfType<ZoneBrain>();
		int maxPoints = 0;
		int player = 0;

		for(int i = 0; i < zones.Length; i++)
		{
			if(zones[i].totalPoints > maxPoints)
			{
				maxPoints = zones[i].totalPoints;
				player = i + 1;
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
					Debug.Log("Game is a draw!");
					return;
				}
			}
		}

		Debug.Log("Player " + player + " is the winner!");
	}

	IEnumerator PlaceObjects()
	{
		yield return new WaitForSeconds(.01f);

		float widthMin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
		float widthMax = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.scaledPixelWidth, 0, 0)).x;

		float heightMin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
		float heightMax = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.scaledPixelHeight, 0)).y + Mathf.Abs(heightMin);

		float distanceBetweeenZones = (widthMax - widthMin) / (numberOfPlayers + 1);
		float longDistance = (widthMax - widthMin) / numberOfPlayers;
		float shortDistance = (widthMax - widthMin) / (2 * numberOfPlayers);

		for (int i = 0; i < numberOfPlayers; i++)
		{
			// Instantiate(winZone, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + (heightMax * 0.75f), 0), Quaternion.identity).GetComponent<WinZoneOwner>().playerID = "Player " + (i + 1).ToString();
			GameObject zone = Instantiate(winZone, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + (heightMax * 0.03f), 0), Quaternion.identity);
			zone.transform.SetParent(null);

			Vector3 zonePos = Camera.main.WorldToScreenPoint(zone.transform.position);

			GameObject tempText = Instantiate(scoreCounterText, new Vector3(zonePos.x - 120, zonePos.y + 50, 0), Quaternion.identity);
			tempText.transform.SetParent(FindObjectOfType<Canvas>().transform);
			zone.GetComponent<ZoneBrain>().scoreTextField = tempText;
		}

		for(int i = 0; i < numberOfPlayers; i++)
		{
			if(i == 0)
			{
				Destroy(Instantiate(player, new Vector3(10000, heightMin + (heightMax * 0.8f), 0), Quaternion.identity), 0.01f);
				Instantiate(player, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + (heightMax * 0.8f), 0), Quaternion.identity);
			}
			else
			{
				Debug.Log("Player joined");
				GameObject temp = Instantiate(player, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + (heightMax * 0.8f), 0), Quaternion.identity);
				temp.GetComponent<PlayerInput>().SwitchCurrentActionMap("Gamer" + i.ToString());
				temp.transform.SetParent(null);
			}


		}
	}
}

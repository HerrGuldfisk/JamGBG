using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

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

	// Start is called before the first frame update
	void Start()
    {

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
		}
	}

	IEnumerator PlaceObjects()
	{
		yield return new WaitForSeconds(.01f);

		float widthMin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
		float widthMax = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.scaledPixelWidth, 0, 0)).x;

		float heightMin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
		float heightMax = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.scaledPixelHeight, 0)).y + Mathf.Abs(heightMin);

		float distanceBetweeenZones = (widthMax - widthMin) / (numberOfPlayers + 1);

		for(int i = 0; i < numberOfPlayers; i++)
		{
			Instantiate(winZone, new Vector3(widthMin + distanceBetweeenZones * (i + 1), heightMin + (heightMax * 0.75f), 0), Quaternion.identity).GetComponent<WinZoneOwner>().playerID = "Player " + (i + 1).ToString();
			Instantiate(ground, new Vector3(widthMin + distanceBetweeenZones * (i + 1), heightMin + (heightMax * 0.03f), 0), Quaternion.identity);
		}

		for(int i = 0; i < numberOfPlayers; i++)
		{
			if(i == 0)
			{
				Destroy(Instantiate(player, new Vector3(10000, heightMin + (heightMax * 0.8f), 0), Quaternion.identity), 0.01f);
				Instantiate(player, new Vector3(widthMin + distanceBetweeenZones * (i + 1), heightMin + (heightMax * 0.8f), 0), Quaternion.identity);
			}
			else
			{
				Debug.Log("Player joined");
				GameObject temp = Instantiate(player, new Vector3(widthMin + distanceBetweeenZones * (i + 1), heightMin + (heightMax * 0.8f), 0), Quaternion.identity);
				temp.GetComponent<PlayerInput>().SwitchCurrentActionMap("Gamer" + i.ToString());
				temp.transform.SetParent(null);
			}


		}
	}
}

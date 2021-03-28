using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{

	GameObject winZone;
	GameObject player;
	GameObject scoreCounterText;
	int numberOfPlayers;

	[SerializeField] Sprite[] closedHookSprites;
	[SerializeField] Sprite[] openHookSprites;
	[SerializeField] Sprite[] platformSprites;

	public IEnumerator PlaceObjects()
	{
		winZone = GameManager.Instance.winZone;
		player = GameManager.Instance.player;
		scoreCounterText = GameManager.Instance.scoreCounterText;
		numberOfPlayers = GameManager.Instance.numberOfPlayers;

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
			GameObject zone = Instantiate(winZone, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + 3, 0), Quaternion.identity);
			zone.transform.SetParent(null);

			Vector3 zonePos = Camera.main.WorldToScreenPoint(zone.transform.position);

			GameObject tempText = Instantiate(scoreCounterText, new Vector3(zonePos.x - 120, zonePos.y + 50, 0), Quaternion.identity);
			tempText.transform.SetParent(FindObjectOfType<Canvas>().transform);
			zone.GetComponent<ZoneBrain>().scoreTextField = tempText;

			//SET GROUND SPRITE
			foreach (Transform child in zone.transform)
            {
				if (child.CompareTag("Ground"))
                {
					child.GetComponent<SpriteRenderer>().sprite = platformSprites[i];
                }
            }
		}

		for (int i = 0; i < numberOfPlayers; i++)
		{
			GameObject newPlayer;
			if (i == 0)
			{
				Destroy(Instantiate(player, new Vector3(10000, heightMin + (heightMax * 0.8f), 0), Quaternion.identity), 0.01f);
				newPlayer = Instantiate(player, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + heightMax - 2.15f, 0), Quaternion.identity);
			}
			else
			{
				Debug.Log("Player joined");
				newPlayer = Instantiate(player, new Vector3(widthMin + shortDistance + longDistance * i, heightMin + heightMax - 2.15f, 0), Quaternion.identity);
				newPlayer.GetComponent<PlayerInput>().SwitchCurrentActionMap("Gamer" + i.ToString());
				newPlayer.transform.SetParent(null);
			}
			newPlayer.GetComponent<SpriteRenderer>().sprite = closedHookSprites[i];
			newPlayer.GetComponent<Drop>().closedHook = closedHookSprites[i];
			newPlayer.GetComponent<Drop>().openHook = openHookSprites[i];
		}
	}
}

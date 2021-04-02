using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
	GameState gameState;

	private void Start()
	{
		gameState = FindObjectOfType<GameState>();
	}

	//improve by not checking trigger each frame - instead check only when colliding with a new brick

	private void OnTriggerStay2D(Collider2D trigger)
    {
        if (gameState.winstate==false && trigger.GetComponent<WinZoneOwner>())
        {
            Collider2D[] contacts = new Collider2D[10];
            ContactFilter2D contactFilter = new ContactFilter2D();
            GetComponent<Collider2D>().OverlapCollider(contactFilter, contacts);

            foreach(Collider2D collider in contacts)
            {
                if (collider)
                {
                    if (collider.CompareTag("Brick"))
                    {
                        gameState.Win(trigger.GetComponent<WinZoneOwner>().playerID);
                    }
                }
            }
        }
    }
}

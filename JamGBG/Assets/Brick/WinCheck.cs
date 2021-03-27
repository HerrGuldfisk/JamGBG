using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    //improve by not checking trigger each frame - instead check only when colliding with a new brick

    private void OnTriggerStay2D(Collider2D trigger)
    {
        if (GameState.winstate==false && trigger.GetComponent<WinZoneOwner>())
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
                        GameState.Win(trigger.GetComponent<WinZoneOwner>().playerID);
                    }
                }
            }
        }
    }
}

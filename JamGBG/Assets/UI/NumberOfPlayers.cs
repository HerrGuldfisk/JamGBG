using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class NumberOfPlayers : MonoBehaviour
{

	[SerializeField] public string[] numPlayers;
	public TextMeshProUGUI textField;

	private int currentPlayers = 2;


	public void OnMove(InputValue value)
	{
		Vector2 dir = value.Get<Vector2>();

		if(dir.x > 0)
		{
			if(currentPlayers == 4)
			{
				currentPlayers = 2;
			}
			else
			{
				currentPlayers += 1;
			}
		}
		if(dir.x < 0)
		{
			if (currentPlayers == 2)
			{
				currentPlayers = 4;
			}
			else
			{
				currentPlayers -= 1;
			}
		}
		textField.text = numPlayers[currentPlayers - 2];

	}

	public void OnSubmit()
	{
		GameManager.Instance.numberOfPlayers = currentPlayers;
		GameManager.Instance.LoadScene(1);
	}
}

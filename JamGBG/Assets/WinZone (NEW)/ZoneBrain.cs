using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZoneBrain : MonoBehaviour
{
	public int totalPoints;

	public GameObject scoreTextField;

	public void AddPoint()
	{
		totalPoints += 1;
		ChangeText();
	}

	public void RemovePoint()
	{
		totalPoints -= 1;
		ChangeText();
	}

	void ChangeText()
	{
		scoreTextField.GetComponent<TextMeshProUGUI>().text = totalPoints.ToString();
	}
}

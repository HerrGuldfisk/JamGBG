using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class GameState : MonoBehaviour
{
    public bool winstate = false;
    public CanvasGroup winScreen;

    public void Win(string winner)
    {
		CanvasGroup winScreen = FindObjectOfType<CanvasGroup>();
		winScreen.GetComponentInChildren<TextMeshProUGUI>().text = winner;
        winScreen.alpha = 1;
        winstate = true;
		Time.timeScale = 0;
    }

	public void OnReload()
	{
		CanvasGroup winScreen = FindObjectOfType<CanvasGroup>();
		FindObjectOfType<ResetUI>().Reset();

		winstate = false;
		winScreen.alpha = 0;
		Time.timeScale = 1;
		GameManager.Instance.LoadScene(1);
	}
}

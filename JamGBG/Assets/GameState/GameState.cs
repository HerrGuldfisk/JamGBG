using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class GameState : MonoBehaviour
{
    public static bool winstate = false;
    public static CanvasGroup winScreen;

    private void Start()
    {
        winScreen = GameObject.FindGameObjectWithTag("WinScreen").GetComponent<CanvasGroup>();
    }

    public static void Win(string winner)
    {
        winScreen.GetComponentInChildren<TextMeshProUGUI>().text = winner;
        winScreen.alpha = 1;
        winstate = true;
		Time.timeScale = 0;
    }

	public void OnReload()
	{
		winstate = false;
		winScreen.alpha = 0;
		Time.timeScale = 1;
		GameManager.Instance.LoadScene(1);
	}
}

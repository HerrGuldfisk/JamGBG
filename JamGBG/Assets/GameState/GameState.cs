using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

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
        winScreen.GetComponentInChildren<Text>().text = winner + " is the winner!";
        winScreen.alpha = 1;
        winstate = true;
    }

	public void OnReload()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		winstate = false;
		winScreen.alpha = 0;
	}
}

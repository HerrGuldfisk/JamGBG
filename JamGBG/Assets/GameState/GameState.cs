using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public static bool winstate = false;
    static CanvasGroup winScreen;

    private void Awake()
    {
        winScreen = GameObject.FindGameObjectWithTag("WinScreen").GetComponent<CanvasGroup>();
    }

    public static void Win(string winner)
    {
        winScreen.GetComponentInChildren<Text>().text = winner + " is the winner!";
        winScreen.alpha = 1;
        winstate = true;
    }
}

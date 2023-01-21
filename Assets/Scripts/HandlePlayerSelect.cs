using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlePlayerSelect : MonoBehaviour
{
    public static int numPlayers = 1;

    public void handlePlayer1Select()
    {
        numPlayers = 1;

        Debug.Log($"Player {numPlayers} Selected");

        SceneManager.LoadScene("Game Screen");
    }

    public void handlePlayer2Select()
    {
        numPlayers = 2;

        Debug.Log($"Player {numPlayers} Selected");

        SceneManager.LoadScene("Game Screen");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void privacyPolicy()
    {
        Application.OpenURL("https://sites.google.com/view/mini-tennis-policy-privacy/home");
    }
}

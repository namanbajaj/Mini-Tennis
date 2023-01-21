using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextP1;
    public GameObject scoreTextP2;

    public int goalsToWin;

    private void Start()
    {
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.scorePlayer1 >= this.goalsToWin || this.scorePlayer2 >= this.goalsToWin)
        {
            Debug.Log("A player won");
            SceneManager.LoadScene("Game Over");
        }
    }

    private void FixedUpdate()
    {
        TMP_Text uiScoreP1 = this.scoreTextP1.GetComponent<TMP_Text>();
        uiScoreP1.text = this.scorePlayer1.ToString();

        TMP_Text uiScoreP2 = this.scoreTextP2.GetComponent<TMP_Text>();
        uiScoreP2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        scorePlayer2++;
    }
}

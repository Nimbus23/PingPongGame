using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;
    public GameObject textWinner;


    public int goalToWin;

    // Update is called once per frame
    void Update()
    {
        if (this.scorePlayer1 >= this.goalToWin)
        {  
            SceneManager.LoadScene("WinScreen1");
        }else if (this.scorePlayer2 >= this.goalToWin)
        {
            SceneManager.LoadScene("WinScreen2");
        }
    }

    private void FixedUpdate()
    {
        TextMeshProUGUI uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<TextMeshProUGUI>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        TextMeshProUGUI uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<TextMeshProUGUI>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}

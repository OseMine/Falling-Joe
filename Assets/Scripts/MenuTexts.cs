using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuTexts : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public Text Score;
    public Text HighScore;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        Score.text = score.ToString() + " POINTS";

    }
    public void SetupH(int highscore)
    {
        gameObject.SetActive(true);
        HighScore.text = "HIGHSCORE: " + highscore.ToString();
    }
}

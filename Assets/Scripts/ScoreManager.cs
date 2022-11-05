using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    //public GameOverScreen GameOverScreen;

    public Text scoreText;
    public Text highscoreText;
    public Text GameOverScoreText;

    int score = 0;
    int highscore = 0;
    int GameOverScore = 0;

    public void GameOver()
    {
        //GameOverScreen.Setup(score);

    }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        GameOverScore = PlayerPrefs.GetInt("GameOverScore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        GameOverScoreText.text = score.ToString() + " POINTS";
    }

    public void AddPoint()
    {
        score +=1;
        GameOverScore += 1;
        scoreText.text = score.ToString() + " POINTS";
        GameOverScoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        PlayerPrefs.SetInt("GameOverScore", score);


    }




}

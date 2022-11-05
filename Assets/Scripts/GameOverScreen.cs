using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverScreen : MonoBehaviour {

    public Text pointsText;
    public Text highscoreText;

    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";

    }
    public void SetupH(int highscore) {
        gameObject.SetActive(true);
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void RestartButton() {
        SceneManager.LoadScene("Game");
    }

        public void ExitButton() {
        SceneManager.LoadScene("Menu");
    }

        public void OptionsButton() {
        SceneManager.LoadScene("Options");
    }
    public void LeadeboardButton()
    {
        SceneManager.LoadScene("Leaderboard");
    }

}

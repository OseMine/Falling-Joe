using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class KillPlayer : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public GameObject Score;
    public GameObject Highscore;
    public int Respawn;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")) {

            SceneManager.LoadScene(Respawn);
            //GameOverScreen.gameObject.SetActive(true);
            //Score.gameObject.SetActive(false);
            //Highscore.gameObject.SetActive(false);


        }
    }
}

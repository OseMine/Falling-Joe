using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Rigidbody2D rb;
    //public GameOverScreen GameOverScreen;


    /*public void GameOver() {
        GameOverScreen.Setup(score);
    }*/


    // Start is called before the first frame update
    void Start() {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(4, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 8);
        }


    }
    

    }


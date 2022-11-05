using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInstance : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        ScoreManager.instance.AddPoint();
    }
}

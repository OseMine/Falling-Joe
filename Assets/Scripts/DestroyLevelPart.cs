using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevelPart : MonoBehaviour
{

    [SerializeField] public GameObject LevelPart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(LevelPart);
        Debug.Log(LevelPart + "Destroyed");
    }
}

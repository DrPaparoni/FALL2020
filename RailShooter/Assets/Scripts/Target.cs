using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject breakFX;
    [SerializeField] Transform parent; // placeholder to destroy deathFX when done
    [SerializeField] int scorePerHit = 12;

    ScoreBoard scoreBoard;
    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }


    void OnMouseDown()
    {
        GameObject fx = Instantiate(breakFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        //ScoreBoard scoreBoard = FindObjectOfType<ScoreBoard>();
        scoreBoard.ScoreHit(scorePerHit);

        Destroy(gameObject);

    }
}

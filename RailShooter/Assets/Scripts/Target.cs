using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject breakFX;
    [SerializeField] Transform parent; // placeholder to destroy deathFX when done
    [SerializeField] int scorePerHit = 12;
    
    GameObject[] targets;
    ScoreBoard scoreBoard;
    AmmoCounter ammoCounter;
    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        ammoCounter = FindObjectOfType<AmmoCounter>();
    }

    void Update()
    {
        findTargets();
    }

    void OnMouseDown()
    {
        if (ammoCounter.ammoCount != 0)
        {
            destroyTarget();
        }
        else
        {
            print("Clip empty! RELOAD with R!");
        }
        print("Targets left: " + targets.Length);
        if (targets.Length == 1)
        {
            LoadNextLevel();
        }
    }

    private void destroyTarget()
    {
        GameObject fx = Instantiate(breakFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        //ScoreBoard scoreBoard = FindObjectOfType<ScoreBoard>();
        scoreBoard.ScoreHit(scorePerHit);
        

        Destroy(gameObject);
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);
    }

    private void findTargets()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
        int numOfTargets = targets.Length;
    }
}

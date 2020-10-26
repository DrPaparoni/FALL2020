using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //[SerializeField] GameObject breakFX;
    void Start()
    {

    }


    void OnMouseDown()
    {
        // Destroys target when clicked on
        Destroy(gameObject);

        // Activates break particles
        //breakFX.SetActive(true);
    }
}

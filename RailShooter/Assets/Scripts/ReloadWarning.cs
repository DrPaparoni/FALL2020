using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class ReloadWarning : MonoBehaviour
{
    Text reloadText;

    AmmoCounter ammoCounter;
    // Start is called before the first frame update
    void Start()
    {
        reloadText = GetComponent<Text>();
        ammoCounter = FindObjectOfType<AmmoCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ammoCounter.ammoCount != 0)
        {
            reloadText.text = ("");
        }
        else
        {
            reloadText.text = ("Out of Ammo!   " + "   Reload with 'R'");
        }
    }
}

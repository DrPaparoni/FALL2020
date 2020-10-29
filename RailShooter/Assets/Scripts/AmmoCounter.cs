using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AmmoCounter : MonoBehaviour
{
    public int ammoCount;
    [SerializeField] int maxAmmo = 12;    
    Text ammoText;

    // Start is called before the first frame update
    void Start()
    {
        ammoText = GetComponent<Text>();
        ammoCount = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = ("Ammo: " + ammoCount.ToString() + " ");
        Shoot();
    }

    public void DecreaseAmmo()
    {
        ammoCount--;
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammoCount != 0)
            {
                DecreaseAmmo();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ammoCount = maxAmmo;
        }
    }
}

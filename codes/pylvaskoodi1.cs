using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class pylvaskoodi1 : MonoBehaviour
{
    //liitetään pylvääseen, jossa törmäystunniste
    private GameObject pvalo = null;
    private GameObject pvalo1 = null;


    void Start()
    {
        this.pvalo = GameObject.Find("pylväsvalo");
        this.pvalo1 = GameObject.Find("pylväsvalo (1)");
    }

    //reagoidaan törmäykseen laittamalla valo päälle
    private void OnTriggerEnter(Collider other)
    {
        //sytytetään valo pelaajalle
        if (other.name.Equals("FPSController"))
        {
            this.pvalo.GetComponent<Light>().enabled = true;
            this.pvalo1.GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //sammutetaan valo pelaajan poistuessa törmäysalueelta
        if (other.name.Equals("FPSController"))
        {
            this.pvalo.GetComponent<Light>().enabled = false;
            this.pvalo1.GetComponent<Light>().enabled = false;
        }
    }
}

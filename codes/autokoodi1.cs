using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class autokoodi1 : MonoBehaviour
{
    //liitetään autoon, jossa törmäystunniste
    private GameObject avalo = null;
    private GameObject avalo1 = null;
    private GameObject avalo2 = null;
    private GameObject avalo3 = null;
    private GameObject avalo4 = null;

    void Start()
    {
        this.avalo = GameObject.Find("autovalo");
        this.avalo1 = GameObject.Find("autovalo (1)");
        this.avalo2 = GameObject.Find("autovalo (2)");
        this.avalo3= GameObject.Find("autovalo (3)");
        this.avalo4= GameObject.Find("autovalo (4)");
    }

    //reagoidaan törmäykseen laittamalla valo päälle
    private void OnTriggerEnter(Collider other)
    {
        //sytytetään valo pelaajalle
        if (other.name.Equals("FPSController"))
        {
            this.avalo.GetComponent<Light>().enabled = true;
            this.avalo1.GetComponent<Light>().enabled = true;
            this.avalo2.GetComponent<Light>().enabled = true;
            this.avalo3.GetComponent<Light>().enabled = true;
            this.avalo4.GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //sammutetaan valo pelaajan poistuessa törmäysalueelta
        if (other.name.Equals("FPSController"))
        {
            this.avalo.GetComponent<Light>().enabled = false;
            this.avalo1.GetComponent<Light>().enabled = false;
            this.avalo2.GetComponent<Light>().enabled = false;
            this.avalo3.GetComponent<Light>().enabled = false;
            this.avalo4.GetComponent<Light>().enabled = false;
        }
    }
}

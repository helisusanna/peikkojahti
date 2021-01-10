using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class talokoodi1 : MonoBehaviour
{
    //liitetään taloon, jossa törmäystunniste
    private GameObject tvalo = null;
    private GameObject tvalo1 = null;
    private GameObject tvalo2 = null;
    private GameObject tvalo3 = null;
    private GameObject tvalo4 = null;
    private GameObject tvalo5 = null;
    private GameObject tvalo6 = null;
    private GameObject tvalo7 = null;
    private GameObject tvalo8 = null;
    private GameObject tvalo9 = null;
    private GameObject tvalo10 = null;
    private GameObject tvalo11 = null;
    private GameObject tvalo12 = null;

    void Start()
    {
        this.tvalo = GameObject.Find("talovalo");
        this.tvalo1 = GameObject.Find("talovalo (1)");
        this.tvalo2 = GameObject.Find("talovalo (2)");
        this.tvalo3= GameObject.Find("talovalo (3)");
        this.tvalo4 = GameObject.Find("talovalo (4)");
        this.tvalo5 = GameObject.Find("talovalo (5)");
        this.tvalo6 = GameObject.Find("talovalo (6)");
        this.tvalo7 = GameObject.Find("talovalo (7)");
        this.tvalo8 = GameObject.Find("talovalo (8)");
        this.tvalo9 = GameObject.Find("talovalo (9)");
        this.tvalo10 = GameObject.Find("talovalo (10)");
        this.tvalo11 = GameObject.Find("talovalo (11)");
        this.tvalo12 = GameObject.Find("talovalo (12)");
    }

    //reagoidaan törmäykseen laittamalla valo päälle
    private void OnTriggerEnter(Collider other)
    {
        //sytytetään valo pelaajalle
        if (other.name.Equals("FPSController"))
        {
            this.tvalo.GetComponent<Light>().enabled = true;
            this.tvalo1.GetComponent<Light>().enabled = true;
            this.tvalo2.GetComponent<Light>().enabled = true;
            this.tvalo3.GetComponent<Light>().enabled = true;
            this.tvalo4.GetComponent<Light>().enabled = true;
            this.tvalo5.GetComponent<Light>().enabled = true;
            this.tvalo6.GetComponent<Light>().enabled = true;
            this.tvalo7.GetComponent<Light>().enabled = true;
            this.tvalo8.GetComponent<Light>().enabled = true;
            this.tvalo9.GetComponent<Light>().enabled = true;
            this.tvalo10.GetComponent<Light>().enabled = true;
            this.tvalo11.GetComponent<Light>().enabled = true;
            this.tvalo12.GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //sammutetaan valo pelaajan poistuessa törmäysalueelta
        if (other.name.Equals("FPSController"))
        {
            this.tvalo.GetComponent<Light>().enabled = false;
            this.tvalo1.GetComponent<Light>().enabled = false;
            this.tvalo2.GetComponent<Light>().enabled = false;
            this.tvalo3.GetComponent<Light>().enabled = false;
            this.tvalo4.GetComponent<Light>().enabled = false;
            this.tvalo5.GetComponent<Light>().enabled = false;
            this.tvalo6.GetComponent<Light>().enabled = false;
            this.tvalo7.GetComponent<Light>().enabled = false;
            this.tvalo8.GetComponent<Light>().enabled = false;
            this.tvalo9.GetComponent<Light>().enabled = false;
            this.tvalo10.GetComponent<Light>().enabled = false;
            this.tvalo11.GetComponent<Light>().enabled = false;
            this.tvalo12.GetComponent<Light>().enabled = false;
        }
    }
}

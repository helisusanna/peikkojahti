using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loppukoodi1 : MonoBehaviour
{
    private GameObject valo = null;
    private GameObject teksti= null;
    private float laskuri = 0;
    void Start()
    {
        this.valo = GameObject.Find("valo");
        this.teksti = GameObject.Find("teksti");
    }

    //lopetusskenessä (gameoverskene) peikko kuolee, pelaaja voittaa
    void Update()
    {
        if (this.laskuri < 3)
        {
            this.valo.GetComponent<Transform>().Rotate(-75f * Time.deltaTime / 1.3f, 0f, 0f);
            this.laskuri = laskuri + Time.deltaTime;
            Debug.Log("Laskuri: " + this.laskuri);
        } else {
            this.laskuri = laskuri+0;
            this.teksti.GetComponent<TextMesh>().text = "VOITIT PELIN";
        }
    }
}

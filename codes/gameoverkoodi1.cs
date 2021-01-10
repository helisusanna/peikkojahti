using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class gameoverkoodi1 : MonoBehaviour
{

    private GameObject peikko = null;
    private GameObject tippuja = null;

    void Start()
    {
        this.peikko = GameObject.Find("peikko");
        this.tippuja = GameObject.Find("FPSController");
    }

    //jos peikkoon on osuttu, siirrytään skeneen gameoverskene, pelaaja voittaa pelin
    //jos pelaaja tipahtaa alustalta, siirrytään skeneen gameoverskene2, pelaaja häviää pelin

    void Update()
    {
        if (this.peikko.GetComponent<Transform>().position.y == 2.03f)
        {
            SceneManager.LoadScene(2);
        }
        if (this.tippuja.GetComponent<Transform>().position.y < -50f)
        {
            SceneManager.LoadScene(3);
        }
    }
}

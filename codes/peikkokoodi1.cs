using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityEngine.SceneManagement;

public class peikkokoodi1 : MonoBehaviour
{

    private GameObject peikko = null;

    void Start()
    {
        this.peikko = GameObject.Find("peikko");
    }

    private void OnTriggerEnter(Collider other)
    { //kun osutaan peikkoon, peikko kuolee, siirrytään lopetusskeneen (gameoverskene)
        if (other.name.Equals("FPSController"))
        {
            this.peikko.GetComponent<Transform>().Translate(0f, 1.5f, 0f);
        }
    }
}

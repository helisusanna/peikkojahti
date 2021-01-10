using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            //lopetetaan ohjelman suoritus
            Application.Quit();
        }
    }
}

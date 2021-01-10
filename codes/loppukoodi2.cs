using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loppukoodi2 : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("ääni").GetComponents<AudioSource>()[0].Play();
    }
}

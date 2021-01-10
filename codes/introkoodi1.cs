using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class introkoodi1 : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("ääni").GetComponents<AudioSource>()[0].Play();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
    }
}

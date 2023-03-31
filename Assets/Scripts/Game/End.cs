using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public bool porte = false;
    public string sceneToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            porte = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && porte)
        {
            if (GameObject.Find("Player").GetComponent<Inventory>().c.Equals(true))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            porte = false;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Femme : MonoBehaviour
{
    public bool femme = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            femme = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && femme)
        {
            if (GameObject.Find("Player").GetComponent<Inventory>().bloom.Equals(false))
            {
                GameObject.Find("Player").GetComponent<Inventory>().bloom = true;
                Debug.Log(GameObject.Find("Player").GetComponent<Inventory>().bloom);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            femme = false;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findKey : MonoBehaviour
{
    public bool caisse = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            caisse = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && caisse)
        {
            if (GameObject.Find("Player").GetComponent<Inventory>().key.Equals(false))
            {
                GameObject.Find("Player").GetComponent<Inventory>().key = true;
                Debug.Log(GameObject.Find("Player").GetComponent<Inventory>().key);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            caisse = false;
        }
    }
}
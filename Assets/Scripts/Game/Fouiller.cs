using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fouiller : MonoBehaviour
{
    public bool bed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            bed = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && bed)
        {
            if (GameObject.Find("Player").GetComponent<Inventory>().pq.Equals(false))
            {
                GameObject.Find("Player").GetComponent<Inventory>().pq = true;
                Debug.Log(GameObject.Find("Player").GetComponent<Inventory>().pq);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            bed = false;
        }
    }
}
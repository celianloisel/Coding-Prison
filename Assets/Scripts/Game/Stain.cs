using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stain : MonoBehaviour
{
    public bool stain = true;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && GameObject.Find("Player").GetComponent<Inventory>().bloom.Equals(true))
        {
            Destroy(GameObject.FindWithTag("Stain"));
        }
    }
}
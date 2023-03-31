using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class Porte2 : MonoBehaviour
    {
        
        public string levelToLoad;
        public bool porte = false;
        private void Update()
        {
            if (GameObject.Find("Player").GetComponent<Inventory>().key.Equals(true))
            {
                porte = true;
            }
        }
        
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player") && porte)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
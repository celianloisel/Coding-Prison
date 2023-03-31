using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class Porte : MonoBehaviour
    {
        
        public string levelToLoad;
        public bool porte = true;
        private void Update()
        {
            if (GameObject.FindGameObjectsWithTag("Stain").Length < 1)
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
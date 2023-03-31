using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class StartCinematic : MonoBehaviour
    {
        public bool wc = false;
        public string levelToLoad;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                wc = true;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && wc)
            {
                if (GameObject.Find("Player").GetComponent<Inventory>().pq.Equals(true))
                {
                    SceneManager.LoadScene(levelToLoad);
                }
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                wc = false;
            }
        }
    }
}
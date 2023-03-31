using UnityEngine;
using UnityEngine.SceneManagement;

namespace Bot
{
    public class Spot : MonoBehaviour
    {
        private Timer timer;
        public string sceneToLoad;

        void Start()
        {
            timer = FindObjectOfType<Timer>();
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneToLoad);
                Destroy(timer.gameObject);
            }
        }
    }
}
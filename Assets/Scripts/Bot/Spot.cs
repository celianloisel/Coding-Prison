using UnityEngine;

namespace Bot
{
    public class Spot : MonoBehaviour
    {
        private Timer timer;

        void Start()
        {
            timer = FindObjectOfType<Timer>();
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(timer.gameObject);
            }
        }
    }
}
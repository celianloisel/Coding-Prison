using UnityEngine;

namespace Bot
{
    public class Spot : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Application.Quit();
            }
        }
    }
}
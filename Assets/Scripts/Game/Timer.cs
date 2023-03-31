using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    private bool timerRunning;
    public string levelToLoad;

    void Start()
    {
        startTime = Time.time;
        elapsedTime = 0f;
        timerRunning = true;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if(timerRunning)
        {
            elapsedTime = Time.time - startTime;
            float remainingTime = 10 * 60 - elapsedTime;
            Debug.Log("Temps restant : " + remainingTime.ToString("F2") + " secondes");

            if(remainingTime <= 0f)
            {
                Debug.Log("Temps écoulé !");
                SceneManager.LoadScene(levelToLoad);
                timerRunning = false;
            }
        }
    }

    void OnLevelWasLoaded(int level)
    {
        startTime = Time.time - elapsedTime;
    }
}
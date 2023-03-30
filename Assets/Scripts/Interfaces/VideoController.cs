using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string sceneToLoad;

    void Start()
    {
        // Attache un gestionnaire d'événements pour détecter la fin de la vidéo
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        // Charge la scène spécifiée à la fin de la vidéo
        SceneManager.LoadScene(sceneToLoad);
    }
}

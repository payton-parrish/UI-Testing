using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Pause : MonoBehaviour
{
    public VideoPlayer video;

    void OnEnable()
    {
        if(video!=null)
            video.Pause();
    }

    void OnDisable()
    {
        if(video!=null)
            video.Play();
    }
}

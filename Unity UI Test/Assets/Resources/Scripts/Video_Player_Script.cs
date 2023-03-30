using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Player_Script : MonoBehaviour
{
    public VideoClip test;
    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.Find("Controller").GetComponent<Controller_Script>().video;
        this.GetComponent<VideoPlayer>().clip = test;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

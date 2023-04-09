using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video_Player_Script : MonoBehaviour
{
    public VideoClip test;
    public double CurrentTime;
    public double EndTime;
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("Controller") != null)
        {
            test = GameObject.Find("Controller").GetComponent<Controller_Script>().video;
            this.GetComponent<VideoPlayer>().clip = test;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(test != null && GameObject.Find("Controller") != null)
        {
            this.GetComponent<VideoPlayer>().SetDirectAudioVolume(0,GameObject.Find("Controller").GetComponent<Controller_Script>().volume);
        }
        EndTime = this.GetComponent<VideoPlayer>().length;
        CurrentTime = this.GetComponent<VideoPlayer>().time;
        if(EndTime-0.1 <= CurrentTime)
        {
            SceneManager.LoadScene("Menus");
        }
    }
}

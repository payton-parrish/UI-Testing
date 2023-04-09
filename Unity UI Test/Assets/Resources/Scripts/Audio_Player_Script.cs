using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Player_Script : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<AudioSource>().volume = GameObject.Find("Controller").GetComponent<Controller_Script>().volume;
    }
}

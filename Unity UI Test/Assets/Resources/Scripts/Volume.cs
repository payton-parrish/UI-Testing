using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    //public AudioMixer mixer;
    void OnEnable()
    {
        this.GetComponent<Slider>().value = GameObject.Find("Controller").GetComponent<Controller_Script>().volume;
    }

    public void SetLevel (float sliderValue)
    {
        //mixer.SetFloat ("MasterVolume", Mathf.Log10 (sliderValue) * 20);
        GameObject.Find("Controller").GetComponent<Controller_Script>().volume = sliderValue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Controller_Script : MonoBehaviour
{
    public GameObject prefab;
    public VideoClip video;
    public float volume;
    public bool cardboard = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas").transform.Find("Main").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Select Neo").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Settings").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Description").gameObject.SetActive(false);
    }
}

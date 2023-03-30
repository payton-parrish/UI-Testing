using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPrefabScript : MonoBehaviour
{
    public string VideoName;
    public string VideoDescription;
    public enum VideoTypes
    {
        Static,
        Interactive
    };
    public int VideoNumber;
    public VideoTypes VideoType;
    public VideoClip TheVideo;
    public int minutes;
    public int seconds;
    public Sprite VideoThumbnail;

    public GameObject Controller;
    public GameObject Canvas;
    public GameObject SelectNeo;
    public GameObject Description;
    public Controller_Script Script;

    void Start()
    {
        minutes = Convert.ToInt32(TheVideo.length)/60;
        seconds = Convert.ToInt32(TheVideo.length)%60;
    }

    public void OnClick()
    {
        Controller = GameObject.Find("Controller");
        Canvas = GameObject.Find("Canvas");

        Script = Controller.GetComponent<Controller_Script>();
        Script.prefab = this.gameObject;
        Script.video = TheVideo;

        SelectNeo = Canvas.transform.Find("Select Neo").gameObject;
        SelectNeo.SetActive(false);
        Description = Canvas.transform.Find("Description").gameObject;
        Description.SetActive(true);
    }
}

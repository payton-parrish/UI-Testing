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
    public Sprite VideoThumbnail;
}

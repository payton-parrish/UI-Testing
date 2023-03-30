using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Controller_Script : MonoBehaviour
{
    private GameObject Canvas;
    private GameObject Main;
    private GameObject Select;
    private GameObject SelectNeo;
    private GameObject Settings;
    private GameObject Description;

    public GameObject prefab;
    public VideoClip video;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        Main = Canvas.transform.Find("Main").gameObject;
        Select = Canvas.transform.Find("Select").gameObject;
        SelectNeo = Canvas.transform.Find("Select Neo").gameObject;
        Settings = Canvas.transform.Find("Settings").gameObject;
        Description = Canvas.transform.Find("Description").gameObject;
        Main.SetActive(true);
        Select.SetActive(false);
        SelectNeo.SetActive(false);
        Settings.SetActive(false);
        Description.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

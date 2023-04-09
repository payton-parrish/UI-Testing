using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Controller") && GameObject.Find("Cameras"))
        {
            camera = GameObject.Find("Cameras");
            if(GameObject.Find("Controller").GetComponent<Controller_Script>().cardboard == true)
            {
                camera.transform.Find("LeftCamera").gameObject.SetActive(true);
                camera.transform.Find("RightCamera").gameObject.SetActive(true);
                camera.transform.Find("Main Camera").gameObject.SetActive(false);
            } 
            else
            {
                camera.transform.Find("LeftCamera").gameObject.SetActive(false);
                camera.transform.Find("RightCamera").gameObject.SetActive(false);
                camera.transform.Find("Main Camera").gameObject.SetActive(true);
            }         
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidingButtons : MonoBehaviour
{
    //public GameObject template;
    public Button[] Buttonz;

    public void Start()
    {
        Buttonz = GetComponentsInChildren<Button>(true);
        int count = 0;
        foreach(Button i in Buttonz)
        {
            i.transform.position = new Vector3(count*140*2,250,0);
            count++;
        }
    }

    /*public void Slider(float sliderValue)
    {
        
    }*/
}

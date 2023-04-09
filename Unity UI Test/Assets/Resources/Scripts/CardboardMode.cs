using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardboardMode : MonoBehaviour
{
    void OnEnable()
    {
        this.GetComponent<Toggle>().isOn = GameObject.Find("Controller").GetComponent<Controller_Script>().cardboard;
    }
    public void Toggle (bool toggle)
    {
        GameObject.Find("Controller").GetComponent<Controller_Script>().cardboard = toggle;
    }
}

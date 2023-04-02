using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Selection : MonoBehaviour
{
    public GameObject obj;
    public Slider S;

    public void Update()
    {
        S = (Slider)GetComponent(typeof(Slider));
        obj.transform.position = new Vector3(140+(S.value)*140*2,0,0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Description_Update : MonoBehaviour
{
    // Start is called before the first frame update
    public string output;
    private GameObject Controller;
    private GameObject VideoPrefab;
    void OnEnable()
    {
        output = "";
        if(GameObject.Find("Controller"))
        {
            Controller = GameObject.Find("Controller");
            if(Controller.gameObject.GetComponent<Controller_Script>().prefab)
            {
                VideoPrefab = Controller.gameObject.GetComponent<Controller_Script>().prefab;
                output = output + "Name: " + VideoPrefab.GetComponent<VideoPrefabScript>().VideoName + "\n";
                output = output + "Length: " + VideoPrefab.GetComponent<VideoPrefabScript>().minutes + ":" + VideoPrefab.GetComponent<VideoPrefabScript>().seconds + "\n";
                output = output + "Type: " + VideoPrefab.GetComponent<VideoPrefabScript>().VideoType + "\n";
                output = output + "Description: " + VideoPrefab.GetComponent<VideoPrefabScript>().VideoDescription + "\n";
                this.gameObject.GetComponent<TMP_Text>().text = output;
            }
        }
    }
}

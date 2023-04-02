using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Select_Menu_Script : MonoBehaviour
{
    public Object[] videos; 
    public GameObject missingText;
    public GameObject list;
    public Slider slides;
    // Start is called before the first frame update
    void Start()
    {
        missingText.GetComponent<TMPro.TextMeshProUGUI>().text = "Currently no videos.";
        missingText.SetActive(false);
        slides.gameObject.SetActive(false);
        slides.value = 0;
        videos = Resources.LoadAll("Images and Videos/Video Prefabs");
        if (videos.Length == 0)
        {
            missingText.SetActive(true);
        }
        else
        {
            list = new GameObject("List");
            list.transform.parent = this.transform;
            for(int i = 0; i < videos.Length; i++)
            {
                ((GameObject)videos[i]).GetComponent<VideoPrefabScript>().VideoNumber = i+5;
                ((GameObject)videos[i]).transform.Find("Image").gameObject.GetComponent<Image>().sprite = ((GameObject)videos[i]).GetComponent<VideoPrefabScript>().VideoThumbnail;
                Instantiate(videos[i], new Vector3(150+275*i,250,0), new Quaternion(0,0,0,0),list.transform);
            }
        }
        if (videos.Length > 4)
        {
            slides.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        list.transform.position = new Vector3((275*(videos.Length-4))*(-slides.value),0,0);
    }
}

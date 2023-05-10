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
    public Vector3 StartingPosition;
    // Start is called before the first frame update
    void Start()
    {
        missingText.GetComponent<TMPro.TextMeshProUGUI>().text = "Currently no videos.";
        missingText.SetActive(false);
        slides.gameObject.SetActive(false);
        slides.value = 0;
        StartingPosition = list.GetComponent<RectTransform>().anchoredPosition3D;
        videos = Resources.LoadAll("Images and Videos/Video Prefabs");
        if (videos.Length == 0)
        {
            missingText.SetActive(true);
        }
        else
        {
            for(int i = 0; i < videos.Length; i++)
            {
                ((GameObject)videos[i]).transform.Find("Text (TMP) (2)").GetComponent<TMPro.TextMeshProUGUI>().text = ((GameObject)videos[i]).GetComponent<VideoPrefabScript>().VideoName;
                ((GameObject)videos[i]).GetComponent<VideoPrefabScript>().VideoNumber = i;
                ((GameObject)videos[i]).transform.Find("Image").gameObject.GetComponent<Image>().sprite = ((GameObject)videos[i]).GetComponent<VideoPrefabScript>().VideoThumbnail;
                ((GameObject)videos[i]).GetComponent<RectTransform>().anchoredPosition3D = /*StartingPosition +*/ new Vector3(-450+450f*i,0,0);
                Instantiate(videos[i],list.transform);
            }
        }
        if (videos.Length > 3)
        {
            slides.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //list.GetComponent<RectTransform>().localScale = new Vector3(2,2,2);
        list.GetComponent<RectTransform>().anchoredPosition3D = StartingPosition + new Vector3((900f*(videos.Length-3))*(-slides.value),0,0);
        //list.transform.SetPositionAndRotation(Vector3.zero,new Quaternion(0,0,0,0));
    }
}
